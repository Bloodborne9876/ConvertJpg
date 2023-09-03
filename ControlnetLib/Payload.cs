using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlnetAPI
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AlwaysonScripts
    {
        public Controlnet controlnet { get; set; }
    }

    public class Args
    {
        public List<double> input_image { get; set; }
        public string module { get; set; }
        public string model { get; set; }
    }

    public class Controlnet
    {
        public List<Args> args { get; set; }
    }

    public class PayloadParam
    {
        public string prompt { get; set; }
        public string negative_prompt { get; set; }
        public int batch_size { get; set; } = 1;
        public int steps { get; set; } = 40;
        public double cfg_scale { get; set; } = 7;
        public AlwaysonScripts alwayson_scripts { get; set; }
    }
}
