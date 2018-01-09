using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CrmTraceReader
{
    public partial class ConnectionStringForm : Form
    {
        public ConnectionStringForm()
        {
            InitializeComponent();
        }

        public ConnectionStringForm(string connectionString)
        {
            InitializeComponent();

            if(connectionString != null)
                txtConnectionString.Text = connectionString;
        }

        public string ConnectionString { get; private set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ConnectionString = txtConnectionString.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://msdn.microsoft.com/en-us/library/gg695810.aspx");
        }

        private void txtConnectionString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Return && txtConnectionString.Text.Length > 0)
            {
                btnOK_Click(null, null);
            }
        }

        private void ConnectionStringForm_Load(object sender, EventArgs e)
        {
           ActiveControl =  txtConnectionString;
        }
    }
}
