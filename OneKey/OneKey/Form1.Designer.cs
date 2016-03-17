using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace OneKey
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblOneKey = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOneKey
            // 
            this.lblOneKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOneKey.AutoSize = true;
            this.lblOneKey.BackColor = System.Drawing.Color.Transparent;
            this.lblOneKey.Font = new System.Drawing.Font("Segoe UI Light", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lblOneKey.ForeColor = System.Drawing.Color.White;
            this.lblOneKey.Location = new System.Drawing.Point(360, 197);
            this.lblOneKey.Name = "lblOneKey";
            this.lblOneKey.Size = new System.Drawing.Size(254, 81);
            this.lblOneKey.TabIndex = 0;
            this.lblOneKey.Text = "One Key";
            this.lblOneKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(378, 485);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(73, 36);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(507, 485);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(98, 36);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblLogo.Image")));
            this.lblLogo.Location = new System.Drawing.Point(386, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(202, 207);
            this.lblLogo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(980, 610);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblOneKey);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOneKey;
        private Button btnLogin;
        private Button btnRegister;
        private Label label1;
        private Label lblLogo;

    }
}

