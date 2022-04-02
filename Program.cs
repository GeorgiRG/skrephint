using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace skrephint
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            string msg = await GetHtml();
            Console.WriteLine(msg);
        }

        private static async Task<string> GetHtml()
        {
            
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br"); //needs decoding
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.5");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:98.0) Gecko/20100101 Firefox/98.0");
            client.DefaultRequestHeaders.Add("Referer", "https://www.wikipedia.org/");
            client.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
            

            var stringTask = client.GetStringAsync("https://en.wikipedia.org/wiki/Jack_Dongarra");

            var msg = await stringTask;
            //Console.Write(msg);
            return msg;
        }
    }
}
/*
var cs = "Host=localhost;Username=postgres;Password=6165939597;Database=postgres";

using var con = new NpgsqlConnection(cs);
con.Open();

var sql = "SELECT version()";

using var cmd = new NpgsqlCommand(sql, con);

Console.WriteLine("done till here");
var version = cmd.ExecuteScalar().ToString();
Console.WriteLine($"PostgreSQL version: {version}");

 //Console.WriteLine("Hello World!");
var options = new FirefoxOptions();

using (var driver = new FirefoxDriver("pth", options))
{
    // Go to the home page

    driver.Navigate().GoToUrl("https://www.wikipedia.org/");
    //var userNameField = driver.FindElement(By.Id("usr"));
    string output2 = driver.PageSource;
    Console.WriteLine(output2);
}
*/
