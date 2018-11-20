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
    public partial class DelItem : Form
    {
        Handler hlr;
        public DelItem()
        {
            InitializeComponent();
            hlr = new Handler();
            setComboBox();
            this.TopMost = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.Text != "-----------------------------------")
            {
                string text = cbType.Text;
                switch (text)
                {
                    case "One Handed Sword":
                        text = "OneHandedSword";
                        break;
                    case "Two Handed Sword":
                        text = "TwoHandedSword";
                        break;
                }
                dbgrid.DataSource = hlr.getBSource(text);
            }
            else
            {
                dbgrid.DataSource = null;
            }
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

        private void btDel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);
            hlr.del(cbType.Text, id);
            ClearAll();
        }
        private void ClearAll()
        {
            cbType.SelectedIndex = 0;
            tbID.Clear();
        }
    }
}
