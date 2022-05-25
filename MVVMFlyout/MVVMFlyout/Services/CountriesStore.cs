using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MVVMFlyout.Models;

namespace MVVMFlyout.Services
{
    public class CountriesStore: RestService, IDataStore<Country>
    {
        private List<Country> countries;
        public CountriesStore(): base()
        {
            countries = new List<Country>();
            uri = Constants.CountryUrl;
        }

        public async Task<List<Country>> LoadCountries(string path)
        {
            countries = await base.GetReponse<List<Country>>(path);
            return countries;
        }


        public async Task<Country> GetItemAsync(string id)
        {
            return await Task.FromResult(countries.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Country>> GetItemsAsync(bool forceRefresh = false)
        {
            countries = await base.GetReponse<List<Country>>(uri);
            return await Task.FromResult(countries);
        }
    }
}
