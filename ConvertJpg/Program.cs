using System;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace ConvertJpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                var quality = 100;
                Console.Write("Path>>");
                var targetDir = Console.ReadLine();

                var split = targetDir.Split(" ");

                if(split.Length > 1 )
                    quality = Convert.ToInt32(split[1]);

                if (targetDir == null)
                    return;

                targetDir = split[0];

                Parallel.ForEach(Directory.EnumerateDirectories(targetDir), (dir) =>
                {
                    var sourceDir = new DirectoryInfo(dir);

                    var jpgDir = Path.Combine(dir, $"{sourceDir.Name}_jpg");
                    Directory.CreateDirectory(jpgDir);

                    foreach (string file in Directory.EnumerateFiles(dir))
                    {
                        Console.WriteLine(file);

                        var destFileName = Path.Combine(jpgDir, $"{Path.GetFileNameWithoutExtension(file)}.jpg");

                        if (File.Exists(destFileName))
                            continue;

                        Process.Start($"C:\\Program Files\\ImageMagick-7.1.1-Q16-HDRI\\magick.exe\" convert {file} -quality {quality} {destFileName} ");
                    }
                    Console.WriteLine(dir);
                });
                Console.Write("終了<<");

            }
        }
    }
}