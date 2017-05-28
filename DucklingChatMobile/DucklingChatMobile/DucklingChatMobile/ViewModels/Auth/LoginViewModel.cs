using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DucklingChatMobile.ViewModels.Auth
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }



        public async Task Login()
        {
            var client = new HttpClient {
                BaseAddress = new Uri("http://localhost:58720/")

            };
            var response = client.PostAsync("oauth/token", new StringContent(JsonConvert.SerializeObject(new
            {
                username = Username,
                password = Password
            }),Encoding.UTF8,"application/json"));


        }





    }
}
