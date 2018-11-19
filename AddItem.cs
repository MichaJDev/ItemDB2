﻿using System;
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
    public partial class AddItem : Form
    {
        Handler hlr;
        public AddItem()
        {
            InitializeComponent();
            hlr = new Handler();
            setEvent();
        }

        private void AddItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            setInfo();
            //checkBoxChecker();
        }
        public void setInfo()
        {
            lblName.Text = "Name";
            lblDesc.Text = "Description";
            lblType.Text = "Item Type";
            lblWorth.Text = "Item Quality";
            cbStam.Text = "Stamina";
            cbStr.Text = "Strength";
            cbAgi.Text = "Agility";
            cbInt.Text = "Intellect";
            cbHas.Text = "Haste";
            cbMas.Text = "Mastery";
            string[] type = new string[] { "-----------------------------------", "Head", "Shoulders", "Chest", "Waist", "Hands", "Legs", "Boots", "One Handed Sword", "Two Handed Sword", "Shield", "Bow" };
            for (int i = 0; i < type.Length; i++)
            {
                cbType.Items.Add(type[i]);
            }
            string[] worth = new string[] { "-----------------------------------", "Poor", "Common", "UnCommon", "Rare", "Epic", "Legendary", "Artifact", "Heirloom" };
            for (int i = 0; i < worth.Length; i++)
            {
                cbWorth.Items.Add(worth[i]);
            }
            cbWorth.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
        }

        public void setEvent()
        {
            foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
            {
                cb.CheckedChanged += new EventHandler(updateChecked);
            }
        }

        public void updateChecked(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
            {
                if (c.Name == cb.Name)
                {
                    foreach (TextBox tb in this.Controls.OfType<TextBox>())
                    {
                        if (cb.Name.Remove(0, 2) == (tb.Name.Remove(0, 2)))
                        {
                            if (c.Checked)
                            {
                                tb.ReadOnly = false;
                                tb.BackColor = Color.White;
                            }
                            else
                            {
                                tb.ReadOnly = true;
                                tb.BackColor = Color.Gray;
                            }
                        }
                    }
                }
            }
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbType.Text);
            if (cbType.SelectedIndex != 0 && cbWorth.SelectedIndex != 0 && tbName.Text != "")
            {
                Item item = new Item(tbName.Text, tbDesc.Text, cbType.Text, cbWorth.Text, checkTBStats(tbStam), checkTBStats(tbStr), checkTBStats(tbInt), checkTBStats(tbAgi), checkTBStats(tbHas), checkTBStats(tbMas));
                hlr.Add(item);
                MessageBox.Show("Item Added!\n Name: " + item.getName() + "\nDesc: " + item.getDesc()
                    + "\nType: " + item.getType() + "\nWorth: " + item.getWorth() + "\nStamina: " + item.getStam()
                    + "\nStength: " + item.getStr() + "\nIntellect: " + item.getIntl()
                    + "\nAgility: " + item.getAgi() + "\nHaste: " + item.getHas() + "\nMastery: " + item.getMas());
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please select a Worth or Type selection: \nType:     " + cbType.Text + "\nWorth: " + cbWorth.Text);
            }
        }
        private int checkTBStats(TextBox tb)
        {
            if (tb.Text == "")
            {
                return 0;
            }
            return Convert.ToInt32(tb.Text);
        }
        public void ClearAll()
        {
            tbStam.Clear();
            tbStr.Clear();
            tbInt.Clear();
            tbAgi.Clear();
            tbHas.Clear();
            tbMas.Clear();
            tbName.Clear();
            tbDesc.Clear();
            cbType.SelectedIndex = 0;
            cbWorth.SelectedIndex = 0;
            cbStam.Checked = false;
            cbStr.Checked = false;
            cbInt.Checked = false;
            cbAgi.Checked = false;
            cbHas.Checked = false;
            cbMas.Checked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

    }


}
