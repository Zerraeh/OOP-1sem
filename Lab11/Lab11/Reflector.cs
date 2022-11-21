using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lab11
{
    public static class Reflector
    {
        private static StreamWriter? fileForInformation = null;
        private static StreamReader? fileForInvoke = null;


        private static readonly string fileForInformationPath = @"D:\_work\ООП\1sem\Lab11\Lab11\Reflection.txt";
        private static readonly string fileForInvokePath = @"D:\_work\ООП\1sem\Lab11\Lab11";


        #region a - определение имени сборки, в которой определён класс

        public static string GetAssemblyName(Type CurrentClass)
        {
            return CurrentClass.Assembly.ToString();
        }

        #endregion



        #region b - есть публичные конструкторы

        public static bool HasPublicConstructors(Type CurrentClass)
        {
            foreach (var item in CurrentClass.GetConstructors(System.Reflection.BindingFlags.Public))
            {
                if (item.IsPublic)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion



        #region c - извлекает все общедоступные публичные методы класса
        // (возвращает IEnumerable<string>);

        public static IEnumerable<string> GetPublicMethodsOfClass(Type CurrentClass)
        {
            List<string> publicMethods = new List<string>();
            foreach (var item in CurrentClass.GetMethods(System.Reflection.BindingFlags.Public))
            {
                if (item.IsPublic)
                {
                    publicMethods.Add(item.ToString());
                }
            }
            
            return publicMethods;
        }

        #endregion



        #region d - получает информацию о полях и свойствах класса (возвращает IEnumerable<string>)

        public static IEnumerable<string> GetFieldsAndPropsOfClass(Type CurrentClass)
        {
            return new List<string> { CurrentClass.GetFields(System.Reflection.BindingFlags.Public).ToString(), CurrentClass.GetFields(System.Reflection.BindingFlags.NonPublic).ToString(), CurrentClass.GetFields(System.Reflection.BindingFlags.Instance).ToString(), CurrentClass.GetProperties(System.Reflection.BindingFlags.Public).ToString(), CurrentClass.GetProperties(System.Reflection.BindingFlags.NonPublic).ToString(), CurrentClass.GetProperties(System.Reflection.BindingFlags.Instance).ToString() };
        }

        #endregion



        #region e - получает все реализованные классом интерфейсы (возвращает IEnumerable<string>);

        public static IEnumerable<string> GetAllInterfacesOfClass(Type CurrentClass)
        {
            List<string> interfaces = new List<string>();
            foreach (var item in CurrentClass.GetInterfaces())
            {
                if (item.IsPublic)
                {
                    interfaces.Add(item.IsPublic.ToString());
                }
            }
            return interfaces;
        }

        #endregion



        #region f - выводит по имени класса имена методов, которые содержат заданный(пользователем) тип параметра(имя класса передается в качестве аргумента);

        public static IEnumerable<string> OutputDataByClassName(Type CurrentClass, string Parameter)
        {
            List<string> Methods = new List<string>();
            var currentClassMethods = CurrentClass.GetMethods();

            foreach (var item in currentClassMethods)
            {
                var itemParams = item.GetParameters();

                if (itemParams.Length == 0)
                {
                    if (Parameter == "")
                    {
                        Methods.Add(item.ToString());
                        continue;
                    }
                }

                if(itemParams.Any(param => (param.Name == Parameter)))
                {
                    Methods.Add(item.ToString());
                }
            }
            return Methods;
        }

        #endregion
    }
}
