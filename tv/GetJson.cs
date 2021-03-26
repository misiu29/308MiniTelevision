using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace tv
{
    class GetJson
    {
        public static string Get(string Url)
        {
            string resultstring = "";
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);//这里的url指要获取的数据网址
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                resultstring = reader.ReadToEnd();
            }
            return resultstring;

        }
        public static string GetLocal()
        {
            string result;
            using (StreamReader reader = new StreamReader("Data/channels.json", Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
        public static string GetLocal1()
        {
            string result;
            using (StreamReader reader = new StreamReader("Data/collection.json", Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
    }
}
