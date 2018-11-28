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
        Handler hlr;

        public FileHandler()
        {
            hlr = new Handler();
        }
        public void createJLDJson(JsonLoginData jld)
        {
            JObject loginData = new JObject(
                    new JProperty("server", jld.getServer()),
                    new JProperty("database", jld.getDB()),
                    new JProperty("user", jld.getUID()),
                    new JProperty("password", jld.getPass()));


            File.WriteAllText("jdl.json", loginData.ToString());

            using (StreamWriter file = File.CreateText("jdl.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                loginData.WriteTo(writer);
                MessageBox.Show(file.ToString());
            }
            
        }
        public JObject readJLDJson()
        {
            try
            {
                JObject o3 = new JObject();
                using (StreamReader file = File.OpenText("jld.json"))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o2 = (JObject)JToken.ReadFrom(reader);
                    o3 = o2;
                }
            }catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return o3;
        }
    }
};