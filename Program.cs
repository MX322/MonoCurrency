using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Data;

namespace MonoCurrency
{
    internal class Program
    {

        static async Task<List<Currency>> GetData()
        {
            string monoAPI = @"https://api.monobank.ua/bank/currency";

            HttpClient client = new HttpClient();

            var data = await client.GetAsync(monoAPI);
            string content = await data.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Currency>>(content);
        }

        static void GetCurrency()
        {
            Console.WriteLine($"Date: {DateTime.Today}");
            foreach (var currency in GetData().Result)
            {
                if (currency.currencyCodeA == 840)
                {
                    Console.WriteLine($"USD\nBuy: {currency.rateBuy}\nSell: {currency.rateSell}\n");
                }
            }

            foreach (var currency in GetData().Result)
            {
                if (currency.currencyCodeA == 978)
                {
                    Console.WriteLine($"EUR\nBuy: {currency.rateBuy}\nSell: {currency.rateSell}");
                }
            }
        }


        static void Main(string[] args)
        {
            GetCurrency();
        }
    }
}
