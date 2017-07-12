using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling AsyncAccessTheWeb method");
            
            Console.WriteLine("Print statement after async call from main");
            Console.ReadKey();
        }

        async Task<int> AccessTheWebAsync()
        {

            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("http://www.mitul.info");

            DoIndependentTask();

            string urlcontents = await getStringTask;

            return urlcontents.Length;
        }

        private void DoIndependentTask()
        {
            Console.WriteLine("Printed before http call because of async call");
        }
    }
}
