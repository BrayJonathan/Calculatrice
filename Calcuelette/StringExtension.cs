using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcuelette
{
    public static class StringExtension
    {
        /// <summary>
        /// Split and keep 
        /// </summary>
        /// <param name="s"> </param>
        /// <param name="delims"> </param>
        /// <returns></returns>
        public static List<string> SplitAndKeepForPlusAndMinus(this string s, char[] delims)
        {
            List<string> results = new List<string>();
            int start = 0;
            int index;

            while ((index = s.IndexOfAny(delims, start)) != -1) //Find first location of delims and return -1 if not found delims
            {
                if (index - start > 0)
                {
                    results.Add(s.Substring(start, index - start));
                }

                if (s[index + 1] == '+' || s[index + 1] == '-')
                {
                    start = index + 2;
                    if (s[index] == '+')
                    {
                        results.Add(s.Substring(index + 1, 1));
                    }
                    else if (s[index] == '-')
                    {
                        if (s[index + 1] == '+')
                        {
                            results.Add(s.Substring(index, 1));
                        }
                        else if (s[index + 1] == '-')
                        {
                            StringBuilder sb = new StringBuilder(s);
                            sb[index] = '+';
                            s = sb.ToString();
                            results.Add(s.Substring(index, 1));
                        }
                    }
                }
                else
                {
                    start = index + 1;
                    results.Add(s.Substring(index, 1));
                };
            }

            if (start < s.Length)
            {
                results.Add(s.Substring(start));
            }
            return results;
        }
    }
}
