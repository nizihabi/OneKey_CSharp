using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneKey.Forms
{
    public partial class AddPwdForm : Form
    {
        private DataTable types;

        public AddPwdForm()
        {
            InitializeComponent();
            loadType();
        }

        private void btnTypeAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void loadType()
        {
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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobleManager.AddPwd(tbPwd.Text, tbDes.Text, cbType.SelectedItem.ToString());
        }
    }
}
