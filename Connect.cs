using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ItemDB2
{


    class Connect
    {

        //TODO: Dynamic Additation of Tables to the Database on First start.    
        public string server;
        public string database;
        public string uid;
        public string password;
        MySqlConnection connection;
        FileHandler fh = new FileHandler();

        public Connect()
        {
            server = fh.readJLDJson().Property("server").Value.ToString();
            database = fh.readJLDJson().Property("database").Value.ToString(); ;
            uid = fh.readJLDJson().Property("user").Value.ToString(); ;
            password = fh.readJLDJson().Property("password").Value.ToString(); ;
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
            string query;

            query = "INSERT INTO " + item.getType().ToLower() + "(Name,Description,Worth,Stamina,Strength,Intellect,Agility,Haste,Mastery) VALUES('" + item.getName() + "', '" + item.getDesc() + "','" + item.getWorth() + "', " + item.getStam() + ", " + item.getStr() + ", " + item.getIntl() + ", " + item.getAgi() + ", " + item.getHas() + ", " + item.getMas() + ")";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public BindingSource getData(String Text)
        {
            BindingSource dSource = new BindingSource();
            string query = "SELECT * FROM " + Text.ToLower();
            if (OpenConnection())
            {
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = new MySqlCommand(query, connection);
                DataTable tbl = new DataTable();
                mda.Fill(tbl);
                dSource.DataSource = tbl;
                CloseConnection();
            }
            return dSource;
        }


        public bool checkItemTable(String Text)
        {
            bool tableExists = false;
            string query = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = 'test' AND table_name = '" + Text + "'";
            if (OpenConnection())
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
            string query = "CREATE TABLE `" + text + "` (`ID` INT NOT NULL AUTO_INCREMENT,	`Name` VARCHAR(255) CHARACTER SET utf8 COLLATE utf8_general_ci  NOT NULL,	`Description` VARCHAR(255) CHARACTER SET utf8 COLLATE utf8_general_ci,	`Worth` VARCHAR(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,	`Stamina` INT(4),	`Strength` INT(4),	`Intellect` INT(4),	`Agility` INT(4), 	`Haste` INT(4),	`Mastery` INT(4),	PRIMARY KEY(`ID`)); ";
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void deleteRow(String text, int id)
        {
            string query = "DELETE FROM " + text.ToLower() + " WHERE ID = " + id;
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Row with ID: " + id + "\n");
                CloseConnection();
            }
        }
        public List<string> getTables()
        {
            List<string> tables = new List<string>();

            string query = "SHOW TABLES FROM test";
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tables.Add(reader.GetString(0));
                    }
                    reader.Close();
                    CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return tables;
        }
    }
}
