using System.Xml;
using System.Xml.Linq;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11 вариант - Автомобиль, Поезд, Транспортное средство, Экспресс, Двигатель, Вагон
            Transport.car car1 = new Transport.car();
            Transport.train.Express expressTrain = new Transport.train.Express();
            Transport.car.engine engine = new Transport.car.engine();
            Transport.train.vagon vagon = new Transport.train.vagon();



            car1.Move();
            Console.WriteLine("----");

            expressTrain.ExpressOrNot();
            expressTrain.Move();
            Console.WriteLine("----");

            engine.Work();
            Console.WriteLine("----");

            vagon.Move();
            Console.WriteLine("----");


            //5
            Transport.train train1 = new Transport.train();

            Console.WriteLine($"Поезд экспресс? - {train1 is Transport.train.Express}");
            Transport.train.Express? expressTrain1 = train1 as Transport.train.Express;
            if (expressTrain1 == null)
            {
                Console.WriteLine("Неудачно!");
            }
            car1.ToString();
            expressTrain.ToString();

            //7
            var printer = new Printer();
            Transport[] transports = new Transport[3];
            transports[0] = train1;
            transports[1] = car1;
            transports[2] = expressTrain;

            foreach (Transport item in transports)
            {
                printer.IAmPrinting(item);
            }

            //1
            Transport.car carRefContain = new Transport.car();


            CustomSerializer.SerializeToBinary(car1);
            CustomSerializer.deSerializeToBinary(ref carRefContain);
            Console.WriteLine($"Инфа по полученному элементу из bin:\t {carRefContain}");

            CustomSerializer.SerializeToSoap(car1);
            CustomSerializer.deSerializeToSoap(ref carRefContain);
            Console.WriteLine($"Инфа по полученному элементу из soap:\t {carRefContain}");

            CustomSerializer.SerializeToJSON(car1);
            CustomSerializer.deSerializeToJSON(ref carRefContain);
            Console.WriteLine($"Инфа по полученному элементу из json:\t {carRefContain}");

            CustomSerializer.SerializeToXML(car1);
            CustomSerializer.deSerializeToXML(ref carRefContain);
            Console.WriteLine($"Инфа по полученному элементу из xml:\t {carRefContain}");

            //2

            var transportCollection = new List<Transport>();
            var transportCollectionFromFile = new List<Transport>();

            transportCollection.Add(car1);
            transportCollection.Add(train1);
            transportCollection.Add(expressTrain);
            transportCollection.Add(vagon);

            CustomSerializer.SerializeToBinary(transportCollection);
            CustomSerializer.deSerializeToBinary(ref transportCollectionFromFile);

            foreach (var item in transportCollectionFromFile)
            {
                Console.WriteLine(item);
            }

            //3
            XmlDocument xmlDocument = new XmlDocument();

            xmlDocument.Load(@"D:\_work\ООП\1sem\Lab13\Lab13\xml.xml");
            var xroot = xmlDocument.DocumentElement;

            var selectNodes = xroot.SelectNodes("*");

            foreach (var item in selectNodes)
            {
                Console.WriteLine((item as XmlNode).Name);
            }

            Console.WriteLine("\n\n");

            var namesNodes = xroot.SelectNodes("Name");

            foreach (var item in namesNodes)
            {
                Console.WriteLine((item as XmlNode).InnerText);
            }

            //4
            XDocument xDoc = new XDocument();
            XElement element = new XElement("element1");
            XElement root = new XElement("data");
            XElement myElement;
            XElement id;
            XAttribute day;

            myElement = new XElement("myElement");
            id = new XElement("id");
            id.Value = "5";
            day = new XAttribute("day", "18");


            myElement.Add(id);
            myElement.Add(day);
            root.Add(myElement);

            myElement = new XElement("myElement");
            id = new XElement("id");
            id.Value = "7";
            day = new XAttribute("day", "19");


            myElement.Add(id);
            myElement.Add(day);
            root.Add(myElement);

            xDoc.Add(root);
            xDoc.Save(@"D:\_work\ООП\1sem\Lab13\Lab13\4xml.xml");

            Console.WriteLine("Поиск по id:");
            string? strId = Console.ReadLine();
            var elems = root.Elements("myElement");

            foreach (var item in elems)
            {
                if (item.Attribute("id").Value == strId) Console.WriteLine(item.Value);
            }
        }

        
    }
}