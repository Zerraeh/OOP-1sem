using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public static class Reflector
    {
        private static StreamWriter? fileForInformation = null;
        private static StreamReader? fileForInvoke = null;


        private static readonly string fileForInformationPath = @"D:\_work\ООП\1sem\Lab11\Lab11\Reflection.txt";
        private static readonly string fileForInvokePath = @"D:\_work\ООП\1sem\Lab11\Lab11";

        // a - определение имени сборки, в которой определён класс
        public static string GetAssemblyName(Type CurrentClass)
        {
            return CurrentClass.Assembly.ToString();
        }
        
    }
}
