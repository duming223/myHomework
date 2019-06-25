using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace myHomework.Call
{
    class ClearRepeatEmail
    {
        public string ReadToMemory(string loadPath)
        {
            string all = File.ReadAllText(loadPath);
            string regex = "^[0-9a-zA-Z]+";
            if(Regex.IsMatch(all, regex))
            {
                //.......
            }
            string[] newAll = all.Split(new char[] { ',', '.', '?', ' ', ':' });
            string str = string.Join(";", newAll);
            return str;
        }

        public void Write(string path)
        {
            string content = ReadToMemory(@"c:\...");
            File.WriteAllText(path, content);
        }
    }
}
