using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ItemDB2
{


    class Connect
    {
        //TODO: Dynamic Additation of Tables to the Database on First start.    
        string server, database, uid, password;
        MySqlConnection connection;
        public Connect()
        {
            server = "localhost";
            database = "test";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.ToString());

            }
            return false;
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        public void Insert(Item item)
        {
            MessageBox.Show(item.getType().ToLower());
            string query = "INSERT INTO " + item.getType().ToLower() + " + (Name,Desc,Worth,Stamina,Strength,Intellect,Agility,Haste,Mastery) VALUES('" + item.getName() + "', '" + item.getDesc() + "','" + item.getStam() + "','" + item.getStr() + "', '" + item.getIntl() + "', '" + item.getAgi() + "', '" + item.getHas() + "', '" + item.getMas() + "')";
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();

            }
        }

        public void getData(String Text)
        {
            string query = "SELECT * from" + Text;
            if (OpenConnection() == true)
            {
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = new MySqlCommand(query, connection);
                DataTable tbl = new DataTable();
                mda.Fill(tbl);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = tbl;
                ShowDB db = new ShowDB();
                db.dbgrid.DataSource = bSource;
                CloseConnection();
            }
        }

        public bool checkItemTable(String Text)
        {
            bool tableExists = false;
            string query = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = 'test' AND table_name = '" + Text + "'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    if (count == 0)
                    {
                        tableExists = false;
                    }
                    else if (count == 1)
                    {
                        tableExists = true;
                    }
                }
                reader.Close();
                this.CloseConnection();
            }
            return tableExists;
        }
        public void createTable(String text)
        {
            string query = "CREATE TABLE `" + text + "` (`ID` INT NOT NULL AUTO_INCREMENT,	`Name` VARCHAR(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,	`Desc` VARCHAR(255) CHARACTER SET utf8 COLLATE utf8_bin,	`Worth` VARCHAR(255) NOT NULL,	`Stamina` INT(4),	`Strength` INT(4),	`Intellect` INT(4),	`Agility` INT(4), 	`Haste` INT(4),	`Mastery` INT(4),	PRIMARY KEY(`ID`)); ";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}
