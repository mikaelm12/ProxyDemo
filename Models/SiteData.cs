using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataProxy.Models
{
    public class SiteData
    {
        public Request[] request;
        public int GetRequests { get; set; }
        public int PostRequests { get; set; }
        public int PutRequests { get; set; }
        public int DeleteRequest { get; set; }

        public List<Request> RequestSet { get; set; }
        public Dictionary<String, String> Requestinfo { get; set; }
        public int MyProperty { get; set; }

        public SiteData(Request[] requests)
        {
            this.request = requests;
            GetRequests = requests.Where(r => r.MethodType == "GET").Count();
            PostRequests = requests.Where(r => r.MethodType == "POST").Count();
            DeleteRequest = requests.Where(r => r.MethodType == "DELETE").Count();
            PutRequests = requests.Where(r => r.MethodType == "PUT").Count();
        }


    }
}
