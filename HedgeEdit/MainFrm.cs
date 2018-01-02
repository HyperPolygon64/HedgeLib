﻿using HedgeLib;
using HedgeLib.Sets;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace HedgeEdit
{
    public partial class MainFrm : Form
    {
        // Variables/Constants
        public static SceneView SceneView
        {
            get => sceneView;
        }

        public SetObject SelectedSetObject
        {
            get
            {
                // Returns the currently-selected set object if only one is selected
                return (SelectedObjects.Count == 1) ?
                    (SelectedObjects[0] as SetObject) : null;
            }
        }

        public SetObjectTransform SelectedTransform
        {
            get
            {
                // Returns the transform of the currently-selected set object
                // if only one object is selected.
                var obj = SelectedSetObject;

                return (obj == null) ? ((SelectedObjects.Count == 1) ?
                    (SelectedObjects[0] as SetObjectTransform) :
                    null) : obj.Transform;
            }
        }

        public List<object> SelectedObjects = new List<object>();
        private static SceneView sceneView = null;
        private Thread loadSaveThread;
        private Control activeTxtBx = null;

        // Constructors
        public MainFrm()
        {
            InitializeComponent();
            UpdateTitle();
            Application.Idle += Application_Idle;
            statusBarLbl.Text = "";
        }

        // Methods
        public void RefreshGUI()
        {
            // Get the selected object(s), if any
            int selectedObjs = SelectedObjects.Count;
            bool objsSelected = (selectedObjs > 0),
                 singleObjSelected = (selectedObjs == 1);

            SetObject obj = (singleObjSelected) ?
                (SelectedObjects[0] as SetObject) : null;
            SetObjectTransform transform = (obj == null) ? ((singleObjSelected) ?
                (SelectedObjects[0] as SetObjectTransform) :
                null) : obj.Transform;

            // Update Labels
            objectSelectedLbl.Text = $"{selectedObjs} Object(s) Selected";

            // Enable/Disable EVERYTHING
            posXBox.Enabled = posYBox.Enabled = posZBox.Enabled =
            rotXBox.Enabled = rotYBox.Enabled = rotZBox.Enabled =
            viewSelectedBtn.Enabled =
            viewSelectedMenuItem.Enabled = singleObjSelected;

            removeObjectBtn.Enabled = objsSelected;

            // Update Position Boxes
            posXBox.Text = (transform != null) ? transform.Position.X.ToString() : "0";
            posYBox.Text = (transform != null) ? transform.Position.Y.ToString() : "0";
            posZBox.Text = (transform != null) ? transform.Position.Z.ToString() : "0";

            // Update Rotation Boxes
            var eulerAngles = (transform != null) ?
                transform.Rotation.ToEulerAngles() : new Vector3();

            rotXBox.Text = eulerAngles.X.ToString();
            rotYBox.Text = eulerAngles.Y.ToString();
            rotZBox.Text = eulerAngles.Z.ToString();

            // Update Parameters
            objectTypeLbl.Text = (obj != null) ? obj.ObjectType : "";
            objectProperties.Items.Clear();

            if (obj == null) return;
            var objTemplate = (Stage.GameType == null ||
                    !Stage.GameType.ObjectTemplates.ContainsKey(obj.ObjectType)) ?
                    null : Stage.GameType.ObjectTemplates[obj.ObjectType];

            for (int i = 0; i < obj.Parameters.Count; ++i)
            {
                var param = obj.Parameters[i];
                var templateParam = objTemplate?.Parameters[i];

                var lvi = new ListViewItem((templateParam == null) ?
                    $"Parameter {i}" : templateParam.Name)
                {
                    ToolTipText = templateParam?.Description
                };

                lvi.SubItems.Add(param.Data.ToString());
                objectProperties.Items.Add(lvi);
            }
        }

        public void UpdateTitle(string stgID = null)
        {
            Text = string.Format("{0} - {1}",
                (string.IsNullOrEmpty(stgID)) ? "Untitled" : stgID,
                Program.Name);
        }

        public void UpdateStatus(string status)
        {
            statusBarLbl.Text = status;
        }

        public void UpdateProgress(int progress)
        {
            statusBarProgressBar.Value = progress;
        }

        public void UpdateProgressVisible(bool visible)
        {
            statusBarProgressBar.Visible = visible;
        }

        public void RefreshSceneView()
        {
            if (sceneView != null)
                sceneView.RefreshView();
        }

        // GUI Events
        #region MainFrm/Viewport Events
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Handle these shortcut keys only if no textBoxes are in focus
            if (activeTxtBx != null)
                return base.ProcessCmdKey(ref msg, keyData);

            switch (keyData)
            {
                // Undo Changes
                case Keys.Control | Keys.Z:
                    undoMenuItem.PerformClick();
                    return true;

                // Cut Selected Object(s)
                case Keys.Control | Keys.X:
                    cutMenuItem.PerformClick();
                    return true;

                // Copy Selected Object(s)
                case Keys.Control | Keys.C:
                    copyMenuItem.PerformClick();
                    return true;

                // Paste Selected Object(s)
                case Keys.Control | Keys.V:
                    pasteMenuItem.PerformClick();
                    return true;

                // Delete Selected Object(s)
                case Keys.Delete:
                    deleteMenuItem.PerformClick();
                    return true;

                // Select All
                case Keys.Control | Keys.A:
                    selectAllMenuItem.PerformClick();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            LuaScript.Initialize();
            LuaTerminal.InitLog();
            GameList.Load(Program.StartupPath);
            Viewport.Init(viewport);
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            while (viewport.IsIdle)
            {
                Viewport.Render();
            }
        }

        private void Viewport_Paint(object sender, PaintEventArgs e)
        {
            Viewport.Render();
        }

        private void Viewport_Resize(object sender, EventArgs e)
        {
            Viewport.Resize(viewport.Width, viewport.Height);
        }

        private void Viewport_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Viewport.IsMovingCamera = true;
                Cursor.Hide();
            }
        }

        private void Viewport_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Viewport.IsMovingCamera = false;
                Cursor.Show();
            }
        }
        #endregion

        #region NumTxtBx Events
        private void NumTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txtBx = sender as TextBox;
            if (txtBx == null) return;

            // If the pressed key is enter, stop typing
            if (e.KeyChar == (char)Keys.Return)
            {
                ActiveControl = null;
                e.Handled = true;
                return;
            }

            // If the pressed key isn't a control key, digit, or
            // the first decimal point, don't accept it.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                ((e.KeyChar != '.') || (txtBx.Text.IndexOf('.') > -1)))
            {
                e.Handled = true;
            }
        }

        private void NumTxtBx_Enter(object sender, EventArgs e)
        {
            activeTxtBx = sender as Control;
        }

        private void NumTxtBx_Leave(object sender, EventArgs e)
        {
            var txtBx = sender as TextBox;
            if (txtBx == null) return;

            if (float.TryParse(txtBx.Text, out float f))
            {
                txtBx.Text = f.ToString();
            }
            else
            {
                txtBx.Text = "0";
            }

            activeTxtBx = null;
        }
        #endregion

        #region File Menu Events
        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTitle();
            statusBarLbl.Text = "";

            Viewport.Clear();
            RefreshSceneView();

            // TODO: Ask for GameType
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            var openDialog = new StgOpenDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                // Update title
                UpdateTitle(openDialog.StageID);

                // Load stage
                // TODO: Stop any previous loading threads before starting this new one
                loadSaveThread = new Thread(new ThreadStart(() =>
                {
                    // Load the stage
                    Stage.Load(openDialog.DataDir,
                        openDialog.StageID, GameList.Games[openDialog.GameID]);

                    // Update GUI
                    Invoke(new Action(() =>
                    {
                        statusBarLbl.Text = "Done Loading";
                        statusBarProgressBar.Visible = false;
                        openMenuItem.Enabled = saveSetsMenuItem.Enabled = true;
                    }));
                }));

                openMenuItem.Enabled = saveSetsMenuItem.Enabled = false;
                loadSaveThread.Start();
            }
        }

        private void SaveSetsMenuItem_Click(object sender, EventArgs e)
        {
            loadSaveThread = new Thread(new ThreadStart(() =>
            {
                // Save the sets
                Stage.SaveSets();

                // Update GUI
                Invoke(new Action(() =>
                {
                    statusBarLbl.Text = "Done Saving";
                    statusBarProgressBar.Visible = false;
                    openMenuItem.Enabled = saveSetsMenuItem.Enabled = true;
                }));
            }));

            openMenuItem.Enabled = saveSetsMenuItem.Enabled = false;
            loadSaveThread.Start();
        }

        private void SaveAllMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Edit Menu Events
        private void UndoMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void RedoMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void CutMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void SelectAllMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void SelectNoneMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void SceneViewMenuItem_Click(object sender, EventArgs e)
        {
            if (sceneViewMenuItem.Checked)
            {
                if (sceneView == null || sceneView.IsDisposed)
                {
                    sceneView = new SceneView();
                    sceneView.Show();
                }
                else
                {
                    sceneView.Focus();
                }
            }
            else if (sceneView != null)
            {
                if (!sceneView.IsDisposed)
                    sceneView.Close();

                sceneView = null;
            }
        }
        #endregion

        private void ViewSelected(object sender, EventArgs e)
        {
            if (SelectedObjects.Count == 1)
            {
                var selectedTransform = SelectedTransform;
                if (selectedTransform == null) return;

                Viewport.CameraPos =
                    Types.ToOpenTK(selectedTransform.Position * 
                    ((Stage.GameType == null) ? 1 : Stage.GameType.UnitMultiplier));

                // TODO: Set rotation
            }
            else if (SelectedObjects.Count > 0)
            {
                // TODO: Show all of the objects currently selected.
            }
        }

        private void OpenLuaTerminal(object sender, EventArgs e)
        {
            if (LuaTerminal.Instance == null || LuaTerminal.Instance.IsDisposed)
            {
                var terminal = new LuaTerminal();
                terminal.Show();
            }
            else
            {
                LuaTerminal.Instance.Focus();
            }
        }
    }
}