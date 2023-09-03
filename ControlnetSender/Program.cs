using RestSharp;
using RestSharp.Authenticators;
using System.Threading;

namespace ControlnetSender
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var options = new RestClientOptions("http://127.0.0.1:7860/controlnet/module_list")
            {
                MaxTimeout = 1000
            };

            var tokenSource = new CancellationTokenSource();
            var client = new RestClient(options);
            var request = new RestRequest();
            request.Method = Method.Get;
            // The cancellation token comes from the caller. You can still make a call without it.
            var response = await client.GetAsync(request , tokenSource.Token);// request, cancellationToken);

            Console.WriteLine($">>{response.Content}");

            Console.ReadLine();
        }


    }
}