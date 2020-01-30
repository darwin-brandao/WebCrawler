using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler.MODEL
{
    public class Pagina
    {
        public string URL = "";
        public List<string> Links = new List<string>();

        public Pagina(string sURI, List<string> lstLinks)
        {
            URL = sURI;
            Links = lstLinks;
        }

    }
}
