﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemDB2
{

    class Handler
    {
        Connect con;
        public Handler()
        {
            con = new Connect();
        }

        public void Add(Item item)
        {
            con.Insert(item);
        }
        public void checkTables()
        {
            string[] type = new string[] { "Head", "Shoulders", "Chest", "Waist", "Hands", "Legs", "Boots", "One Handed Sword", "Two Handed Sword", "Shield", "Bow" };
            for (int i = 0; i < type.Length; i++)
            {
                if (!(con.checkItemTable(type[i])))
                {
                    con.createTable(type[i]);
                    MessageBox.Show("Created: " + type[i] + " table");
                }
            }
        }

        public void AddJson()
        {
            //Add Stuff For JSON Additation
        }
    }
}


