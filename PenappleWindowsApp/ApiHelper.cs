using Newtonsoft.Json;
using PenscribCommon.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PenscribCommon.Helpers
{
    public static class ApiHelper
    {
        public static bool IsDebug { get; set; } = true;

        private static string BaseUrl => IsDebug ? @"http://localhost:49612/api/" : @"azureurl";

        private static User user = null;

        /// <summary>
        /// Sets the user with information for making authenticated calls to the api
        /// </summary>
        public static void setUser(User newUser)
        {
            user = newUser;
        }

        /// <summary>
        /// Performs a GET on the specified controller e.g user, message, etc.
        /// </summary>
        public static async Task<HttpResponseMessage> GetAsync(string controller)
        {
            try
            {
                using (var client = BaseClient())
                {
                    return await client.GetAsync(controller);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in GetAsync({controller}):\r\n{ex.Message})");
                return null;
            }
        }

        /// <summary>
        /// Performs a GET on the specified controller e.g user, message, etc. Specify the object expected to be returned
        /// </summary>
        public static async Task<T> GetAsync<T>(string controller)
        {
            try
            {
                using (var client = BaseClient())
                {
                    var response = await client.GetAsync(controller);
                    string json = await response.Content.ReadAsStringAsync();
                    T obj = JsonConvert.DeserializeObject<T>(json);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in GetAsync<{(typeof(T)).Name}>({controller}):\r\n{ex.Message})");
                return default(T);
            }
        }

        /// <summary>
        /// Performs a GET on the specified controller. Specify the object expected to be returned and add query params as
        /// key-value pairs in the form of a request object
        /// </summary>
        public static async Task<T> GetAsync<T>(string controller, object request)
        {
            try
            {
                using (var client = BaseClient())
                {
                    var parameters = String.Join("&", request.GetType().GetRuntimeProperties().Select(x =>
                        $"{x.Name}={x.GetValue(request)}"));
                    var response = await client.GetAsync($"{controller}?{parameters}");
                    string json = await response.Content.ReadAsStringAsync();
                    T obj = JsonConvert.DeserializeObject<T>(json);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in GetAsync<{(typeof(T)).Name}>({controller}):\r\n{ex.Message})");
                return default(T);
            }
        }

        /// <summary>
        /// Performs a POST on the specified controller with a body, body type, and expected return type
        /// </summary>
        public static async Task<TU> PostAsync<T, TU>(string controller, T body)
        {
            try
            {
                using (var client = BaseClient())
                {
                    string str = JsonConvert.SerializeObject(body);
                    var response = await client.PostAsync(controller, new JsonStringContent(body));
                    string json = await response.Content.ReadAsStringAsync();
                    TU obj = JsonConvert.DeserializeObject<TU>(json);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in GetAsync<{(typeof(T)).Name}, {typeof(TU).Name}>({controller}):\r\n{ex.Message})");
                return default(TU);
            }
        }

        /// <summary>
        /// Builds the base url for making api request. Inserts user information into header if the user is set.
        /// </summary>
        private static HttpClient BaseClient()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(BaseUrl)
            };

            if (user != null)
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
                    user.Auth.Provider.ToString(), user.Auth.Token);
                client.DefaultRequestHeaders.From = Uri.EscapeUriString(user.Email);
            }
            return client;
        }

        private class JsonStringContent : StringContent
        {
            /// <summary>
            /// Creates new JsonStringContent, which is just StringContent formatted as application/json.
            /// </summary>
            public JsonStringContent(object obj)
                : base(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")
            {
            }
        }
    }
}
