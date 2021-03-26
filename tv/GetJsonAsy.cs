using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace tv
{
    class GetJsonAsy
    {
        public string result;
        public void HttpGet(string Url)
        {
            try
            {
                //回收垃圾
                GC.Collect();

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);

                request.Method = "GET";//这里是POST请求，可以改成GET
                request.Accept = "text/html, application/xhtml+xml, */*";
                request.ContentType = "application/json";
                request.BeginGetResponse(new AsyncCallback(Compleate), request);
            }
            catch
            {
                //Tips(DateTime.Now.ToString("hh:mm:ss") + " 同步连接失败");
            }
        }

        public void Compleate(IAsyncResult asyncResult)
        {
            try
            {
                HttpWebRequest req = (asyncResult.AsyncState as HttpWebRequest);
                HttpWebResponse res = req.EndGetResponse(asyncResult) as HttpWebResponse;
                StreamReader reader = new StreamReader(res.GetResponseStream());
                result= reader.ReadToEnd();
                //Tips(DateTime.Now.ToString("hh:mm:ss") + " 手动同步成功");
            }
            catch
            {
                //Tips(DateTime.Now.ToString("hh:mm:ss") + " 手动同步失败");
            }
        }
    }
}
