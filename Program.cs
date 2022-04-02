using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Npgsql;

namespace skrephint
{
    class Program
    {
        static void Main(string[] args)
        {
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
            /*
            var cs = "Host=localhost;Username=postgres;Password=6165939597;Database=postgres";

            using var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT version()";

            using var cmd = new NpgsqlCommand(sql, con);

            Console.WriteLine("done till here");
            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"PostgreSQL version: {version}");
            */
        }
    }
}
