using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ItemDB2
{
    class FileHandler
    {
        Handler hlr;
        
        public FileHandler()
        {
            hlr = new Handler();
        }
        public void createJson(JsonLoginData jld)
        {
            List<JsonLoginData> _jld = new List<JsonLoginData>();
            _jld.Add(jld);
            string objjsonData = JsonConvert.SerializeObject(_jld.ToArray());
            
            if (!File.Exists(objjsonData))
            {
                try
                {
                    File.Create("LoginData.json", objjsonData);
                }
                catch (System.IO.FileNotFoundException ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }
        public void writeToJson(JsonLoginData jld)
        {
            string objjsonData = JsonConvert.SerializeObject(jld);
            if (File.Exists(objjsonData)){
                File.WriteAllLines("LoginData.json", objjsonData.ToArray());
            };
        }
    }
};