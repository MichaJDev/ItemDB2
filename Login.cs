namespace ItemDB2
{
    class Login
    {
        string server, database, username, password;
        public Login(string server, string database, string username, string password)
        {
            this.server = server;
            this.database = database;
            this.username = username;
            this.password = password;
        }

        public string getServer()
        {
            return server;
        }

        public string getDataBase()
        {
            return database;
        }
        public string getUserName()
        {
            return username;
        }

        public string getPassWord()
        {
            return password;
        }
    }
}