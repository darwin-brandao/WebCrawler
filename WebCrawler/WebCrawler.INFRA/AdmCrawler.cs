using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using WebCrawler.MODEL;

namespace WebCrawler.INFRA
{
    public class AdmCrawler
    {

        private Regex rxLinks = new Regex(@"(ht|f)tp(s?\:\/\/)[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?");
        public static List<Pagina> lstPaginas = new List<Pagina>();


        public List<string> GetLinks(string URL)
        {
            List<string> lstLinks = new List<string>();

            HttpWebRequest Request = WebRequest.CreateHttp(URL);
            HttpWebResponse Response = null;

            try
            {
                Response = (HttpWebResponse)Request.GetResponse();
            }
            catch (Exception)
            {
                return new List<string>();
            }

            if (Response != null && Response.StatusCode == HttpStatusCode.OK)
            {
                // Get raw data (html source code)
                Stream ResponseStream = Response.GetResponseStream();
                StreamReader oReader = null;
                string sRawData = "";

                if (String.IsNullOrWhiteSpace(Response.CharacterSet))
                {
                    oReader = new StreamReader(ResponseStream);
                }
                else
                {
                    oReader = new StreamReader(ResponseStream, Encoding.GetEncoding(Response.CharacterSet));
                }

                sRawData = oReader.ReadToEnd();

                // Get Links

                MatchCollection oMC = rxLinks.Matches(sRawData);

                foreach (Match oMatch in oMC)
                {
                    if (!lstLinks.Contains(oMatch.Value))
                    {
                        lstLinks.Add(oMatch.Value);
                    }
                }
                
            }

            lstPaginas.Add(new Pagina(URL, lstLinks));
            
            return lstLinks;
        }

        public void ProcessPages()
        {
            List<Pagina> temp = new List<Pagina>();

            lstPaginas.ForEach(p => temp.Add(p));

            temp.ForEach(p => GetLinks(p.URL));
        }

    }
}
