using System.Runtime.Serialization.Json;

namespace Interface_Segregation
{
    public class JSONSerializer: IManager
    {
        public void Save(List<Human> list)
        {
            FileStream stream = new FileStream("human.json", FileMode.Create);
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Human>));
            jsonFormatter.WriteObject(stream, list);
            stream.Close();
            Console.WriteLine("Сериализация успешно выполнена!");
        }
        public List<Human> Load()
        {
            FileStream stream = new FileStream("human.json", FileMode.Open);
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Human>));
            List<Human> list = jsonFormatter.ReadObject(stream) as List<Human> ?? new List<Human>();
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
