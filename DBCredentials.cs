using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemDB2
{
    public partial class DBCredentials : Form
    {
        Handler hlr;

        public bool logged = false;
        public DBCredentials()
        {
            InitializeComponent();
            hlr = new Handler();
            setLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            JsonLoginData jld = new JsonLoginData(tbServer.Text, tbDB.Text, tbUser.Text, tbPassword.Text);
            hlr.writeToJso(jld);
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '\u25CF';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }
        private void setLabels()
        {
            lblUser.Text = "Username";
            lblPassword.Text = "Password";
            lblDB.Text = "Database";
            lblServer.Text = "Server IP";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
