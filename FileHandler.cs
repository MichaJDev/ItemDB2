using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ItemDB2
{
    class FileHandler
    {

        string path = @"C:\ItemDB\jdl.json";
        LogHandler lh = new LogHandler();
        public FileHandler()
        {

        }
        public bool JsonExists()
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void createDirectory()
        {
            string root = @"C:\ItemDB\";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
        }
        public void createNewJson()
        {

            if (!File.Exists(path))
            {
                createDirectory();
                JObject loginData = new JObject(
                        new JProperty("server", ""),
                        new JProperty("database", ""),
                        new JProperty("user", ""),
                        new JProperty("password", ""));


                File.WriteAllText(path, loginData.ToString());

                using (StreamWriter file = File.CreateText(path))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {

                    loginData.WriteTo(writer);
                    
                }
            }
        }
        public void createJLDJson(JsonLoginData jld)
        {
            JObject loginData = new JObject(
                    new JProperty("server", jld.getServer()),
                    new JProperty("database", jld.getDB()),
                    new JProperty("user", jld.getUID()),
                    new JProperty("password", jld.getPass()));


            File.WriteAllText("jdl.json", loginData.ToString());

            using (StreamWriter file = File.CreateText(path))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                loginData.WriteTo(writer);
            
            }

        }
        public JObject readJLDJson()
        {
            JObject o3 = new JObject();
            if (File.Exists(path))
            {
                try
                {
                    using (StreamReader file = File.OpenText(path))
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        JObject o2 = (JObject)JToken.ReadFrom(reader);
                        o3 = o2;
                    }
                }
                catch (FileNotFoundException ex)
                {
                    lh.AddLineToLog(ex.ToString());
                }
            }
            return o3;
        }
    }
}