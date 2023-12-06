using QRCoder;
using System.Drawing;
using static System.Console;

namespace TestQRcodeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "C#生成二维码并添加Logo";
            QRCodeGenerator code = new QRCodeGenerator();
            QRCodeData codeData = code.CreateQrCode("www.xxx.com", QRCodeGenerator.ECCLevel.H);
            QRCode qRCode = new QRCode(codeData);
            Bitmap bitmap = qRCode.GetGraphic(15, System.Drawing.Color.Green, System.Drawing.Color.White, true);

            Image image = Image.FromHbitmap(bitmap.GetHbitmap());
            image.Save(@"test.png");

            ReadKey();
        }

    }
}
