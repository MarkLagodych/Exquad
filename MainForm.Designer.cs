/*
Copyright 2022  Mark Lagodych

This file is part of Exquad.

Exquad is free software: you can redistribute it and/or modify it under the
terms of the GNU General Public License as published by the Free Software
Foundation, either version 3 of the License, or (at your option) any later
version.

Exquad is distributed in the hope that it will be useful, but WITHOUT ANY
WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR
A PARTICULAR PURPOSE. See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with
Exquad. If not, see <https://www.gnu.org/licenses/>.
*/

namespace Exquad
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.fileExplorer1 = new Exquad.FileExplorer();
            this.fileExplorer2 = new Exquad.FileExplorer();
            this.fileExplorer3 = new Exquad.FileExplorer();
            this.fileExplorer4 = new Exquad.FileExplorer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerRight);
            this.splitContainer1.Size = new System.Drawing.Size(984, 761);
            this.splitContainer1.SplitterDistance = 490;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.fileExplorer1);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.fileExplorer3);
            this.splitContainerLeft.Size = new System.Drawing.Size(490, 761);
            this.splitContainerLeft.SplitterDistance = 380;
            this.splitContainerLeft.TabIndex = 0;
            this.splitContainerLeft.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerLeft_SplitterMoved);
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.fileExplorer2);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.fileExplorer4);
            this.splitContainerRight.Size = new System.Drawing.Size(490, 761);
            this.splitContainerRight.SplitterDistance = 380;
            this.splitContainerRight.TabIndex = 0;
            this.splitContainerRight.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerRight_SplitterMoved);
            // 
            // fileExplorer1
            // 
            this.fileExplorer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileExplorer1.Location = new System.Drawing.Point(0, 0);
            this.fileExplorer1.Name = "fileExplorer1";
            this.fileExplorer1.Size = new System.Drawing.Size(488, 378);
            this.fileExplorer1.TabIndex = 0;
            this.fileExplorer1.Text = "fileExplorer1";
            // 
            // fileExplorer2
            // 
            this.fileExplorer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileExplorer2.Location = new System.Drawing.Point(0, 0);
            this.fileExplorer2.Name = "fileExplorer2";
            this.fileExplorer2.Size = new System.Drawing.Size(488, 378);
            this.fileExplorer2.TabIndex = 0;
            this.fileExplorer2.Text = "fileExplorer2";
            // 
            // fileExplorer3
            // 
            this.fileExplorer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileExplorer3.Location = new System.Drawing.Point(0, 0);
            this.fileExplorer3.Name = "fileExplorer3";
            this.fileExplorer3.Size = new System.Drawing.Size(488, 375);
            this.fileExplorer3.TabIndex = 0;
            this.fileExplorer3.Text = "fileExplorer3";
            // 
            // fileExplorer4
            // 
            this.fileExplorer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileExplorer4.Location = new System.Drawing.Point(0, 0);
            this.fileExplorer4.Name = "fileExplorer4";
            this.fileExplorer4.Size = new System.Drawing.Size(488, 375);
            this.fileExplorer4.TabIndex = 0;
            this.fileExplorer4.Text = "fileExplorer4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Exquad";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private FileExplorer fileExplorer1;
        private FileExplorer fileExplorer3;
        private FileExplorer fileExplorer2;
        private FileExplorer fileExplorer4;
    }
}

