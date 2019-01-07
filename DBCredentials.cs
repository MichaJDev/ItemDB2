using Newtonsoft.Json.Linq;
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

            hlr = new Handler();
            this.Hide();
            InitializeComponent();
            setLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hlr.readJLDFromJson().Property("server").Value.ToString() == "")
            {
                JsonLoginData jld = new JsonLoginData(tbServer.Text, tbDB.Text, tbUser.Text, tbPassword.Text);
                hlr.writeToJson(jld);
            }
            else if (tbServer.Text == hlr.readJLDFromJson().Property("server").Value.ToString())
            {
                MessageBox.Show("Login Credentials Updated");
                JsonLoginData jld = new JsonLoginData(hlr.readJLDFromJson().Property("server").Value.ToString(), tbDB.Text, tbUser.Text, tbPassword.Text);
                hlr.writeToJson(jld);
                MessageBox.Show(hlr.readJLDFromJson().Property("server").Value.ToString());
                JObject jo = hlr.readJLDFromJson();
                hlr.setCredentials(jo);
            }
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
        public void onLoad(object sender, EventArgs e)
        {
            MessageBox.Show(hlr.readJLDFromJson().Property("server").Value.ToString());
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

        private void DBCredentials_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (hlr.readJLDFromJson().Property("server").Value.ToString() == "")
                {
                    JsonLoginData jld = new JsonLoginData(tbServer.Text, tbDB.Text, tbUser.Text, tbPassword.Text);
                    hlr.writeToJson(jld);
                }
                else if (tbServer.Text == hlr.readJLDFromJson().Property("server").Value.ToString())
                {
                    MessageBox.Show("Login Credentials Updated");
                    JsonLoginData jld = new JsonLoginData(hlr.readJLDFromJson().Property("server").Value.ToString(), tbDB.Text, tbUser.Text, tbPassword.Text);
                    hlr.writeToJson(jld);
                    MessageBox.Show(hlr.readJLDFromJson().Property("server").Value.ToString());
                    JObject jo = hlr.readJLDFromJson();
                    hlr.setCredentials(jo);
                }
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }
    }
}
