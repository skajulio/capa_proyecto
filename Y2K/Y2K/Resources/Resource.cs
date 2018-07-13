using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Y2K.Models;

namespace Y2K.Resources
{
    public static class Resource
    {
        /// <summary>
        /// Carga las ciudades a la BD
        /// </summary>
        public static void GetCity()
        {
            using (Y2kContext context = new Y2kContext())
            {
                if (!context.City.Any())
                {
                    //string content = Task.Run(GetDate).Result;
                    //List<City> cities = JsonConvert.DeserializeObject<List<City>>(content);
                    //context.City.AddRange(cities);
                    //context.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Obtine las ciudades de la Web API
        /// </summary>
        /// <returns>Task<string></returns>
        private static async Task<string> GetDate()
        {
            string url = "http://middleware-neoris.s3-website-us-west-1.amazonaws.com";

            HttpClient Client = new HttpClient();

            string content = await Client.GetStringAsync(url);

            return content;
        }
    }
}