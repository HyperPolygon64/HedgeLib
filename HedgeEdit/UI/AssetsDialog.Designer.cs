﻿namespace HedgeEdit.UI
{
    partial class AssetsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetsDialog));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Objects", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Models", 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Materials", 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Textures", 0);
            this.folderImgList = new System.Windows.Forms.ImageList(this.components);
            this.assetsList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // folderImgList
            // 
            this.folderImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("folderImgList.ImageStream")));
            this.folderImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.folderImgList.Images.SetKeyName(0, "folderImg");
            this.folderImgList.Images.SetKeyName(1, "documentImg");
            // 
            // assetsList
            // 
            this.assetsList.BackColor = System.Drawing.Color.White;
            this.assetsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetsList.FullRowSelect = true;
            this.assetsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.assetsList.LargeImageList = this.folderImgList;
            this.assetsList.Location = new System.Drawing.Point(0, 0);
            this.assetsList.Name = "assetsList";
            this.assetsList.Size = new System.Drawing.Size(228, 444);
            this.assetsList.SmallImageList = this.folderImgList;
            this.assetsList.TabIndex = 0;
            this.assetsList.UseCompatibleStateImageBehavior = false;
            this.assetsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AssetsList_MouseDoubleClick);
            // 
            // AssetsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 444);
            this.Controls.Add(this.assetsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssetsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Assets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList folderImgList;
        private System.Windows.Forms.ListView assetsList;
    }
}