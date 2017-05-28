using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DucklingChatMobile.ApiServices
{
    public class ApiServicesBase
    {
        private HttpClient Client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:58720/")
        };
        
         

    }
}
