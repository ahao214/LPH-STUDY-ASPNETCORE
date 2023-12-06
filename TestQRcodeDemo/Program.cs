using QRCoder;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Media.Imaging;
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
            // 不带logo图片
            //Bitmap bitmap = qRCode.GetGraphic(15, System.Drawing.Color.Green, System.Drawing.Color.White, true);

            // logo图片
            Bitmap logo = new Bitmap(@"logo.png");
            Bitmap bitmap = qRCode.GetGraphic(15, System.Drawing.Color.Green, System.Drawing.Color.White, logo, 22, 2, true);

            Image image = Image.FromHbitmap(bitmap.GetHbitmap());
            image.Save(@"test.png");

            ReadKey();
        }

    }
}
