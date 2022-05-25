using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFlyout.Services
{
    public class RestService
    {
        protected HttpClient client;
        protected JsonSerializerOptions serializerOptions;
        protected string uri;

        public RestService()
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task<T> GetReponse<T>(string _apiUrl) where T : class
        {
            try
            {
                var response = await client.GetAsync(_apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    try
                    {

                        var responseObject = JsonSerializer.Deserialize<T>(jsonResult);
                        return responseObject;
                    }
                    catch (Exception e)
                    {
                        string s = e.Message;
                        return null;
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
        }

    }
}
