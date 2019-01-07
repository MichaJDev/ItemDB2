using Newtonsoft.Json.Linq;
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
        public List<string> getTables()
        {
            return con.getTables();
        }
        public void setCredentials(JObject jld)
        {
            //con.setCredentials(jld);
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

        public void writeToJson(JsonLoginData jld)
        {
            FileHandler fh = new FileHandler();
            fh.createJLDJson(jld);

        }

        public JObject readJLDFromJson()
        {
            FileHandler fh = new FileHandler();


            return fh.readJLDJson();
        }
        public BindingSource getBSource(String text)
        {
            return con.getData(text);
        }

        public void del(String text, int id)
        {
            con.deleteRow(text, id);
        }
        public void createNewJson()
        {
            FileHandler fh = new FileHandler();
            fh.createNewJson();
        }
        public bool JsonExists()
        {
            FileHandler fh = new FileHandler();

            return fh.JsonExists();
        }
    }
}



