using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMenuPages
{
    public class RequestDetails
    {
        public void HeaderInformation(out RestClient client, out RestRequest request)
        {

            client = new RestClient(ConfigurationManager.AppSettings["url"]);
            request = new RestRequest(Method.POST);


            //header items
            request.AddHeader("cache-control", ConfigurationManager.AppSettings["cacheValue"]);
            request.AddHeader("x-auth-brandtoken", ConfigurationManager.AppSettings["tokenValue"]);
            request.AddHeader("Accept", ConfigurationManager.AppSettings["acceptValue"]);
            request.AddHeader("Content-Type", ConfigurationManager.AppSettings["contentTypeValue"]);
        }
    }
}
