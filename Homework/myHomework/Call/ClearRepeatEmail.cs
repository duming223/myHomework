using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace myHomework.Call
{
    class ClearRepeatEmail
    {
        public static void Call()
        {
            ClearRepeatEmail clearRepeatEmail = new ClearRepeatEmail();
            string loadPath = @"C:\Users\小马\Desktop\email.txt";
            string savePath = @"C:\Users\小马\Desktop\new.txt";
            string all = File.ReadAllText(loadPath);
            clearRepeatEmail.SplitStr(all);
            clearRepeatEmail.Write(loadPath, savePath);
        }
        public void Write(string LoadPath, string savePath)
        {
            string all = File.ReadAllText(LoadPath).Trim();
            List<string> list = SplitStr(all);
            string s = string.Join(";", list);
            for (int i = 1; i < list.Count(); i++)
            {
                File.AppendAllText(savePath, list[i - 1] + ";");
                if (i % 30 == 0)
                {
                    Console.WriteLine();
                }
            }

        }

        Regex regex = new Regex(@"^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$");
        List<string> list = new List<string>();
        public List<string> SplitStr(string filestring)
        {
            char[] rm = { ',', '。', '?', ' ', ':', ';' };
            string[] old = filestring.Split(rm);
            for (int j = 0; j < old.Count(); j++)
            {
                if (regex.IsMatch(old[j]))
                {
                    list.Add(old[j]);
                }
                else
                {
                    for (int i = 0; i < rm.Count(); i++)
                    {
                        while (old[j].Contains(rm[i].ToString()))
                        {
                            SplitStr(old[j]);
                        }
                    }
                }
            }
            //去重复
            //for (int i = 0; i < list.Count; i++)
            //{
            //    for (int j = list.Count - 1; j > i; j--)
            //    {
            //        if (list[i] == list[j])
            //        {
            //            list.RemoveAt(i);
            //        }
            //    }
            //}

            list = list.Distinct().ToList();
            return list;
        }
    }
}
