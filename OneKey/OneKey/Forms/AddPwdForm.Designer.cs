namespace OneKey
{
    partial class AddPwdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPwdForm));
            this.lblPwd = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDes = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.pnlNewType = new System.Windows.Forms.Panel();
            this.btnNewTypeCancel = new System.Windows.Forms.Button();
            this.btnNewTypeADD = new System.Windows.Forms.Button();
            this.tbNewType = new System.Windows.Forms.TextBox();
            this.pnlNewType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPwd
            // 
            this.lblPwd.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(30, 25);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(105, 30);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "Password:";
            // 
            // tbPwd
            // 
            this.tbPwd.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.tbPwd.Location = new System.Drawing.Point(35, 65);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(340, 27);
            this.tbPwd.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lblDescription.Location = new System.Drawing.Point(30, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(136, 30);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // tbDes
            // 
            this.tbDes.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.tbDes.Location = new System.Drawing.Point(35, 145);
            this.tbDes.Multiline = true;
            this.tbDes.Name = "tbDes";
            this.tbDes.Size = new System.Drawing.Size(340, 146);
            this.tbDes.TabIndex = 3;
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(102, 319);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(239, 28);
            this.cbType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(129, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.BackColor = System.Drawing.Color.Transparent;
            this.btnCanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCanel.BackgroundImage")));
            this.btnCanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanel.FlatAppearance.BorderSize = 0;
            this.btnCanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnCanel.Location = new System.Drawing.Point(130, 440);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(150, 40);
            this.btnCanel.TabIndex = 7;
            this.btnCanel.Text = "Cancel";
            this.btnCanel.UseVisualStyleBackColor = false;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.Transparent;
            this.btnAddType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddType.BackgroundImage")));
            this.btnAddType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddType.FlatAppearance.BorderSize = 0;
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddType.Location = new System.Drawing.Point(347, 319);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(28, 28);
            this.btnAddType.TabIndex = 8;
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.btnTypeAdd_Click);
            // 
            // pnlNewType
            // 
            this.pnlNewType.Controls.Add(this.btnNewTypeCancel);
            this.pnlNewType.Controls.Add(this.btnNewTypeADD);
            this.pnlNewType.Controls.Add(this.tbNewType);
            this.pnlNewType.Location = new System.Drawing.Point(0, 212);
            this.pnlNewType.Name = "pnlNewType";
            this.pnlNewType.Size = new System.Drawing.Size(410, 148);
            this.pnlNewType.TabIndex = 9;
            this.pnlNewType.Visible = false;
            // 
            // btnNewTypeCancel
            // 
            this.btnNewTypeCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypeCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewTypeCancel.BackgroundImage")));
            this.btnNewTypeCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewTypeCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTypeCancel.FlatAppearance.BorderSize = 0;
            this.btnNewTypeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypeCancel.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnNewTypeCancel.Location = new System.Drawing.Point(266, 85);
            this.btnNewTypeCancel.Name = "btnNewTypeCancel";
            this.btnNewTypeCancel.Size = new System.Drawing.Size(75, 29);
            this.btnNewTypeCancel.TabIndex = 2;
            this.btnNewTypeCancel.Text = "Cancel";
            this.btnNewTypeCancel.UseVisualStyleBackColor = false;
            this.btnNewTypeCancel.Click += new System.EventHandler(this.btnNewTypeCancel_Click);
            // 
            // btnNewTypeADD
            // 
            this.btnNewTypeADD.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypeADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewTypeADD.BackgroundImage")));
            this.btnNewTypeADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewTypeADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTypeADD.FlatAppearance.BorderSize = 0;
            this.btnNewTypeADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypeADD.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnNewTypeADD.Location = new System.Drawing.Point(60, 85);
            this.btnNewTypeADD.Name = "btnNewTypeADD";
            this.btnNewTypeADD.Size = new System.Drawing.Size(75, 29);
            this.btnNewTypeADD.TabIndex = 1;
            this.btnNewTypeADD.Text = "ADD";
            this.btnNewTypeADD.UseVisualStyleBackColor = false;
            this.btnNewTypeADD.Click += new System.EventHandler(this.btnNewTypeADD_Click);
            // 
            // tbNewType
            // 
            this.tbNewType.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.tbNewType.Location = new System.Drawing.Point(60, 34);
            this.tbNewType.Name = "tbNewType";
            this.tbNewType.Size = new System.Drawing.Size(281, 27);
            this.tbNewType.TabIndex = 0;
            // 
            // AddPwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(410, 500);
            this.Controls.Add(this.pnlNewType);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbDes);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.lblPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPwdForm";
            this.Text = " ";
            this.pnlNewType.ResumeLayout(false);
            this.pnlNewType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbDes;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Panel pnlNewType;
        private System.Windows.Forms.Button btnNewTypeCancel;
        private System.Windows.Forms.Button btnNewTypeADD;
        private System.Windows.Forms.TextBox tbNewType;
    }
}