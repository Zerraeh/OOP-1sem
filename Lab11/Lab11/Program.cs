namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st
            File.WriteAllText("Reflection.txt", string.Empty);

            Reflector.NameWrite("Lab11.Reflector");
            Reflector.PublicMethodsEnumerationWrite("Lab11.Reflector");
            Reflector.FieldsAndPropsWrite("Lab11.Reflector");

            Reflector.InterfacesOfClassWrite("Lab09.GeometricFigure");
            Reflector.OutputDataByClassNameWrite("Lab09.GeometricFigure","currentClassName");
            Reflector.Invoke("Lab09.GeometricFigure", "dosomething");

            Reflector.Create(5, 6);
            #endregion
        }
    }
}