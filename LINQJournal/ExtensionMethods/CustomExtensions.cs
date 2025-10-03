using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class CustomExtensions
    {
        public static string ToTitleCase(this string value)
        {
            string[] words = value.Split(' ');
            List<string> titles = new List<string>();
            foreach (string word in words)
            {
                string titleCase = word.Substring(0,1).ToUpper() + word.Substring(1, word.Length - 1);
                titles.Add(titleCase);
            }

            return string.Join(" ", titles.ToArray());
        }

        public static string RemoveMiddleEmpty(this string value)
        {
            return value.Replace(" ", "");
        }

        public static string NextLetter(this Random random, bool isUpper = false, bool isSymbol = false)
        {
            //65-90: A-Z
            //97-122: a-z

            if (!isSymbol)
            {
                int value = isUpper ? random.Next(97, 123) : random.Next(65, 90);

                return ((char)value).ToString();
            }
            else {
                int value = random.Next(33, 65);
                return ((char)value).ToString();
            }
           
        }

        public static string NextPassword(this Random random,int length =6, bool isIncludeSymbol = true)
        {

            string password = string.Empty;
            for (int i = 0; i < length; i++)
            {
                bool isUpper = Convert.ToBoolean(random.Next(0, 2));
                Thread.Sleep(30);
                bool isSymbol = Convert.ToBoolean(random.Next(0, 2));
                password = isIncludeSymbol ? password += random.NextLetter(isUpper, isSymbol)
                                           : password += random.NextLetter(isUpper, false);
            }

            return password;
        }
    }
}
