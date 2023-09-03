using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace shuffleImage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var quality = 100;
                Console.Write( $"ShuffleImage Path>>");
                var targetDir = Console.ReadLine();
                Console.Write($"name>>");
                var name = Console.ReadLine();

                var split = targetDir.Split(" ");

                if (split.Length > 1)
                    quality = Convert.ToInt32(split[1]);

                if (targetDir == null)
                    return;
                
                var files = Directory.GetFiles(targetDir).ToArray();

                files = files.OrderBy(i => Guid.NewGuid()).ToArray();

                var destDirName = "reName";
                var restDirPath = Path.Combine(targetDir, destDirName);
                Directory.CreateDirectory(restDirPath);

                int count = 0;
                foreach (string file in files)
                {
                    var destFileName = Path.Combine(restDirPath, $"{name}_{count.ToString("000")}.jpg");

                    Console.WriteLine($"{Path.GetFileName(file)} to {Path.GetFileName(destFileName)}");

                    if (File.Exists(destFileName))
                        continue;
                    count++;

                    Process.Start($"C:\\Program Files\\ImageMagick-7.1.1-Q16-HDRI\\magick.exe\" convert {file} -quality {quality} {destFileName} ");
                }
                Console.WriteLine(targetDir);
                Console.Write("終了<<");

            }
        }
    }
}