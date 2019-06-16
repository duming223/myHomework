using System;
using System.Drawing;
using System.IO;

namespace DrawImage
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrawImage(5);

            //获取桌面路径
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            while (true)
            {
                try
                {
                    Console.WriteLine("友情提示:200<=长度<=500 100<=高度<=400");
                    //从控制台获取 width, height
                    int width = Input(pathDesktop, out int height);

                    //创建画图对象
                    Graphics ghs = BitImage(width, height, out Bitmap bmp);

                    Console.WriteLine("请输入验证码个数(长度应该大于2<=个数<=6):");
                    if (int.TryParse(Console.ReadLine(), out int codeNumber))
                    {
                        //画验证码
                        DrawCode(ghs, codeNumber, bmp);
                        SaveImage(bmp, @"C:\Users\小马\Desktop\hello.jpg");
                    }
                    else
                    {
                        throw new MyException();
                    }
                }
                catch (ArgumentOutOfRangeException e)//超出范围异常
                {
                    File.AppendAllText(Path.Combine(pathDesktop, "BitImage-log.txt"), $"{DateTime.Now}-  输入超过范围!" + e.ToString() + Environment.NewLine + Environment.NewLine);
                    Console.WriteLine($"超出范围");
                    throw new MyException();
                }
                catch (FormatException e)//格式错误异常
                {
                    File.AppendAllText(Path.Combine(pathDesktop, "BitImage-log.txt"), $"{DateTime.Now}-  格式输入错误!" + e.ToString() + Environment.NewLine + Environment.NewLine);
                    Console.WriteLine($"输入不能转换");
                }
                catch (MyException e)//自定义异常
                {
                    File.AppendAllText(Path.Combine(pathDesktop, @"BitImage-log.txt"), $"{ DateTime.Now}- 验证码长度输入无效,长度应该大于2小于6! " + e.ToString() + Environment.NewLine + Environment.NewLine);
                    Console.WriteLine("不行,你输入验证码超过范围了");
                }
                catch (Exception e)//未知异常
                {
                    File.AppendAllText(Path.Combine(pathDesktop, @"DrawCode-log.txt"), $"{DateTime.Now}------未知异常-------" + e.ToString() + Environment.NewLine + Environment.NewLine);
                    Console.WriteLine("发生了未处理异常,请稍后重试!");
                }
            }

        }
        public static int Input(string path, out int height)
        {
            Console.WriteLine("请输入要画验证码的图片长度:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入要画验证码的图片高度:");
            height = Convert.ToInt32(Console.ReadLine());
            if ((width < 300 || width > 500) || (height < 100 || height > 400))
            {
                throw new ArgumentOutOfRangeException();
            }
            return width;
        }
        public static Graphics BitImage(int width, int height, out Bitmap bitmap)
        {
            Bitmap bmp = new Bitmap(width, height);//创建画布

            bitmap = bmp;
            return Graphics.FromImage(bmp);//创建画图对象
        }
        public static void DrawCode(Graphics ghs, int codeNumber, Bitmap bmp)
        {
            if (codeNumber > 6 || codeNumber < 2)
            {
                throw new MyException();
            }
            Random r = new Random();
            string str = null;
            //生成字符串
            for (int i = 0; i < codeNumber; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber.ToString();
            }

            string[] fonts = { "微软雅黑", "长城中行书体", "黑体", "隶书", "吕建德行楷" };
            Color[] colors = { Color.Black, Color.Blue, Color.Yellow, Color.Red, Color.Navy, Color.Coral };
            //画字符串
            for (int i = 0; i < codeNumber; i++)
            {
                ghs.DrawString(str[i].ToString(), new Font(fonts[r.Next(fonts.Length)], 40, FontStyle.Bold), new SolidBrush(colors[r.Next(colors.Length)]), new Point(i * 45, 0));
            }
            //画线
            for (int i = 0; i < 30; i++)
            {
                Point pointStart = new Point(r.Next(bmp.Width), r.Next(bmp.Height));
                Point pointEnd = new Point(r.Next(bmp.Width), r.Next(bmp.Height));
                ghs.DrawLine(new Pen(colors[r.Next(colors.Length)]), pointStart, pointEnd);
            }
            //画点
            for (int i = 0; i < 900; i++)
            {
                bmp.SetPixel(r.Next(bmp.Width), r.Next(bmp.Height), colors[r.Next(colors.Length)]);
            }
            //画曲线
            for (int i = 0; i < 10; i++)
            {
                ghs.DrawCurve(new Pen(colors[r.Next(colors.Length)]), new Point[]
               {
                new Point(r.Next(bmp.Width),r.Next(bmp.Height)),
                new Point(r.Next(bmp.Width),r.Next(bmp.Height)),
                new Point(r.Next(bmp.Width),r.Next(bmp.Height)),
                new Point(r.Next(bmp.Width),r.Next(bmp.Height))
               });
            }
        }
        public static void SaveImage(Bitmap bmp, string path)
        {
            bmp.Save(path);
            System.Diagnostics.Process.Start(path);
            Console.WriteLine("创建图片成功！");
        }
        class MyException : Exception
        {
            public void MyMessage()
            {
                Console.WriteLine("不行,你输入的验证码太长了!!!");
            }
        }

        #region 完整版画验证码方法
        public static void DrawImage(int codeNumber)
        {
            Bitmap bmp = new Bitmap(280, 100);//创建画布
            Graphics ghs = Graphics.FromImage(bmp);//创建画图对象
            Random r = new Random();
            string str = null;
            //生成字符串
            for (int i = 0; i < codeNumber; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber.ToString();
            }

            string[] fonts = { "微软雅黑", "长城中行书体", "黑体", "隶书", "吕建德行楷" };
            Color[] colors = { Color.Black, Color.Blue, Color.Yellow, Color.Red, Color.Navy, Color.Coral };
            //画字符串
            for (int i = 0; i < codeNumber; i++)
            {
                ghs.DrawString(str[i].ToString(), new Font(fonts[r.Next(fonts.Length)], 60, FontStyle.Bold), new SolidBrush(colors[r.Next(colors.Length)]), new Point(i * 50, 0));
            }
            //画线
            for (int i = 0; i < 30; i++)
            {
                Point pointStart = new Point(r.Next(bmp.Width), r.Next(bmp.Height));
                Point pointEnd = new Point(r.Next(bmp.Width), r.Next(bmp.Height));
                ghs.DrawLine(new Pen(colors[r.Next(colors.Length)]), pointStart, pointEnd);
            }
            //画点
            for (int i = 0; i < 900; i++)
            {
                bmp.SetPixel(r.Next(bmp.Width), r.Next(bmp.Height), colors[r.Next(colors.Length)]);
            }
            //画曲线
            for (int i = 0; i < 10; i++)
            {
                ghs.DrawCurve(new Pen(colors[r.Next(colors.Length)]), new Point[]
               {
                new Point(r.Next(bmp.Width),r.Next(bmp.Height)),
                new Point(r.Next(bmp.Width),r.Next(bmp.Height)),
                new Point(r.Next(bmp.Width),r.Next(bmp.Height)),
                new Point(r.Next(bmp.Width),r.Next(bmp.Height))
               });
            }
            bmp.Save(@"C:\Users\小马\Desktop\hello.jpg");
            System.Diagnostics.Process.Start(@"C:\Users\小马\Desktop\hello.jpg");
            Console.WriteLine("创建图片成功！");
        }
        #endregion
    }
}
