using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using System.Security.Cryptography;
using RestSharp;
using System.IO;

namespace fm8910
{
    public static class Http
    {
       

        public static string Post(string url, string param)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "http://music.163.com");
            request.AddParameter("s", param);
            request.AddParameter("type", "1");
            request.AddParameter("offset", "0");
            request.AddParameter("limit", "30");
            request.AddParameter("total", "true");

            var response = client.Execute(request);
            // var tipo=  response.ContentType;
            var content = response.Content;
            return content;
        }
        public static string DetalleCancion(string url){
            string content="";
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Referer", "http://music.163.com");

            var response = client.Execute(request);

            content = response.Content;
            // var tipo=  response.ContentType;
            

            return content;
        }
        public static string encriptar(string dfsId)
        {
            //var byte1 = GetBytes("3go8&$8*3*3h0k(2)2");
            //var byte2 = GetBytes(dfsId);
            var str1 = "3go8&$8*3*3h0k(2)2";
            var str2 = dfsId;
            var bs = new byte[str2.Length];
            int len = str1.Length;
            for (int i = 0; i < str2.Length; i++)
            {
                bs[i] = (byte)(str2[i] ^ str1[i % len]);
            }

            var resultado = MD5Hash(bs).Replace("/","_");            
            return resultado.Replace('+', '-');
        }

        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        public static string MD5Hash(byte[] fn)
        {
            byte[] hash = MD5.Create().ComputeHash(fn);
         return  Convert.ToBase64String(hash);
        }
     
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        public static long FromHttp(string uri, string filename, string localFolder)
        {
            long totalBytesRead = 0;
            const int blockSize = 4096;
            Byte[] buffer = new Byte[blockSize];

            if (!Directory.Exists(localFolder))
            {
                Directory.CreateDirectory(localFolder);
            }

            try
            {
                HttpWebRequest httpRequest =
          (HttpWebRequest)WebRequest.Create(Path.Combine(uri, filename));
                httpRequest.Method = "GET";
                // if the URI doesn't exist, an exception will be thrown here...
                using (HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse())
                {
                    using (Stream responseStream = httpResponse.GetResponseStream())
                    {
                        using (FileStream localFileStream =
           new FileStream(Path.Combine(localFolder, filename), FileMode.Create))
                        {
                            int bytesRead;                            
                            while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                totalBytesRead += bytesRead;
                                localFileStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // You might want to handle some specific errors : Just pass on up for now...
                throw;
            }

            return totalBytesRead;
        }
       
    }
}
