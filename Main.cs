using System;
using System.Data;
using System.Net.Http;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {

    }

    static void LoadUrl(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string content = client.GetStringAsync(url).Result;
                Console.WriteLine($"URL: {url}\nСодержимое: {content.Substring(0, 100)}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Не удалось загрузить {url}: {ex.Message}");
            }
        }
    }
    
}
