using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneKey
{
    public partial class RegisterForm : Form
    {
        Form parentForm;

        public RegisterForm(Form Parent)
        {
            InitializeComponent();
            parentForm = Parent;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.parentForm.Enabled = true;
            this.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                lblIDErro.Text = "UserID cannot be empty!";
                lblIDErro.Visible = true;
                return;
            }
               
            if (tbPwd.Text == "" || tbConfirm.Text == "")
            {
                lblPwdErro.Text = "Password cannot be empty!";
                lblPwdErro.Visible = true;
                return;
            }
                
            if(GlobleManager.CheckIDExist(tbID.Text))
            {
                lblIDErro.Text = "UserID Has Existed";
                lblIDErro.Visible = true;
                return;
            }

            if(tbPwd.Text != tbConfirm.Text )
            {
                lblPwdErro.Text = "Password cannot be empty!";
                lblPwdErro.Visible = true;
                return;
            }

            GlobleManager.RegisterUser(tbID.Text, tbPwd.Text);
        }
    }
}
