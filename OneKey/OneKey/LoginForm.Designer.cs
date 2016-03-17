using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace OneKey
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblOneKey = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pnlErro = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblErroMsg = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.pnlErro.SuspendLayout();
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
            this.lblOneKey.Location = new System.Drawing.Point(364, 202);
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
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(396, 476);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(73, 36);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(512, 476);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(106, 36);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(475, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblLogo.Image")));
            this.lblLogo.Location = new System.Drawing.Point(394, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(202, 207);
            this.lblLogo.TabIndex = 4;
            // 
            // tbID
            // 
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbID.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.tbID.ForeColor = System.Drawing.Color.Silver;
            this.tbID.Location = new System.Drawing.Point(396, 326);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(200, 20);
            this.tbID.TabIndex = 5;
            this.tbID.Text = "输入你的ID";
            this.tbID.Enter += new System.EventHandler(this.tbID_Enter);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Location = new System.Drawing.Point(396, 394);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(200, 20);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Text = "输入你的密码";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            // 
            // pnlErro
            // 
            this.pnlErro.BackColor = System.Drawing.Color.White;
            this.pnlErro.Controls.Add(this.btnOK);
            this.pnlErro.Controls.Add(this.lblErroMsg);
            this.pnlErro.Controls.Add(this.lblErro);
            this.pnlErro.Location = new System.Drawing.Point(0, 167);
            this.pnlErro.Name = "pnlErro";
            this.pnlErro.Size = new System.Drawing.Size(980, 287);
            this.pnlErro.TabIndex = 7;
            this.pnlErro.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnOK.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnOK.Location = new System.Drawing.Point(853, 199);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 50);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblErroMsg
            // 
            this.lblErroMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblErroMsg.Font = new System.Drawing.Font("Segoe UI Semilight", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lblErroMsg.ForeColor = System.Drawing.Color.Black;
            this.lblErroMsg.Location = new System.Drawing.Point(188, 100);
            this.lblErroMsg.Name = "lblErroMsg";
            this.lblErroMsg.Size = new System.Drawing.Size(568, 49);
            this.lblErroMsg.TabIndex = 1;
            this.lblErroMsg.Text = "Please Check Your LoginID Or Password";
            // 
            // lblErro
            // 
            this.lblErro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI Light", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lblErro.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblErro.Location = new System.Drawing.Point(306, 0);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(349, 100);
            this.lblErro.TabIndex = 0;
            this.lblErro.Text = "Login Erro";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(980, 610);
            this.Controls.Add(this.pnlErro);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblOneKey);
            this.Controls.Add(this.lblLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.pnlErro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOneKey;
        private Button btnLogin;
        private Button btnRegister;
        private Label label1;
        private Label lblLogo;
        private TextBox tbID;
        private TextBox tbPassword;
        private Panel pnlErro;
        private Label lblErroMsg;
        private Label lblErro;
        private Button btnOK;

    }
}

