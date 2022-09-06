namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-a
            bool booleanValue = true;
            byte byteValue = 22;
            sbyte sbyteValue = -2;
            char charValue = 'a';
            decimal decimalValue = 22.5m;
            double doubleValue = 22.5;
            float floatValue = 22.5f;
            int intValue = -2;
            uint uintValue = 1;
            nint nintValue = -7;
            nuint nuintValue = 1;
            long longValue = -5;
            ulong ulongValue = 3;
            short shortValue = -3;
            ushort ushortValue = 3;
            Console.WriteLine(booleanValue + "\t" + byteValue + "\t" + sbyteValue + "\t" + charValue + "\t" + decimalValue + "\t" + doubleValue +
                "\t" + floatValue + "\t" + intValue + "\t" + uintValue + "\t" + nintValue + "\t" + nuintValue + "\t" + longValue + "\t" + ulongValue + "\t" +
                shortValue + "\t" + ushortValue);
            //1-b
            byteValue = Convert.ToByte(booleanValue);
            Console.WriteLine(byteValue);

            charValue = Convert.ToChar(ulongValue);
            Console.WriteLine(charValue);

            doubleValue = Convert.ToDouble(floatValue);
            Console.WriteLine(doubleValue);

            floatValue = Convert.ToSingle(floatValue);
            Console.WriteLine(floatValue);

            intValue = Convert.ToInt32(longValue);
            Console.WriteLine(intValue);
            //1-c
            int SomeIntValue = 35;
            Object BoxedValue = SomeIntValue;
            //-----unbox
            int SomeNewIntValue = (int)BoxedValue;
            //1-d
            var samoVar = "Самовар";
            var intVar = 55;
            Console.WriteLine($"Интовский вар: {intVar} , samoVar: {samoVar}, Контеканация(как пример работы с ними): {intVar + samoVar}");
            // 1-e
            int? nullable = null;
            int valuefortest = Convert.ToInt32(nullable);
            Console.WriteLine(valuefortest);
            //1-f
            var q = 5;
            q = 'a';
            //а где ошибка то потерялась?


            //2-a
            const string str1 = "надоела эта лабораторная, какая же она скучная, лучше бы сделали покороче, чем это всё протыкивать";
            const string str2 = "согласен со сказанным выше (c)моя шизофрения";
            if(str1 == str2)
            {
                Console.WriteLine(str1 , str2);
            }

            //2-b
            string firstStr = "aaa,";
            string secondStr = "bbb,";
            string thirdStr = "ccc,";
            string sumStr = firstStr + secondStr + thirdStr;
            Console.WriteLine(sumStr);
            firstStr = String.Copy(secondStr);
            Console.WriteLine(firstStr);
            string firstword = sumStr.Substring(0, sumStr.IndexOf(','));
            string txt = "Вот так вот и вышло";
            string[] words = txt.Split(new char[] { ' ' });
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
            sumStr = sumStr.Insert(3, firstword);

            Console.Write("Введите подстроку: ");
            string substr = Console.ReadLine();
            sumStr = sumStr.Replace(substr, "");
            Console.WriteLine(sumStr);

            long phoneNum = 80296665544;
            Console.WriteLine($"{phoneNum: #### ### ## ##}");
            
        }
    }
}