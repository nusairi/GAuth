﻿using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Payloads.Responses;
using Payloads.Requests;

namespace Api
{
    public class Auth
    {
        private static HttpClient _httpClient = new HttpClient();
 
        public static AuthResponsePayload PostAuth(AuthPayload payload)
        {
            try
            {              
                string requestBody = JsonConvert.SerializeObject(payload);
                using (HttpRequestMessage request = new HttpRequestMessage { RequestUri = new Uri("https://restful-booker.herokuapp.com/auth"), Method = HttpMethod.Post })
                {
                    request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                    var response = _httpClient.SendAsync(request).Result;
                    var responseString = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<AuthResponsePayload>(responseString);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e);
                return null;
            }

        }
    }
}
