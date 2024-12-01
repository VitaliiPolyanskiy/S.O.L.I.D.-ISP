
namespace Interface_Segregation
{
    public class ConsoleLog : IManager
    {
        public void Write(string str)
        {
            Console.WriteLine(str);
        }
        public void Save(List<Human> list)
        {
            throw new NotImplementedException();
        }
        public List<Human> Load()
        {
            throw new NotImplementedException();
        }
    }
}
