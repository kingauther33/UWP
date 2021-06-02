using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp1.Models;
using TestApp1.Adapters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;

namespace TestApp1.Services
{
    class MenuService
    {
        private Adapter adapter = Adapter.GetAdapter();

        public async Task<Menu> GetMenu()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://foodgroup.herokuapp.com/api/menu");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContect = await response.Content.ReadAsStringAsync();
                Menu menu = JsonConvert.DeserializeObject<Menu>(stringContect);
                return menu;
            }
            return null;
        }

    }
}
