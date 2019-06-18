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
            //获取桌面路径
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            try
            {
                CAPTCHA cAPTCHA = new CAPTCHA(300, 100);
                Bitmap bitmap = cAPTCHA.CreateBitmap(5,out string strCode);
                if (bitmap.Width > 500 || bitmap.Height > 500)
                {
                    throw new ArgumentOutOfRangeException("异常信息", new Exception("包裹异常信息"));
                }
                cAPTCHA.AddCurve(15);
                cAPTCHA.AddPixel(600);

                string path = Path.Combine(pathDesktop, "hello.jpg");
                bitmap.Save(path);
                Console.WriteLine($"当前验证码是:{strCode}");
                Process.Start(path);
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException e)
            {
                File.AppendAllText(Path.Combine(pathDesktop, "CreateBitmap-log.txt"), $"{DateTime.Now}-  输入超过范围!" + e.ToString() + Environment.NewLine + Environment.NewLine);
                Console.WriteLine($"超出范围");
            }
            catch (MyException e)
            {
                File.AppendAllText(Path.Combine(pathDesktop, @"CreateBitmap-myExp-log.txt"), $"{ DateTime.Now}- 验证码长度输入无效,长度应该大于0! " + e.ToString() + Environment.NewLine + Environment.NewLine);
                Console.WriteLine("不行,你输入验证码长度不在范围");
            }
            catch (ArgumentException e)
            {
                File.AppendAllText(Path.Combine(pathDesktop, @"CreateBitmap-log.txt"), $"{DateTime.Now}------参数无效-------" + e.ToString() + Environment.NewLine + Environment.NewLine);
                Console.WriteLine("参数无效!");
            }
            catch (Exception e)//未知异常
            {
                File.AppendAllText(Path.Combine(pathDesktop, @"Exception-log.txt"), $"{DateTime.Now}------未知异常-------" + e.ToString() + Environment.NewLine + Environment.NewLine);
                Console.WriteLine("发生了未处理异常,请稍后重试!");
            }

        }
    }
}
