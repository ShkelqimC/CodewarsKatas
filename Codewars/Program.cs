using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
         

            int num1 = 7;
            int num2 = 959;
            int num3 = 13;
            int num4 = 56239814;
            int num5 = 424;

            Console.WriteLine($"{num1}: {BalancedNumber(num1)}");
            Console.WriteLine($"{num2}: {BalancedNumber(num2)}");
            Console.WriteLine($"{num3}: {BalancedNumber(num3)}");
            Console.WriteLine($"{num4}: {BalancedNumber(num4)}");
            Console.WriteLine($"{num5}: {BalancedNumber(num5)}");
            Console.WriteLine();
            int num6 = 1024;
            int num7 = 66545;
            int num8 = 295591;
            int num9 = 1230987;
            int num10 = 432;
            Console.WriteLine($"{num6}: {BalancedNumber(num6)}");
            Console.WriteLine($"{num7}: {BalancedNumber(num7)}");
            Console.WriteLine($"{num8}: {BalancedNumber(num8)}");
            Console.WriteLine($"{num9}: {BalancedNumber(num9)}");
            Console.WriteLine($"{num10}: {BalancedNumber(num10)}");
        }

        //Reverse List Order - 8kyu
        public static List<int> ReverseList(List<int> list)
        {
            // Return a new list with its elements in reverse order compared to the input list
            // Do not mutate the original list!
            //var newList = list.ToArray();
            //Array.Reverse(newList);
            //return newList.ToList();
            return list.Reverse<int>().ToList();

        }
        //Century From Year - 8kyu
        public static int СenturyFromYear(int year)
        {
            return (year - 1) / 100 + 1;
        }

        //Transportation on vacation - 8 kyu
        public static int RentalCarCost(int d)
        {
            return d >= 7 ? 40 * d - 50 : d < 7 && d >= 3 ? 40 * d - 20 : d * 40;
        }
        //Balanced Number (Special Numbers Series #1 ) - 7kyu //todo alla tester green men attempt 1 fail.........
        public static string BalancedNumber(int number)
        {
            string numbers = number.ToString();
            string firsthalf = string.Empty;
            string secondhalf = string.Empty;
            int sumLeft = 0;
            int sumRight = 0;

            if (numbers.Length < 3)
            {
                return "Balanced";
            }
            else if (numbers.Length / 2 % 2 == 0)
            {
                firsthalf = numbers.Substring(0, numbers.Length / 2 - 1);
                secondhalf = numbers.Substring(numbers.Length / 2 + 1);

                sumLeft = firsthalf.Select(x => Convert.ToInt32(x)).Sum(x=> x);
                sumRight = secondhalf.Select(x => Convert.ToInt32(x)).Sum(x=> x);
            }
            else if (numbers.Length / 2 % 2 == 1)
            {
                firsthalf = numbers.Substring(0, numbers.Length / 2 );
                secondhalf = numbers.Substring(numbers.Length / 2+1);
                sumLeft = firsthalf.Select(x => Convert.ToInt32(x)).Sum(x=> x);
                sumRight = secondhalf.Select(x => Convert.ToInt32(x)).Sum();
            }

            return sumRight == sumLeft ? "Balanced" : "Not Balanced";
        }
        //Are You Playing Banjo? 8 kyu
        public static string AreYouPlayingBanjo(string name)
        {
            return name.StartsWith("R", StringComparison.OrdinalIgnoreCase)
                ? $"{name} plays banjo"
                : $"{name} does not play banjo";
        }
        //Switch it Up! - 8kyu
        public static string SwitchItUp(int number)
        {

            return number == 0 ? "Zero" :
                number == 1 ? "One" :
                number == 2 ? "Two" :
                number == 3 ? "Three" :
                number == 4 ? "Four" :
                number == 5 ? "Five" :
                number == 6 ? "Six" :
                number == 7 ? "Seven" :
                    number == 8 ? "Eight":
                "Nine";
        }

        //Sum of odd numbers - 7kyu
        public static long rowSumOddNumbers(long n)
        {
            long sum = 0;
            long firstNumberCount = n*(n-1)+1;

            for (int i = 0; i < n; i++)
            {
                sum += firstNumberCount;
                firstNumberCount += 2;
            }
            return sum;
        }
        //How good are you really? - 8kyu
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints) => YourPoints > ClassPoints.Average(x => x);
        //Complementary DNA - 7 kyu
        public static string MakeComplement(string dna) => dna.Replace('A', 't').Replace('C', 'g').Replace('T', 'a').Replace('G', 'c').ToUpper();
        
            //Twice as old - 8kyu
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            return Math.Abs(dadYears - sonYears * 2);

        }
        //Remove String Spaces - 8kyu
        public static string NoSpace(string input)
        {
            //Code it!
            return input.Replace(" ", "");
        }

        //Remove duplicates from list - 8kyu
        public static int[] distinct(int[] a)
        {
            return a.Distinct().ToArray();
        }
        //Beginner Series #3 Sum of Numbers
        public static int GetSum(int a, int b)
        {
            int result = 0;
            for (int i = Math.Min(a,b); i <= Math.Max(a,b); i++)
            {
                result += i;
            }

            return result;
        }
        //Grasshopper - Debug sayHello - 8kyu
        public static string SayHello(string name)
        {
            return $"Hello, {name}";
        }
        //Define a card suit - 8kyu
        public static string DefineSuit(string card)
        {
            string result = string.Empty;
            switch (card[^1])
            {
                case '♣':
                    result= "clubs";
                    break;
                case '♦':
                    result= "diamonds";
                    break;
                case '♠':
                    result = "spades";
                    break;
                case '♥':
                    result = "hearts";
                    break;
            }

            return result;
        }
        //Function 2 - squaring an argument - 8kyu
        public static double Square(double n) => n * n;
        //Function 1 - hello world - 8kyu
        public static string greet() => "hello world!";
        //Simple multiplication - 8kyu
        public static int Multiply(int x)
        {
            return (x % 2 == 1) ? x * 9 : x * 8;
        }
        //Enumerable Magic #25 - Take the First N Elements - 8kyu
        public static int[] Take(int[] arr, int n)
        {
            return arr.Take(n).ToArray();
        }
        //Difference between years. (Level 1) - 7kyu
        public static int HowManyYears(string date1, string date2)
        {
            var high = Math.Max(DateTime.Parse(date1).Year, DateTime.Parse(date2).Year);
            var low = Math.Min(DateTime.Parse(date1).Year, DateTime.Parse(date2).Year);

            return high - low;
        }
        //is this a triangle? - 7kyu
        public static bool IsTriangle(int a, int b, int c)
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
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
