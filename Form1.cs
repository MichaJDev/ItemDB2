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
    public partial class Form1 : Form
    {

        AddItem aItem;
        DelItem dItem;
        ShowDB sDB;
        Connect db;
        Handler hlr;
        DBCredentials dbc;
        public Form1()
        {

            InitializeComponent();
            dbc = new DBCredentials();
            aItem = new AddItem();
            db = new Connect();
            dItem = new DelItem();
            sDB = new ShowDB();
            hlr = new Handler();
            if ((bool)Properties.Settings.Default["FirstRun"] == true)
            {
                Properties.Settings.Default["FirstRun"] = false;

                MessageBox.Show("Welcome!\n " +
               "\n" +
               "This is ItemDB v2" +
               "\n" +
               "This project was created by Micha Janssen");
                hlr.checkTables();
            }
        }

        private void btAddItem_Click(object sender, EventArgs e)
        {
            showForm(btAddItem.Text);
        }

        private void btDelItem_Click(object sender, EventArgs e)
        {
            showForm(btDelItem.Text);
        }

        private void btShowDB_Click(object sender, EventArgs e)
        {
            showForm(btnShowDB.Text);
        }

        void showForm(string option)
        {
            switch (option)
            {
                case "Add Item":
                    aItem.Show();
                    break;
                case "Delete Item":
                    dItem.Show();
                    break;
                case "Database":
                    sDB.Show();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string info = "Made by: Micha Janssen\n" +
                "\n" +
                "Version: 2.0\n" +
                "\n" +
                "Collaboration with: Fontys\n" +
                "Creation Date: 1 November 2018";
            MessageBox.Show(info);
        }
        public void Box(String text)
        {
            MessageBox.Show(text);
        }
    }
}
