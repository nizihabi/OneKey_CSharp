namespace OneKey
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.labID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblIDErro = new System.Windows.Forms.Label();
            this.lblPwdErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.labID.ForeColor = System.Drawing.Color.Black;
            this.labID.Location = new System.Drawing.Point(45, 46);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(99, 35);
            this.labID.TabIndex = 0;
            this.labID.Text = "User ID";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.tbID.Location = new System.Drawing.Point(143, 48);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(208, 34);
            this.tbID.TabIndex = 1;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lblPwd.ForeColor = System.Drawing.Color.Black;
            this.lblPwd.Location = new System.Drawing.Point(25, 144);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(120, 35);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Password";
            // 
            // tbPwd
            // 
            this.tbPwd.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.tbPwd.Location = new System.Drawing.Point(143, 144);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(208, 34);
            this.tbPwd.TabIndex = 3;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Black;
            this.lblConfirm.Location = new System.Drawing.Point(34, 204);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(106, 35);
            this.lblConfirm.TabIndex = 4;
            this.lblConfirm.Text = "Confirm";
            // 
            // tbConfirm
            // 
            this.tbConfirm.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.tbConfirm.Location = new System.Drawing.Point(143, 206);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(208, 34);
            this.tbConfirm.TabIndex = 5;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.White;
            this.btnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnReg.ForeColor = System.Drawing.Color.Black;
            this.btnReg.Image = ((System.Drawing.Image)(resources.GetObject("btnReg.Image")));
            this.btnReg.Location = new System.Drawing.Point(143, 304);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(145, 49);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(143, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 49);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblIDErro
            // 
            this.lblIDErro.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lblIDErro.ForeColor = System.Drawing.Color.Red;
            this.lblIDErro.Location = new System.Drawing.Point(138, 96);
            this.lblIDErro.Name = "lblIDErro";
            this.lblIDErro.Size = new System.Drawing.Size(213, 21);
            this.lblIDErro.TabIndex = 8;
            this.lblIDErro.Text = "UserID Has Existed";
            this.lblIDErro.Visible = false;
            // 
            // lblPwdErro
            // 
            this.lblPwdErro.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lblPwdErro.ForeColor = System.Drawing.Color.Red;
            this.lblPwdErro.Location = new System.Drawing.Point(138, 262);
            this.lblPwdErro.Name = "lblPwdErro";
            this.lblPwdErro.Size = new System.Drawing.Size(213, 21);
            this.lblPwdErro.TabIndex = 9;
            this.lblPwdErro.Text = "Password is Not Matched";
            this.lblPwdErro.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 420);
            this.Controls.Add(this.lblPwdErro);
            this.Controls.Add(this.lblIDErro);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblIDErro;
        private System.Windows.Forms.Label lblPwdErro;
    }
}