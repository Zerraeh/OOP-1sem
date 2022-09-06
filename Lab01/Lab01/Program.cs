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
        }
    }
}