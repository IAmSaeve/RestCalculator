using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestCalculatorConsumer.Models;
using Newtonsoft.Json;
using System.Text;

namespace RestCalculatorConsumer
{
    class Program
    {
        private static readonly string CalculatorUri = "http://localhost:5000/api/Calculator/";

        static void Main(string[] args)
        {
            System.Console.WriteLine(AsyncAdd(new Data(10, 20), "div").Result);
        }

        public static async Task<string> AsyncAdd(Data data, string type)
        {
            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine("Data " + data);
                var jsonString = JsonConvert.SerializeObject(data);
                Console.WriteLine("json string: " + jsonString);
                StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                Console.WriteLine("content: : " + content.ToString());
                Console.WriteLine("CalculatorUri: " + CalculatorUri);
                HttpResponseMessage response = await client.PostAsync(CalculatorUri + type, content);
                string str = await response.Content.ReadAsStringAsync();
                //Int32 sumStr = JsonConvert.DeserializeObject<Int32>(str);
                return str;
            }
        }
    }
}
