using FruugoSdkLib.Contstants;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FruugoSdkLib.Services
{
    class RestHelper
    {
        private readonly string url;

        public RestHelper(string url)
        {
            this.url = url;
        }
        public async Task<string> Get()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ApplicationConstrants.BASE_URL);
           // httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", ApplicationConstrants.TOKEN));
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header
            // httpClient.DefaultRequestHeaders.Add("Content-Type","application/json");

            var response = await httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }


        public async Task<string> Post(string body)
        {
            string resultContent = null;
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(ApplicationConstrants.BASE_URL);
                    //client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", ApplicationConstrants.TOKEN));
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ApplicationConstrants.CONTENT_TYPE));
                    var stringContent = new StringContent(body, UnicodeEncoding.UTF8, "application/json");
                    var result = client.PostAsync(url, stringContent).Result;
                    resultContent = await result.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return resultContent;
        }
       




    }
}
