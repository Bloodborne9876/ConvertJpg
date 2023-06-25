using System;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace ConvertJpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(">>");
            var targetDir = Console.ReadLine();

            if (targetDir == null)
                return;
            
            Parallel.ForEach(Directory.EnumerateDirectories(targetDir), (dir) => 
            { 
                var sourceDir = new DirectoryInfo(dir);

                var jpgDir = Path.Combine(dir, $"{sourceDir.Name}_jpg");
                Directory.CreateDirectory(jpgDir);

                foreach (string file in Directory.EnumerateFiles(dir))
                {
                    Console.WriteLine(file);

                    var destFileName = Path.Combine(jpgDir, $"{Path.GetFileNameWithoutExtension(file)}.jpg");

                        Process.Start($"C:\\Program Files\\ImageMagick-7.1.1-Q16-HDRI\\magick.exe\" convert {file} {destFileName}");
                }
                Console.WriteLine(dir);
            });
        }
    }
}