using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace cSharpWeatherApp
{
    internal class HttpMethods
    {
        public string GetString(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) 
            using(Stream stream = response.GetResponseStream())
            using(StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public byte[] GetImage(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            String lsResponse = String.Empty;

            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using(Stream stream = response.GetResponseStream())
            using(BinaryReader reader = new BinaryReader(stream))
            {
                byte[] lnByte = reader.ReadBytes(1 * 1024 * 1024 * 10);
                return lnByte;
            }


        }


    }
}
