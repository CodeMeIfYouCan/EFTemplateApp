using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace SampleClientApplication
{
    public class RestClient
    {
        string serviceUrl = "";
        public RestClient(string url)
        {
            serviceUrl = url;
        }

        public T Consume<T>(string path)
        {
            return Consume<T>(path, "get", null);
        }

        public string Consume(string path)
        {
            return Consume(path, "get", null);
        }

        public T Consume<T>(string path, object request)
        {
            return Consume<T>(path, "post", request);
        }

        public string Consume(string path, object request)
        {
            return Consume(path, "post", null);
        }
        public T Consume<T>(string path, string method, object request)
        {
            string result = Consume(path, method, request);
            return JsonConvert.DeserializeObject<T>(result);
        }

        public string Consume(string path, string method, object request)
        {
            try
            {
                string contentType = "application/json";
                string content = "";
                if (request != null)
                {
                    content = JsonConvert.SerializeObject(request);
                }

                string url = serviceUrl + path;

                HttpWebRequest req = WebRequest.Create(url) as System.Net.HttpWebRequest;
                req.KeepAlive = false;
                req.Method = method.ToUpper();
                req.ContentType = contentType + "; charset=UTF-8; language=tr-TR";
                req.Headers.Add("Content-Encoding", "ISO-8859-9");
                req.Accept = "application/json";

                if (("POST,PUT").Split(',').Contains(method.ToUpper()))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(content);
                    req.ContentLength = buffer.Length;
                    Stream PostData = req.GetRequestStream();
                    PostData.Write(buffer, 0, buffer.Length);
                    PostData.Close();
                }

                HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                StreamReader loResponseStream = new StreamReader(resp.GetResponseStream(), System.Text.Encoding.GetEncoding("windows-1254"));

                string Response = loResponseStream.ReadToEnd();

                loResponseStream.Close();
                resp.Close();
                return Response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
