

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;


namespace CreateThumbnail
{
    internal class Program
    {
        static void Main()
        {
            string inputValue = string.Empty;
            Console.Write("画像のフォルダパスを入力してください: ");
            string imageFolder = Console.ReadLine();

            Console.Write("列数を入力してください: ");
            inputValue = Console.ReadLine();
            int numCols = inputValue == string.Empty ? 4 : int.Parse(inputValue);

            Console.Write("左右の空白をピクセル単位で入力してください: ");
            inputValue = Console.ReadLine();
            int padding = inputValue == string.Empty ? 10 : int.Parse(inputValue);

            Console.Write("出力ファイルのパスを入力してください: ");
            inputValue = Console.ReadLine();
            string outputFilePath = inputValue == string.Empty ? @"C:\temp\thumbnail.png" : inputValue;

            CreateThumbnail(imageFolder, numCols, padding, outputFilePath);
        }

        static void CreateThumbnail(string imageFolder, int numCols, int padding, string outputFilePath)
        {
            // 画像フォルダ内の画像ファイルを取得
            string[] imageFiles = Directory.GetFiles(imageFolder, "*.jpg");

            // サムネイルの行数を計算
            int numImages = imageFiles.Length;
            int numRows = (numImages + numCols - 1) / numCols;

            // サムネイルの幅と高さを計算
            int thumbnailWidth = 1500 / numCols;
            int thumbnailHeight = 1500 / numRows;

            // 左右の余白を計算
            int totalWidth = thumbnailWidth * numCols + padding * (numCols - 1);
            int leftMargin = (1500 - totalWidth) / 2;

            // サムネイル用のビットマップを作成
            using (Bitmap thumbnail = new Bitmap(totalWidth, 1500))
            using (Graphics g = Graphics.FromImage(thumbnail))
            {
                g.Clear(Color.White);

                // 画像を縮小してサムネイルに追加
                for (int i = 0; i < numImages; i++)
                {
                    using (Image image = Image.FromFile(imageFiles[i]))
                    {
                        Image thumbnailImage = ResizeImage(image, thumbnailWidth, thumbnailHeight);
                        int colIdx = i % numCols;
                        int rowIdx = i / numCols;
                        int x = leftMargin + (thumbnailWidth + padding) * colIdx;
                        int y = thumbnailHeight * rowIdx;
                        g.DrawImage(thumbnailImage, x, y);
                    }
                }

                // サムネイルを保存
                thumbnail.Save(outputFilePath);
            }
        }

        static Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
    }

}