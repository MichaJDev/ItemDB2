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
        Form1 form1;
        public DBCredentials()
        {
            InitializeComponent();
            hlr = new Handler();
            form1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log = new Login(tbServer.Text, tbDB.Text, tbUser.Text, tbPassword.Text);
            hlr.setLogin(log);
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
    }
}
