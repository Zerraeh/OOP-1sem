using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using Newtonsoft.Json;
using System.Xml.Serialization;


using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Lab13
{
    public class CustomSerializer
    {
        #region BIN
        public static void SerializeToBinary<T>(T obj) where T : class
        {
            var binaryEdit = new BinaryFormatter();
            using (var fileStream = new FileStream(@"D:\_work\ООП\1sem\Lab13\Lab13\bin.bin", FileMode.OpenOrCreate))
            {
                binaryEdit.Serialize(fileStream, obj);
            }
        }
        public static void deSerializeToBinary<T>(ref T obj) where T : class
        {
            var binaryEdit = new BinaryFormatter();
            using (var fileStream = new FileStream(@"D:\_work\ООП\1sem\Lab13\Lab13\bin.bin", FileMode.OpenOrCreate))
            {
                obj = binaryEdit.Deserialize(fileStream) as T;
            }
        }
        #endregion

        #region SOAP
        public static void SerializeToSoap<T>(T obj) where T : class
        {
            var soapEdit = new SoapFormatter();
            using (var fileStream = new FileStream(@"D:\_work\ООП\1sem\Lab13\Lab13\soap.soap", FileMode.OpenOrCreate))
            {
                soapEdit.Serialize(fileStream, obj);
            }
        }

        public static void deSerializeToSoap<T>(ref T obj) where T : class
        {
            var soapEdit = new SoapFormatter();
            using (var fileStream = new FileStream(@"D:\_work\ООП\1sem\Lab13\Lab13\soap.soap", FileMode.OpenOrCreate))
            {
                soapEdit.Serialize(fileStream, obj);
            }
        }
        #endregion


        #region JSON
        public static async void SerializeToJSON<T>(T obj) where T : class
        {
            string jsonStr = JsonConvert.SerializeObject(obj, Formatting.Indented);
            var jsonFormat = new DataContractJsonSerializer(typeof(T));
            using (var fileStream = new FileStream(@"D:\_work\ООП\1sem\Lab13\Lab13\JSON.json", FileMode.OpenOrCreate))
            {
                jsonFormat.WriteObject(fileStream, obj);
            }
        }
        public static void deSerializeToJSON<T>(ref T obj) where T : class
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            var jsonFormat = new DataContractJsonSerializer(typeof(T));
            using (var fileStream = new FileStream(@"D:\_work\ООП\1sem\Lab13\Lab13\JSON.json", FileMode.OpenOrCreate))
            {
                obj = (T)jsonFormat.ReadObject(fileStream);
            }
        }
        #endregion


        #region XML
        public static void SerializeToXML<T>(T obj) where T : class
        {
            var XMLEdit = new XmlSerializer(typeof(T));
            using (var fileStream = new FileStream(@"D:\_work\ООП\1sem\Lab13\Lab13\xml.xml", FileMode.OpenOrCreate))
            {
                XMLEdit.Serialize(fileStream, obj);
            }
        }
        public static void deSerializeToXML<T>(ref T obj) where T : class
        {
            var XMLEdit = new XmlSerializer(typeof(T));
            using (var fileStream = new FileStream(@"D:\_work\ООП\1sem\Lab13\Lab13\xml.xml", FileMode.OpenOrCreate))
            {
                obj = XMLEdit.Deserialize(fileStream) as T;
            }
        }
        #endregion
    }
}
