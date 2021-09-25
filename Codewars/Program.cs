using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
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

    }
}
