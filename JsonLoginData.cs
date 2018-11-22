using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDB2
{
    class JsonLoginData
    {
        string server, db, uid, pass;
        public JsonLoginData(string server,string db,string uid, string pass)
        {
            this.server = server;
            this.db = db;
            this.uid = uid;
            this.pass = pass;
        }
        public String getServer()
        {
            return server;
        }

        public String getDB()
        {
            return db;
        }

        public String getUID()
        {
            return uid;
        }

        public String getPass()
        {
            return pass;
        }

    }
}
