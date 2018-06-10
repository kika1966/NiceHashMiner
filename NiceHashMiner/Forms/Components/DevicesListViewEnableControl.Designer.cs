﻿namespace NiceHashMiner.Forms.Components {
    partial class DevicesListViewEnableControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.listViewDevices = new System.Windows.Forms.ListView();
            this.devicesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEnable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDevices
            // 
            this.listViewDevices.CheckBoxes = true;
            this.listViewDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.devicesHeader});
            this.listViewDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDevices.FullRowSelect = true;
            this.listViewDevices.GridLines = true;
            this.listViewDevices.Location = new System.Drawing.Point(0, 0);
            this.listViewDevices.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewDevices.Name = "listViewDevices";
            this.listViewDevices.Size = new System.Drawing.Size(1294, 582);
            this.listViewDevices.TabIndex = 5;
            this.listViewDevices.UseCompatibleStateImageBehavior = false;
            this.listViewDevices.View = System.Windows.Forms.View.Details;
            // 
            // devicesHeader
            // 
            this.devicesHeader.Text = "Enabled";
            this.devicesHeader.Width = 350;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEnable,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(334, 76);
            // 
            // toolStripMenuItemEnable
            // 
            this.toolStripMenuItemEnable.Name = "toolStripMenuItemEnable";
            this.toolStripMenuItemEnable.Size = new System.Drawing.Size(333, 36);
            this.toolStripMenuItemEnable.Text = "Enable Benchmark";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(333, 36);
            this.toolStripMenuItem1.Text = "Copy Benchmark From";
            // 
            // DevicesListViewEnableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewDevices);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DevicesListViewEnableControl";
            this.Size = new System.Drawing.Size(1294, 582);
            this.Resize += new System.EventHandler(this.DevicesListViewEnableControl_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ListView listViewDevices;
        protected System.Windows.Forms.ColumnHeader devicesHeader;
        protected System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEnable;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
