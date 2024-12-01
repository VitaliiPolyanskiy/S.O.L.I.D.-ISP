using System.Xml.Serialization;

namespace Interface_Segregation
{
    public class XMLFormatter : IManager
    {
        public void Save(List<Human> list)
        {
            FileStream stream = new FileStream("human.xml", FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Human>));
            serializer.Serialize(stream, list);
            stream.Close();
            Console.WriteLine("Сериализация успешно выполнена!");
        }
        public List<Human> Load()
        {
            FileStream stream = new FileStream("human.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Human>));
            List<Human> list = serializer.Deserialize(stream) as List<Human> ?? new List<Human>();
            stream.Close();
            Console.WriteLine("Десериализация успешно выполнена!");
            return list;
        }
        public void Write(string str)
        {
            throw new NotImplementedException();
        }
    }
}
