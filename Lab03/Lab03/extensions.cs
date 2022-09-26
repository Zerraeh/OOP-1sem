using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab03.Program;

namespace Lab03
{
    static class ExtforString
    {
        public static string summa(this string str1, string str2)
        {
            str1 += str2;
            return str1;
        }
        public static int razn(this string str1, string str2)
        {
            return Math.Abs(str1.Length - str2.Length);
        }

        public static int numberofElement(this string str)
        {
            return str.Length;
        }

    }
}
