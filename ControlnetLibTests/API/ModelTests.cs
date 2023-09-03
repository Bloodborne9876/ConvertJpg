using ControlnetAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlnetLib.API.Tests
{
    [TestClass()]
    public class ModelTests
    {
        [TestMethod()]
        public async Task FetchTest()
        {
            
            var value = await ControlnetLib.Module.Fetch("http://127.0.0.1:7860/");
        }
        [TestMethod()]
        public async Task ModelTest()
        {

            var value = await ControlnetLib.Model.Fetch("http://127.0.0.1:7860/");
        }

        [TestMethod()]
        public async Task Run()
        {
            var byteData = ImageToByteArray(Image.FromFile(@"C:\temp\sd\1.4.1\stable-diffusion-webui\tmp\DepthNSFWAnimePoses_v40\Depth\10.png"));

            var url = "http://127.0.0.1:7860/";
            var models = await Model.Fetch(url);
            var modules = await Module.Fetch(url);


            var model = models.First(x => x.Contains("depth"));
            var module = modules.module_list.First(x => x.Contains("depth"));

            ControlnetAPI.PayloadParam
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }

        }


    }
}