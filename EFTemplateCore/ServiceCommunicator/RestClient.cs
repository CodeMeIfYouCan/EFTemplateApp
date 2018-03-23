using EFTemplateCore.Logging;
using EFTemplateCore.ServiceLocator;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace EFTemplateCore.ServiceCommunicator
{
    public class RestClient
    {
        string baseUrl = string.Empty;
        public RestClient(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public T Consume<T>(string path)
        {
            return Consume<T>(path, "get", null, null);
        }

        public string Consume(string path)
        {
            return Consume(path, "get", null, null);
        }

        public T Consume<T>(string path, object request)
        {
            return Consume<T>(path, "post", request, null);
        }

        public string Consume(string path, object request)
        {
            return Consume(path, "post", null, null);
        }
        public T Consume<T>(string path, string method, object request)
        {
            string result = Consume(path, method, request, null);
            return JsonConvert.DeserializeObject<T>(result);
        }
        public T Consume<T>(string path, string method, object request, Dictionary<string, string> headerItems)
        {
            string result = Consume(path, method, request, headerItems);
            return JsonConvert.DeserializeObject<T>(result);
        }


        /// <summary>
        /// todo:configure constants to appsettings.json file
        /// compress data???
        /// </summary>
        /// <param name="path"></param>
        /// <param name="method"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public string Consume(string path, string method, object request, Dictionary<string, string> headerItems)
        {
            string response = string.Empty;
            try {
                string content = string.Empty;
                if (request != null) {
                    content = JsonConvert.SerializeObject(request);
                }
                string url = string.Concat(baseUrl, path);
                HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
                req.KeepAlive = false;
                req.Method = method.ToUpper();
                req.Headers.Add("Content-Encoding", "ISO-8859-9");
                if (headerItems != null) {
                    foreach(var item in headerItems) {
                        req.Headers.Add(item.Key, item.Value);
                    }
                }
                req.Accept = "application/json";
                req.AutomaticDecompression = DecompressionMethods.GZip;
                req.Headers[HttpRequestHeader.ContentType] = "application/json;charset=utf-8;language=tr-TR";
                //req.SendChunked = true;
                //req.TransferEncoding = "gzip";
                if (("POST,PUT").Split(',').Contains(method.ToUpper())) {

                    UTF8Encoding encodedData = new UTF8Encoding();
                    byte[] buffer = encodedData.GetBytes(content);
                    req.ContentLength = buffer.Length;
                    Stream PostData = req.GetRequestStream();
                    PostData.Write(buffer, 0, buffer.Length);
                    PostData.Close();
                }
                HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                using (StreamReader loResponseStream = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("ISO-8859-9"))) {
                    response = loResponseStream.ReadToEnd();

                    loResponseStream.Close();
                    resp.Close();
                }
            }
            catch (Exception ex) {
                Services.Create<ILog>().LogFormat("RestClient Error! Path:{0},Method:{1},Exception:{2}", LogLevel.Error, path, method, ex);
                throw;
            }
            return response;
        }
    }
}
