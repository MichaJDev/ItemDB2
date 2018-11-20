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
    public partial class ShowDB : Form
    {
        Handler hlr = new Handler();

        public ShowDB()
        {
            InitializeComponent();

        }

        private void ShowDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void setComboBox()
        {
            string[] type = new string[] { "-----------------------------------", "Head", "Shoulders", "Chest", "Waist", "Hands", "Legs", "Boots", "One Handed Sword", "Two Handed Sword", "Shield", "Bow" };
            for (int i = 0; i < type.Length; i++)
            {
                cbType.Items.Add(type[i]);
            }
            cbType.SelectedIndex = 0;
        }
        public void setData(BindingSource bs)
        {
            dbgrid.DataSource = bs;
        }
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.Text != "-----------------------------------")
            {
                dbgrid.DataSource = hlr.getBSource(cbType.Text);
            }
            else
            {
                dbgrid.DataSource = null;
            }
        }

        private void ShowDB_Load(object sender, EventArgs e)
        {
            setComboBox();
        }
    }
}
