using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDB2
{
    class FileHandler
    {
        Handler hlr;
        public FileHandler()
        {
            hlr = new Handler();
        }
        public void writeToJson(JsonLoginData jld)
        {
            string objjsonData = JsonConvert.SerializeObject(jld);
            string fileType = ""
            System.IO.File.WriteAllText(objjsonData);
        }

    }
}
