using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System.Drawing;
using System;
using System.Drawing;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string inputFolder = @"C:\イラスト関係\成果\保存\キャラ\VTuber\ラミィ\20230828\20230828_jpg"; // 画像が保存されているフォルダのパスを指定
        string outputFilePath = @"C:\イラスト関係\成果\保存\キャラ\VTuber\ラミィ\20230828\ラミィいろんなコス.pdf"; // 出力するPDFのファイルパスを指定

        CreatePdfFromImages(inputFolder, outputFilePath);

        Console.WriteLine("PDFが作成されました。");
    }

    static void CreatePdfFromImages(string inputFolder, string outputFilePath)
    {
        string[] jpgFiles = Directory.GetFiles(inputFolder, "*.jpg");

        using (PdfDocument document = new PdfDocument())
        {
            foreach (string jpgFile in jpgFiles)
            {
                using (Image image = Image.FromFile(jpgFile))
                {
                    double imageWidth = image.Width;
                    double imageHeight = image.Height;

                    PdfPage page = document.AddPage();
                    page.Width = XUnit.FromPoint(imageWidth);
                    page.Height = XUnit.FromPoint(imageHeight);

                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XImage xImage = XImage.FromFile(jpgFile);

                    gfx.DrawImage(xImage, 0, 0, page.Width, page.Height);
                }
            }

            document.Save(outputFilePath);
        }
    }
}
