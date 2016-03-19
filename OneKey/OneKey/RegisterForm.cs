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
    }
}
