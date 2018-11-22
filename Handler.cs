using System;
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
            string[] type = new string[] { "Head", "Shoulders", "Chest", "Waist", "Hands", "Legs", "Boots", "OneHandedSword", "TwoHandedSword", "Shield", "Bow" };
            for (int i = 0; i < type.Length; i++)
            {
                if (!(con.checkItemTable(type[i])))
                {
                    con.createTable(type[i]);
                    MessageBox.Show("Created: " + type[i] + " table");
                }
            }
        }

        internal void setLogin(JsonLoginData log)
        {
            FileHandler fh = new FileHandler();
            fh.writeToJson(log);
    
        }
        public BindingSource getBSource(String text)
        {
            return con.getData(text);
        }
        
        public void del(String text, int id)
        {
            con.deleteRow(text, id);
        }
        
    }
}



