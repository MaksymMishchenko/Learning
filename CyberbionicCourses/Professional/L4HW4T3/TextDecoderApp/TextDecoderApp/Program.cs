using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace TextDecoderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("text.txt", Encoding.Default);
            string pattern = @"\s[а-я]{1,3}\s";

            var newText = Regex.Replace(text, pattern, " ГАВ! ");

            File.WriteAllText("new_file.txt",newText, Encoding.Default);
        }
    }
}
