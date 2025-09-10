using System.Text.RegularExpressions;

namespace RegexApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "This is CF!";
            string s2 = "12-05-1980 15-09-1990";
            TestGroups(s2);


            //bool isMatch = TestCF(s);
            //Console.WriteLine(isMatch);

            //TestMatch(s);
        }

        // Για έλεγχο αν μια συμβολοσειρά είναι ακριβώς "CF"
        // χρησιμοποιούμε @"^CF$"
        public static bool TestCF(string? s)
        {
            string? pattern = @"^CF$";

            bool isMatch = Regex.IsMatch(s!, pattern);
            return isMatch;
        }

        public static void TestMatch(string? s)
        {
            string? pattern = @"CF";
            Match match = Regex.Match(s!, pattern);

            if (match.Success)
            {
                Console.WriteLine($"Found match: {match.Value} at index {match.Index}");
            }
            else
            {
                Console.WriteLine("No match found");
            }
        }

        public static void TestMatches(string? s)
        {
            string? pattern = @"\d+";
            MatchCollection matches = Regex.Matches(s!, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Found match: {match.Value} at index {match.Index}");
            }


        }

        public static void TestGroups(string? s)
        {
            string? pattern = @"(\d{2})-(\d{2})-(\d{4})";
            MatchCollection matches = Regex.Matches(s!, pattern);

            foreach (Match m in matches)
            {
                Console.WriteLine($"Full Match: {m.Value}");

                for (int i = 1; i < m.Groups.Count; i++)
                {
                    Console.WriteLine($"Group {i}: {m.Groups[i].Value}");
                }
            }


        }

        public static bool TestPassword(string? input)
        {
            return Regex.IsMatch(input!, @"^(?=.*?[a-z])(?=.*?[A-Z])(?=.*?\d)(?=.*?[@$!%*?&])^.{30,}$");

        }
    }
}
