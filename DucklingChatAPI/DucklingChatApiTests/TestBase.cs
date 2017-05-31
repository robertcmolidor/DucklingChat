using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DucklingChatAPI;
using DucklingChatAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Microsoft.Owin.Hosting;

namespace DucklingChatApiTests
{
    [TestClass]
    public class TestBase
    {
        public static async Task<string> LoginAndSetJwt()
        {
            var loginRequest = new UserLoginModel
            {
                Username = DucklingChatAPI.Services.EncodingHelper.EncodeTo64("robertcmolidor@gmail.com"),
                Password = DucklingChatAPI.Services.EncodingHelper.EncodeTo64("momoshit6")
            };

            var response = await Client.PostAsync("api/accounts/login", new StringContent(JsonConvert.SerializeObject(loginRequest), Encoding.UTF8, "application/json"));

            if (!response.IsSuccessStatusCode) return null;

            var content = await response.Content.ReadAsStringAsync();
            var jwt = JsonConvert.DeserializeObject<string>(content);

            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

            return jwt;
        }

        public static readonly string BaseAddress = "http://" + Environment.MachineName + ":9995/";

        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
           

            lock (context)
            {

            }
            
            WebApp.Start<Startup>(url: BaseAddress);

            Client = new HttpClient { BaseAddress = new Uri(BaseAddress) };

            LoginAndSetJwt().Wait();
        }

        public static class NonParallelLock
        {
            public static object LockObject = new object();
        }

        public static HttpClient Client;
    }
}
