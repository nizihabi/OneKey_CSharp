﻿namespace OneKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblLine01 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLine01
            // 
            this.lblLine01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLine01.Image = ((System.Drawing.Image)(resources.GetObject("lblLine01.Image")));
            this.lblLine01.Location = new System.Drawing.Point(240, 50);
            this.lblLine01.Name = "lblLine01";
            this.lblLine01.Size = new System.Drawing.Size(13, 530);
            this.lblLine01.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 530);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlMsg
            // 
            this.pnlMsg.Controls.Add(this.lblType);
            this.pnlMsg.Controls.Add(this.label1);
            this.pnlMsg.Location = new System.Drawing.Point(240, 50);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(800, 530);
            this.pnlMsg.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Black;
            this.lblType.Font = new System.Drawing.Font("Segoe UI Light", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(-1, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(800, 83);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(235, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 437);
            this.label1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 580);
            this.Controls.Add(this.pnlMsg);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblLine01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.pnlMsg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLine01;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblType;

    }
}