namespace Lab09
{
    internal class Program
    {

        static void Main(string[] args)
        {
            GeometricFigure[] geometricFigures = new GeometricFigure[3]
            {
                new GeometricFigure(5,3),
                new GeometricFigure(6,3),
                new GeometricFigure(7,3),
            };
            Collection geometricFigureList = new Collection(geometricFigures);
            foreach (GeometricFigure g in geometricFigureList)
            {
                Console.WriteLine("Длина: " + g.Length + "\n Ширина: " + g.Width + "\n---\n");
            }
            geometricFigureList.Find(7,3);
            geometricFigureList.Delete();
            foreach (GeometricFigure g in geometricFigureList)
            {
                Console.WriteLine("Длина: " + g.Length + "\n Ширина: " + g.Width + "\n---\n");
            }

        }
    }
}