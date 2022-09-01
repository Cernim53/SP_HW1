using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Search
{
    class Program
    {
        static int Main(string[] args)
        {
            int res;
            string path;
            string word;

            try
            {
                word = args[0];
                path = args[1];

                var find = File.ReadAllText(path);
                Regex regex = new Regex(word);
                MatchCollection match = regex.Matches(find);

                res = match.Count;
            }
            catch (Exception)
            {
                res = 0;
            }

            return res;
        }
    }
}
