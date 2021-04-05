using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Qubs.Models;

namespace Qubs.Services
{
    public class CustomHttp
    {
        private readonly HttpClient httpClient;
        private readonly ILogger<CustomHttp> logger;
        private IConfiguration configuration;
        private readonly string BaseUrl;

        public CustomHttp(HttpClient httpClient, ILogger<CustomHttp> logger, IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.configuration = configuration;
            this.logger = logger;

            BaseUrl = this.configuration["BaseUrl"];
        }

        public async Task<T> GetListAsync<T>(string Url)
        {
            try
            {
                logger.LogInformation("REST API GET initiated with URL: " + BaseUrl + Url);

                using var rawResponse = await httpClient.GetAsync(BaseUrl + Url);
                var contentString = await rawResponse.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<T>(contentString);

                return response;
            }
            catch (Exception e)
            {
                logger.LogInformation("REST API GET failed with Url: " + BaseUrl + Url);
                throw new Exception(e.Message);
            }
        }
        
        public async Task<Response<T>> PostAsync<T>(string Url, T model)
        {
            try
            {
                logger.LogInformation("REST API POST object method initiated with URL: " + BaseUrl + Url);

                var data = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                using var rawResponse = await httpClient.PostAsync(BaseUrl + Url, data);
                var contentString = await rawResponse.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<Response<T>>(contentString);

                logger.LogInformation("REST API POST object method Successfull with URL: " + BaseUrl + Url);
                return response;
            }
            catch(Exception e)
            {
                logger.LogInformation("REST API POST object method failed with Url: " + BaseUrl + Url);
                throw new Exception(e.Message);
            }
        }

        public async Task<T> PostAsync<T>(string Url, string model)
        {
            try
            {
                logger.LogInformation("REST API POST object method initiated with URL: " + BaseUrl + Url);

                var data = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                using var rawResponse = await httpClient.PostAsync(BaseUrl + Url, data);
                var contentString = await rawResponse.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<T>(contentString);

                logger.LogInformation("REST API POST object method Successfull with URL: " + BaseUrl + Url);
                return response;
            }
            catch (Exception e)
            {
                logger.LogInformation("REST API POST object method failed with Url: " + BaseUrl + Url);
                throw new Exception(e.Message);
            }
        }

        public async Task<Response<T1>> PostAsync<T1, T2>(string Url, T2 model)
        {
            try
            {
                logger.LogInformation("REST API PUT initiated with URL: " + BaseUrl + Url);

                var data = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                using var rawResponse = await httpClient.PostAsync(BaseUrl + Url, data);
                var contentString = await rawResponse.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<Response<T1>>(contentString);

                logger.LogInformation("REST API PUT Call Successfull with URL: " + BaseUrl + Url);
                return response;
            }
            catch (Exception e)
            {
                logger.LogInformation("REST API PUT failed with Url: " + BaseUrl + Url);
                throw new Exception(e.Message);
            }
        }

        public async Task<Response<T>> PutAsync<T>(string Url, T model)
        {
            try
            {
                logger.LogInformation("REST API PUT initiated with URL: " + BaseUrl + Url);

                var data = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                using var rawResponse = await httpClient.PutAsync(BaseUrl + Url, data);
                var contentString = await rawResponse.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<Response<T>>(contentString);

                logger.LogInformation("REST API PUT Call Successfull with URL: " + BaseUrl + Url);
                return response;
            }
            catch(Exception e)
            {
                logger.LogInformation("REST API PUT failed with Url: " + BaseUrl + Url);
                throw new Exception(e.Message);
            }
        }

        public async Task<Response<T>> DeleteAsync<T>(string Url)
        {
            try
            {
                logger.LogInformation("REST API DELETE initiated with URL: " + BaseUrl + Url);

                using var rawResponse = await httpClient.DeleteAsync(BaseUrl + Url);
                var contentString = await rawResponse.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<Response<T>>(contentString);

                logger.LogInformation("REST API DELETE Call Successfull with URL: " + BaseUrl + Url);
                return response;
            }
            catch (Exception e)
            {
                logger.LogInformation("REST API DELETE failed with Url: " + BaseUrl + Url);
                throw new Exception(e.Message);
            }
        }
    }
}
