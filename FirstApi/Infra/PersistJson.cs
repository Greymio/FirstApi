using FirstApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FirstApi.Infra
{
    public static class PersistJson
    {
        private static string path = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/Resto.json");
        public static bool SetDatas(List<Resto> datas)
        { 
            if(datas !=null)
            {
                File.WriteAllText(path, JsonConvert.SerializeObject(datas));
                return true;
            }
            return false;
        }


        public static List<Resto> getDatas()
        {
            if (File.Exists(@"~/App_Data/Resto.json"))
            {
                List<Resto> lret = JsonConvert.DeserializeObject<List<Resto>>(File.ReadAllText(path));
                return lret;
            }
            else
            {
                return new  List<Resto>();
            }
        }
    }
}