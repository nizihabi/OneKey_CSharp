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

        public LoginForm()
        {
            InitializeComponent();
            this.Location =new Point(800,384);
            tbIDFirstFocuse = true;
            tbPasswordFirstFocuse = true;
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


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }

           // return true;
            return base.ProcessCmdKey(ref msg, keyData); 
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

        private void btnLogin_Click(object sender, EventArgs e)
        {

            User.GetInstance().ID = this.tbID.Text;
            User.GetInstance().Password = this.tbPassword.Text;

            if(checkLoginMsg(User.GetInstance().ID,User.GetInstance().Password) == false)
            {
                this.pnlErro.Visible = true;
                this.tbID.Enabled = false;
                this.tbPassword.Enabled = false;
            }


        }

        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        private bool isUserExist(string id)
        {
            return true;
        }

        /// <summary>
        /// 检查登陆信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="pwd">用户密码</param>
        /// <returns></returns>
        private bool checkLoginMsg(string id,string pwd)
        {
            return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.pnlErro.Visible = false;
            this.tbID.Enabled = true;
            this.tbPassword.Enabled = true;
        }

    }
}
