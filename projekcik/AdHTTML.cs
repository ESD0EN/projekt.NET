using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace projekcik
{
    class AdHTTML
    {
        public static string ReadHtml(string wwww)
        {
            string www = wwww;
            if (wwww.IndexOf("https://") < 0) 
            {
                www = "https://" + wwww;
            }
            WebRequest request = WebRequest.Create(www);
           
            request.Credentials = CredentialCache.DefaultCredentials;
             
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            
            Stream dataStream = response.GetResponseStream();
                
            StreamReader reader = new StreamReader(dataStream);
           
            string contentstring = reader.ReadToEnd();

          
            reader.Close();
            dataStream.Close();
            response.Close();
          
            return contentstring;
        }
    }
}
