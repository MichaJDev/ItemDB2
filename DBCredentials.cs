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
        Login log;
        Handler hlr;

        public bool logged = false;
        public DBCredentials()
        {
            InitializeComponent();
            hlr = new Handler();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log = new Login(tbServer.Text, tbDB.Text, tbUser.Text, tbPassword.Text);
            hlr.setLogin(log);
            this.Hide();
            logged = true;
            Form1 form = new Form1();
            form.Show();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '\u25CF';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }
        public bool isLogged()
        {
            return logged;
        }
    }
}
