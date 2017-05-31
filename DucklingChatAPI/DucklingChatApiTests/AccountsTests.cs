using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DucklingChatApiTests
{
    [TestClass]
    public class AccountsTests : TestBase
    {
        [TestMethod]
        public async Task GetUsersTest()
        {
            var ret = await Client.GetAsync($"api/accounts/users");
            var content = await ret.Content.ReadAsStringAsync();
            ret.EnsureSuccessStatusCode();
            var response = JsonConvert.DeserializeObject<string>(content);



        }
    }
}
