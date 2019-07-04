using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawImage
{
    class CAPTCHA
    {
        internal Bitmap bitmap;
        private Graphics graphics;
        private Random random;
        private Color[] colors = { Color.Black, Color.Blue, Color.Yellow, Color.Red, Color.Navy, Color.Coral };
        private string[] fonts = { "微软雅黑", "长城中行书体", "黑体", "隶书", "吕建德行楷" };
        private FontStyle[] fontStyles = { FontStyle.Italic, FontStyle.Bold, FontStyle.Regular };
        public CAPTCHA(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            random = new Random();
            graphics = Graphics.FromImage(bitmap);
        }
        /// <summary>
        /// 画字符串
        /// </summary>
        /// <param name="codeNumber"></param>
        /// <returns></returns>
        internal void CreateBitmap(int codeNumber,out string strCode)
        {
            if (codeNumber <= 0)
            {
                throw new MyException();
            }
            float fontSize = 60;
            strCode = null;

            for (int i = 0; i < codeNumber; i++)
            {
                int rNumber = random.Next(10);
                strCode += rNumber.ToString();
            }
            for (int i = 0; i < codeNumber; i++)
            {
                graphics.DrawString(strCode[i].ToString(), new Font(fonts[random.Next(fonts.Length)], fontSize, fontStyles[random.Next(fontStyles.Length)]), new SolidBrush(colors[random.Next(colors.Length)]), new Point(i * 50, 0));
            }
        }
        /// <summary>
        /// 添加曲线
        /// </summary>
        public void AddCurve(int curveNumber)
        {
            for (int i = 0; i < curveNumber; i++)
            {
                graphics.DrawCurve(new Pen(colors[random.Next(colors.Length)]), new Point[]
               {
                new Point(random.Next(bitmap.Width),random.Next(bitmap.Height)),
                new Point(random.Next(bitmap.Width),random.Next(bitmap.Height)),
                new Point(random.Next(bitmap.Width),random.Next(bitmap.Height)),
                new Point(random.Next(bitmap.Width),random.Next(bitmap.Height))
               });
            }
        }
        /// <summary>
        /// 添加像素点
        /// </summary>
        public void AddPixel(int pixelNumber)
        {
            for (int i = 0; i < pixelNumber; i++)
            {
                bitmap.SetPixel(random.Next(bitmap.Width), random.Next(bitmap.Height), colors[random.Next(colors.Length)]);
            }
        }



    }
    class MyException : Exception
    {
        public void MyMessage()
        {
            Console.WriteLine("不行,不在范围!!!");
        }
    }
}
