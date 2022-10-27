using System.Collections.Generic;

namespace AEDLab_AtividadeAvaliativa
{
    class E23
    {
        private Dictionary<string, string> url = new Dictionary<string,string>();
        public E23()
        {
            url.Add("www.google.com", "172.217.29.36");
            url.Add("www.pucminas.br", "200.229,32,27");
            url.Add("www.gmail.com", "216.58.222.69");
            url.Add("www.youtube.com", "216.58.202.238");
            url.Add("www.capes.gov.br", "200.130.18.222");

            url.Add("www.yahoo.com", "72.30.35.10");
            url.Add("www.microsoft.com", "2.22.80.231");
            url.Add("www.twitter.com", "104.244.42.193");
            url.Add("www.brasil.gov.br", "170.246.252.243");
            url.Add("www.wikipedia.com", "208.80.154.232");

            url.Add("www.amazon.com", "13.33.129.219");
            url.Add("research.microsoft.com", "13.67.218.189");
            url.Add("www.facebook.com", "31.13.74.35");
            url.Add("www.whitehouse.gov", "23.3.229.206");
            url.Add("www.answers.com", "151.101.92.203");

            url.Add("www.uol.com", "200.147.3.199");
            url.Add("www.hotmail.com", "204.79.197.212");
            url.Add("www.cplusplus.com", "167.114.170.15");
            url.Add("www.nyt.com", "151.101.93.164");
            url.Add("www.apple.com", "95.100.45.144");

            url.Add("web.mit.edu", "104.105.138.237");
            url.Add("outlook.live.com", "13.107.42.11");
            url.Add("www.bing.com", "204.79.197.200");
            url.Add("www.puc-rio.br", "139.82.30.201");
            url.Add("www.pucrs.br", "201.54.140.10");
        }

        public string ProcurarSite(string urlParam)
        {
            if (this.url.ContainsKey(urlParam))
                return urlParam + " " + url[urlParam].ToString();
            else
                return "O site especificado não se encontra em nosso dicionário";
        }
    }
}
