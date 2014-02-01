using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;

namespace GWZohoCRM.Classes
{
    class AccessToCRM
    {
        public static String aToken = null;

        public static bool isNetworkAvialble() {
            return NetworkInterface.GetIsNetworkAvailable();
        }
        public String loginToCRM(string u, string p) {
            String result = null;
            try {
                URLParams url = new URLParams();
                url.setLoginParams("EMAIL_ID=" + HttpUtility.UrlEncode(u) + "&PASSWORD=" + HttpUtility.UrlEncode(p));
                result = accessURL(url.getAccURL() + url.getServiceParam(), url.getLoginParams());
            }
            catch (Exception e) { result = e.StackTrace; }
            return result;
        }

        public String accessURL(String url, String content) {
            String result = null;
            try
            {
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3;
               
                WebRequest webRequest = WebRequest.Create(url);
                if (!content.Equals(""))
                {
                    webRequest.Method = WebRequestMethods.Http.Post;
                    webRequest.ContentType = "application/x-www-form-urlencoded";
                    Byte[] bArr = Encoding.ASCII.GetBytes(content);
                    Stream streamObj = webRequest.GetRequestStream();
                    streamObj.Write(bArr, 0, bArr.Length);
                    streamObj.Close();
                }
                else {
                    webRequest.Method = WebRequestMethods.Http.Get;
                }

                WebResponse response = webRequest.GetResponse();
                StreamReader responseStream = new StreamReader(response.GetResponseStream());
                result = responseStream.ReadToEnd();
            }
            catch (Exception e) { result = e.StackTrace; }

            return result;
        }
    }
}
