using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace DrawImage
{
    class Program
    {
        static void Main(string[] args)
        {
            // DrawImage(5);

            //获取桌面路径
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                CAPTCHA cAPTCHA = new CAPTCHA(280, 100);
                Bitmap bitmap = cAPTCHA.CreateBitmap(5);
                if (bitmap.Width < 0 || bitmap.Height < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                cAPTCHA.AddCurve(10);
                cAPTCHA.AddPixel(600);

                string path = Path.Combine(pathDesktop, "hello.jpg");
                bitmap.Save(path);
                Process.Start(path);
            }
            catch (ArgumentOutOfRangeException e)
            {
                File.AppendAllText(Path.Combine(pathDesktop, "CreateBitmap-log.txt"), $"{DateTime.Now}-  输入超过范围!" + e.ToString() + Environment.NewLine + Environment.NewLine);
                Console.WriteLine($"超出范围");
            }
            catch (MyException e)
            {
                File.AppendAllText(Path.Combine(pathDesktop, @"CreateBitmap-myExp-log.txt"), $"{ DateTime.Now}- 验证码长度输入无效,长度应该大于0! " + e.ToString() + Environment.NewLine + Environment.NewLine);
                Console.WriteLine("不行,你输入验证码超过范围了");
            }
            catch (Exception e)//未知异常
            {
                File.AppendAllText(Path.Combine(pathDesktop, @"Exception-log.txt"), $"{DateTime.Now}------未知异常-------" + e.ToString() + Environment.NewLine + Environment.NewLine);
                Console.WriteLine("发生了未处理异常,请稍后重试!");
            }
        }
    }
}
