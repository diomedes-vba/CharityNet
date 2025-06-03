using CharityNet.Domain.Interfaces;
using CharityNet.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityNet.Infrastructure.Services
{
    public class NonProfitService : INonProfitService
    {
        private readonly string _apiKey;
        public NonProfitService(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<Nonprofit> GetNonprofitAsync(string ein)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"https://partners.every.org/v0.2/nonprofit/{ein}?apiKey={_apiKey}");
                string jsonResponse = await response.Content.ReadAsStringAsync();

                Nonprofit nonprofit = JsonConvert.DeserializeObject<Nonprofit>(jsonResponse);
                return nonprofit;
            }
        }
    }
}
