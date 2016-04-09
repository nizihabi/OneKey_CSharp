using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneKey
{
    public partial class AddPwdForm : Form
    {
        private DataTable types;
        private Form parentForm;
       
        public AddPwdForm(Form parent)
        {
            InitializeComponent();
            loadType();
            parentForm = parent;
        }

        private void btnTypeAdd_Click(object sender, EventArgs e)
        {
            this.pnlNewType.Visible = true;
            AllDisable();
        }

        private void loadType()
        {
            if(types != null)
                types.Clear();
            types = GlobleManager.LoadTypeData();
            cbType.Items.Clear();
            for(int i = 0;i <types.Rows.Count ;i++)
            {
                cbType.Items.Add(types.Rows[i]["TypeDes"].ToString());
            }
           
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.parentForm.Enabled = true;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobleManager.AddPwd(tbPwd.Text, tbDes.Text, cbType.SelectedItem.ToString());
            this.parentForm.Enabled = true;
            this.Close();
        }

        private void btnNewTypeADD_Click(object sender, EventArgs e)
        {
            GlobleManager.AddType(tbNewType.Text);
            this.pnlNewType.Visible = false;
            AllEnable();
        }

        private void AllDisable()
        {
            this.tbDes.Enabled = false;
            this.tbPwd.Enabled = false;
            this.cbType.Enabled = false;
            this.btnAdd.Enabled = false;
            this.btnCanel.Enabled = false;

        }

        private void AllEnable()
        {
            this.tbDes.Enabled = true;
            this.tbPwd.Enabled = true;
            this.cbType.Enabled = true;
            this.btnAdd.Enabled = true;
            this.btnCanel.Enabled = true;
            loadType();

        }

        private void btnNewTypeCancel_Click(object sender, EventArgs e)
        {
            this.pnlNewType.Visible = false;
            AllEnable();
        }
    }
}
