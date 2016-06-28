using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpressYourself
{
    public class Parser
    {
        /// <summary>
        /// Looks for a title in a Media file string.
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>the title string if it exists</returns>
        public static string GetTitle(string str)
        {
            // TODO
            var titleExpression = new Regex(@"title\: (.*),+");
            var match = titleExpression.Match(str);
            if (!match.Success)
            {
                return "NOT FOUND";
            }
            else
            {
                return match.Groups[1].Value;
            }
            return "";
        }

        public static string GetType(string str)
        {
            // TODO
            return "";
        }

        public static string GetLength(string str)
        {
            // TODO
            return "";
        }

        public static bool IsValidLine(string str)
        {
            // TODO
            return false;
        }
    }
}
