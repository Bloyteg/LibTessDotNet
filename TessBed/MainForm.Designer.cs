﻿namespace TessBed
{
    partial class MainForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelAsset = new System.Windows.Forms.ToolStripLabel();
            this.toolStripAssets = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelWinding = new System.Windows.Forms.ToolStripLabel();
            this.toolStripWinding = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelPolySize = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPolySize = new System.Windows.Forms.ToolStripTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMain});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusMain
            // 
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelAsset,
            this.toolStripAssets,
            this.toolStripSeparator1,
            this.toolStripLabelWinding,
            this.toolStripWinding,
            this.toolStripSeparator2,
            this.toolStripLabelPolySize,
            this.toolStripPolySize});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(684, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // toolStripLabelAsset
            // 
            this.toolStripLabelAsset.Name = "toolStripLabelAsset";
            this.toolStripLabelAsset.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabelAsset.Text = "Asset";
            // 
            // toolStripAssets
            // 
            this.toolStripAssets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripAssets.Name = "toolStripAssets";
            this.toolStripAssets.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelWinding
            // 
            this.toolStripLabelWinding.Name = "toolStripLabelWinding";
            this.toolStripLabelWinding.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabelWinding.Text = "Winding";
            // 
            // toolStripWinding
            // 
            this.toolStripWinding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripWinding.Name = "toolStripWinding";
            this.toolStripWinding.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelPolySize
            // 
            this.toolStripLabelPolySize.Name = "toolStripLabelPolySize";
            this.toolStripLabelPolySize.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabelPolySize.Text = "Vertices";
            // 
            // toolStripPolySize
            // 
            this.toolStripPolySize.Name = "toolStripPolySize";
            this.toolStripPolySize.Size = new System.Drawing.Size(40, 25);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(684, 515);
            this.panel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibTessDotNet - TessBed";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusMain;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripComboBox toolStripAssets;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAsset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelWinding;
        private System.Windows.Forms.ToolStripComboBox toolStripWinding;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPolySize;
        private System.Windows.Forms.ToolStripTextBox toolStripPolySize;
    }
}
