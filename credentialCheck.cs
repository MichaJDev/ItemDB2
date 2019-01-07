using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemDB2
{
    public partial class credentialCheck : Form
    {
        Handler hlr = new Handler();
        public bool yes = false;
        string path = @"C:\ItemDB\jdl.json";

        public credentialCheck()
        {
            InitializeComponent();
        }

        private void credentialCheck_Load(object sender, EventArgs e)
        {
            lblText.Text = "You already have stored login credentials.\nWant to change them?";
            btnNo.Text = "No";
            btnYes.Text = "Yes";
            if (hlr.JsonExists())
            {
                this.Hide();
                
                
                if (hlr.readJLDFromJson().Property("server").Value.ToString() != "")
                {
                    this.Show();
                }
                else
                {
                    DBCredentials dbc = new DBCredentials();
                }
            }
            else
            {
                hlr.createNewJson();
            }

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DBCredentials dbc = new DBCredentials();
            this.Hide();
            dbc.Show();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DBCredentials dbc = new DBCredentials();
            dbc.Hide();
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        public bool getYes()
        {
            return yes;
        }
    }
}
