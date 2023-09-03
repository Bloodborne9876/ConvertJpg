using ControlnetAPI;
using RestSharp;
using System;
using System.Buffers.Text;
using System.Reflection;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ControlnetLib
{
    public class Module
    {
        public static async Task<Modules> Fetch(string url)
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
            var response = await client.GetAsync(request, tokenSource.Token);// request, cancellationToken);

            if (response.Content == null)
                return null;

            var modules = Newtonsoft.Json.JsonConvert.DeserializeObject<Modules>(response.Content.ToString());

            if(modules == null)
                throw new NullReferenceException(nameof(modules));

            Console.WriteLine($">>{response.Content}");

            return modules;
        }
    }

    public static class Model
    {

        public static async Task<IEnumerable<string>> Fetch(string url)
        {
            var options = new RestClientOptions("http://127.0.0.1:7860/controlnet/model_list")
            {
                MaxTimeout = 1000
            };

            var tokenSource = new CancellationTokenSource();
            var client = new RestClient(options);
            var request = new RestRequest();
            request.Method = Method.Get;
            // The cancellation token comes from the caller. You can still make a call without it.
            var response = await client.GetAsync(request, tokenSource.Token);// request, cancellationToken);

            if (response.Content == null)
                return null;

            var models = Newtonsoft.Json.JsonConvert.DeserializeObject<Models>(response.Content);

            if (models == null)
                throw new NullReferenceException(nameof(models));

            Console.WriteLine($">>{response.Content}");

            return models.model_list;
        }
    }

    public static class Peyload
    {
        public static async Task Post(string model , string module , PayloadParam payload)
        {

            var options = new RestClientOptions("http://127.0.0.1:7860/sdapi/v1/txt2img")
            {
                MaxTimeout = 1000
            };


            var tokenSource = new CancellationTokenSource();
            var client = new RestClient(options);

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(payload);

            var request = new RestRequest().AddJsonBody(payload);
            request.Method = Method.Get;
            // The cancellation token comes from the caller. You can still make a call without it.
            var response = await client.GetAsync(request, tokenSource.Token);// request, cancellationToken);

            //r = response.json()
            //result = r['images'][0]
            //image = Image.open(io.BytesIO(base64.b64decode(result.split(",", 1)[0])))
            //image.save('output.png')


        }
    }
}