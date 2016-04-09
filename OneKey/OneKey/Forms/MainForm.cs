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
    public partial class MainForm : Form
    {
        private Point m_MousePoint;
        private Point m_LastPoint;

        private string password;

        private DataTable typesTable;
        private DataTable pwdsTable;

        public MainForm()
        {
            InitializeComponent();
            loadData();
        }
 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            if (!login.LoginSuccess)
                this.Close();
            else
            {
                this.password = login.Password;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPwdForm addpwd = new AddPwdForm(this);
            int Xoffset = (this.Size.Width - addpwd.Size.Width) / 2;
            int Yoffset = (this.Size.Height - addpwd.Size.Height) / 2;
            addpwd.Location = new Point(this.Location.X + Xoffset, this.Location.Y + Yoffset);
            addpwd.Show();
            this.Enabled = false;
        }

        private void loadData()
        {
            if (typesTable != null && typesTable.Rows.Count > 0)
                typesTable.Clear();
            typesTable = GlobleManager.LoadTypeData();
        }
    }
}
