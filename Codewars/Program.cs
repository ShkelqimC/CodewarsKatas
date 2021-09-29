using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAge(1993,2021));
        }
        //How old will I be in 2099? - 8kyu
        public static string CalculateAge(int birth, int yearTo)
        {
            if (birth == yearTo)
                return "You were born this very year!";
            if (birth + 1 == yearTo)
                return $"You are {yearTo - birth} year old.";
            if (birth == yearTo + 1)
                return $"You will be born in { birth - yearTo} year.";
            if (birth > yearTo)
               return $"You will be born in { birth - yearTo} years.";
            if (birth < yearTo)
                return $"You are {yearTo - birth} years old.";

            return "";
        }

        //Row of the odd triangle - 6kyu /todo
        public static long[] OddRow(int n)        
        {
            long[] result = new long[n];
            ulong first = (ulong)(n * (n - 1)+1);
            for (int j = 0; j < n; j++)
            {
                result[j] = (long)first;
                first += 2;
            }

            return result;
        }

        //Encrypt this! - 6kyu - lyckades inte riktigt lösa denna..  //todo
        public static string EncryptThis(string input)
        {

            var test = input.Split(' ').ToList();

            for (int i = 0; i < test.Count; i++)
            {
                if (test[i].Length == 1)
                {
                    int t = test[i][0];
                    test[i] = test[i].Replace(test[i], t.ToString());
                    continue;
                }
                if (test[i].Length > 1)
                {
                    int t = test[i][0];
                    char temp = test[i][1];
                    test[i] = test[i].Replace(test[i][1], test[i][^1]);
                    test[i] = test[i].Remove(test[i].Length - 1, 1);
                    // test[i] = test[i].Replace(test[i][1], temp);
                    test[i] = test[i].Insert(test[i].Length, temp.ToString());
                    test[i] = test[i].Remove(0, 1);
                    test[i] = test[i].Insert(0, t.ToString());

                }

            }

            return string.Join(' ', test);
        }
        //Are they the "same"? - 6kyu
        public static bool comp(int[] a, int[] b)
        {
            if (a.Length ==0)
                return false;

            a = a.OrderBy(x => x).ToArray();
            b = b.OrderBy(x => x).ToArray();
            a = a.Select(x => x * x).ToArray();

            return a.SequenceEqual(b);
            /*
                if (a == null || b == null) return false;
    var result = a.Select(x => x*x).OrderBy(x=>x).SequenceEqual(b.OrderBy(x=>x));
    return result;*/
        }
        //Array.diff - 6kyu
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            //return a.Where(x => !b.Contains(x)).ToArray();

            if (a.Length < 1)
                return a;

            List<int> result = new List<int>();

            foreach (var i in a)
            {
                if (!b.Contains(i))
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }
        //Which string is worth more? - 7kyu
        public static string HighestValue(string a, string b)
        {

          return a.Sum(x => (int) x) == b.Sum(x => (int) x) || a.Sum(x => (int)x) > b.Sum(x => (int)x) ? a : b;
        }
        //Name SHuffler - 8kyu
        public static string NameShuffler(string str)
        {
            var test = str.Split(' ');
            Array.Reverse(test);

           // return string.Join(' ', test);
           return string.Join(' ', str.Split(' ').Reverse());
        }
        //Jaden kasing strings - 7kyu
        public static string ToJadenCase(string phrase)
        {
            var test = phrase.Split(' ').ToList();
            for (int i = 0; i < test.Count; i++)
            {
                var temp = char.ToUpper(test[i][0]).ToString();
                test[i] = test[i].Remove(0, 1);
                test[i] = test[i].Insert(0, temp);
            }

            phrase = string.Join(' ', test);
            return phrase;

            //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase); <- RLYYYYY
            //return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1))); - LINQ
        }
        //Functional addition - 7kyu
        public static Func<double, double> Add(double n)
        {
            return x => x + n;
        }
        //Check the exam - 8kyu
        public static int CheckExam(string[] arr1, string[] arr2)
        {
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (string.IsNullOrEmpty(arr2[i]))
                {
                    continue;
                }
                else if (arr1[i] == arr2[i])
                {
                    count += 4;
                }
                else if (arr1[i] != arr2[i])
                {
                    count -= 1;
                }


            }

            
            return count<0? 0: count;
        }
        //Pandemia - 7kyu
        public static double infected(string s)
        {
            
            var list1 = s.Split('X').ToList();
            double total = list1.Sum(x => x.Length);
            if (total == 0)
            {
                return 0.0;
            }
            var list2 = list1.Where(x => x.Contains("1")).ToList();
            double part = list2.Sum(x => x.Length);

            return 100 *part / total;
        }
        //All Star Code Challenge #18 - 8kyu
        public static int StrCount(string str, string letter)
        {
            return str.Count(x => x.ToString() == letter);
        }
        //Last Survivor
        public static string LastSurvivor(string letters, int[] coords)
        {
            foreach (var coord in coords)
            {
                letters = letters.Remove(coord,1);
            }
            return letters;
        }
        //Acrostic reader
        public static string ReadOut(string[] acrostic)
        {
            StringBuilder sb = new StringBuilder();
            acrostic.Select(x => x.First()).ToList().ForEach(x => sb.Append(x));
            return string.Concat(acrostic.Select(x => x.First()));
        }
        //Hello, Name or World!
        public static string Hello(string name = "World")
        {
            return (name == null || name == string.Empty) ? $"Hello, World!" : $"Hello, {char.ToUpper(name[0])}{name.Substring(1).ToLower()}!";
        }
        //Mobile Display Keystrokes
        public static int MobileKeyboard(string str)
        {
            List<string> strList = new List<string>()
                {"1", "2abc", "3def", "4ghi", "5jkl", "6mno", "7pqrs", "8tuv", "9wxyz", "*", "0", "#"};
            var test = str.ToList();
            int count = 0;
            for (int i = 0; i < test.Count; i++)
            {
                foreach (var VARIABLE in strList)
                {
                    if (VARIABLE.IndexOf(test[i])!=-1)
                    {
                        count += VARIABLE.IndexOf(test[i])+1;
                    }
                }
            }

            return count;
        }
    }
}
