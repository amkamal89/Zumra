using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZumraPortal
{
    public static class Helper
    {
        public static string NormalizeTitle(this string title)
        {
            var tmp = "";
            try
            {
                tmp = title.Replace(" ", "-").Replace("\"", "-").Replace(".", "-").Replace("&", "-").Replace(":", "-").Replace(".", "-").Replace("\"", "-").Replace("\'", "-").Replace(";", "-").Replace("--'", "-").Replace("---'", "-").Replace("/''", "-").Replace("|", "-").Replace("!", "-").Replace("#", "-").Replace("%", "-").Replace("$", "-").Replace("*", "-").Replace("?", "-").Replace("؟", "-").Replace(">", "-").Replace("<", "-").Replace(",", "-").Replace("(", "-").Replace(")", "-").Replace("]", "-").Replace("[", "-").Replace("}", "-").Replace("{", "-").Replace("؛", "-").Replace("\\", "-").Replace("/", "-").Replace("+", "-");
                tmp = tmp.Replace("----", "-").Replace("---", "-").Replace("--", "-");

                if (tmp.StartsWith("-"))
                    tmp = tmp.Remove(0, 1);

                if (tmp.EndsWith("-"))
                    tmp = tmp.Remove(tmp.LastIndexOf('-')); //tmp = tmp.Substring(0, title.Length - 1);

                string[] words = tmp.Split('-');
                if (words.Length > 10)
                    tmp = string.Join("-", words, 0, 10);

                return tmp;
            }
            catch
            {
                return tmp;
            }

        }
        public static string datenow()
        {
            DateTime d = new DateTime();
            d = DateTime.Now;

            string date = (d != null) ? string.Format(System.Globalization.CultureInfo.GetCultureInfo("ar-eg"), "{0:dddd، dd MMMM yyyy - hh:mm tt}", d) : "";
            return date;
        }
    }
}