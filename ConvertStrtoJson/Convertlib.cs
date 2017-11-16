using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConvertStrtoJson
{
    public static class Convertlib
    {
        public static string StrtoJson(object cls)
        {
            try
            {
                string json_str = JsonConvert.SerializeObject(cls);

            }
            catch(Exception e)
            {
                throw e;
            }

            return "";
        }



    }
}
