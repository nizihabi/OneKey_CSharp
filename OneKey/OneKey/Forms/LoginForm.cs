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
    public partial class LoginForm : Form
    {
        bool tbIDFirstFocuse; 
        bool tbPasswordFirstFocuse;

        private Point m_MousePoint;
        private Point m_LastPoint;

        private RegisterForm m_Register; //注册窗口

        bool loginSuccess;
        /// <summary>
        /// 是否登陆成功
        /// </summary>
        public bool LoginSunccess
        {
            get { return loginSuccess; }
        }

        string password;
        /// <summary>
        /// 登陆密码
        /// </summary>
        public string Password
        {
            get { return password; }
        }

        public LoginForm()
        {
            InitializeComponent();
            GlobleManager.InitDatabase();
            this.Location =new Point(800,384);
            tbIDFirstFocuse = true;
            tbPasswordFirstFocuse = true;
            loginSuccess = false;
            password = "";
        }

       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }

            // return true;
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.m_LastPoint = this.Location;
            this.m_MousePoint = this.PointToScreen(e.Location);
        }


        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                Point t = this.PointToScreen(e.Location);
                Point l = this.m_LastPoint;

                l.Offset(t.X - this.m_MousePoint.X, t.Y - this.m_MousePoint.Y);
                this.Location = l;
            }
        }


        private void tbID_Enter(object sender, EventArgs e)
        {
            this.tbID.ForeColor = Color.Black;
            if (tbIDFirstFocuse)
            {
                this.tbID.Text = "";
                tbIDFirstFocuse = false;
            }
                
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            this.tbPassword.ForeColor = Color.Black;
            this.tbPassword.UseSystemPasswordChar = true;
            if (tbPasswordFirstFocuse)
            {
                this.tbPassword.Text = "";
                tbPasswordFirstFocuse = false;

            }
                
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (GlobleManager.CheckLogin(this.tbID.Text, this.tbPassword.Text) == false)
            {
                this.pnlErro.Visible = true;
                this.tbID.Enabled = false;
                this.tbPassword.Enabled = false;
            }
            else
            {
                this.loginSuccess = true;
                this.password = this.tbPassword.Text;
                this.Close();
            }
            //label2.Text = tbPassword.Text;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            this.pnlErro.Visible = false;
            this.tbID.Enabled = true;
            this.tbPassword.Enabled = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            m_Register = new RegisterForm(this);
            int Xoffset = (this.Size.Width - m_Register.Size.Width) / 2;
            int Yoffset = (this.Size.Height - m_Register.Size.Height) / 2;
            m_Register.Location = new Point(this.Location.X + Xoffset, this.Location.Y + Yoffset);
            m_Register.Show();
            this.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
