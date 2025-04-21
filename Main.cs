using System;
using System.Data;
using System.Net.Http;
using System.Threading;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        int[] mass = [1,2,3,4,5];
        int a = 4;
        Solution b = new Solution();
        Console.WriteLine(b.RemoveElement(mass,a));
        
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
