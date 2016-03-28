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

        private bool m_isIDok = false;
        private bool m_isPwdok = false;
       
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
            
               
            if (tbPwd.Text == "" || tbConfirm.Text == "")
            {
                lblPwdErro.Text = "Password Empty!";
                lblPwdErro.Visible = true;
                m_isPwdok = false;
            }
            else
            {
                if(m_isIDok && m_isPwdok)
                {
                    GlobleManager.RegisterUser(tbID.Text, tbPwd.Text);
                    this.parentForm.Enabled = true;
                    this.Close();
                }
                
            }
          
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                lblIDErro.Text = "UserID Empty!";
                lblIDErro.Visible = true;
                lblIDErro.ForeColor = Color.Red;
                m_isIDok = false;
            }
            else if(GlobleManager.CheckIDExist(tbID.Text) == true)
            {
                lblIDErro.Text = "UserID has Existed!";
                lblIDErro.Visible = true;
                lblIDErro.ForeColor = Color.Red;
                m_isIDok = false;
            }
            else
            {
                lblIDErro.Visible = false;
                m_isIDok = true;
            }
        }

        private void tbConfirm_TextChanged(object sender, EventArgs e)
        {
            if (tbPwd.Text != tbConfirm.Text)
            {
                lblPwdErro.Text = "Password is Not Matched";
                lblPwdErro.Visible = true;
                lblPwdErro.ForeColor = Color.Red;
            }
            else
            {
                m_isPwdok = true;
                lblPwdErro.Visible = false;
            }
        }
    }
}
