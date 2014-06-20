//using System.IO;
//using System.Text;
//using System.Xml;

//namespace SwissArmy
//{
//    public static class XmlSerializer
//    {
//        //Creates an object from an XML string.
//        public static T DeserializeFromXmlString<T>(string xmlString)
//        {
//            var ser = new System.Xml.Serialization.XmlSerializer(typeof(T));
//            var stringReader = new StringReader(xmlString);
//            var xmlReader = new XmlTextReader(stringReader);
//            object obj = ser.Deserialize(xmlReader);
//            xmlReader.Close();
//            stringReader.Close();
//            return (T)obj;
//        }

//        //Serializes the <i>Obj</i> to an XML string.
//        public static string SerializeToXmlString<T>(T objectToSerialize)
//        {
//            var ser = new System.Xml.Serialization.XmlSerializer(typeof(T));
//            var memStream = new MemoryStream();
//            var xmlWriter = new XmlTextWriter(memStream, Encoding.Default);
//            ser.Serialize(xmlWriter, objectToSerialize);
//            xmlWriter.Close();
//            memStream.Close();
//            return Encoding.UTF8.GetString(memStream.GetBuffer());
//        }
//    }
//}