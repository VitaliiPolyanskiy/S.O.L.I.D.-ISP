
namespace Interface_Segregation
{
    public class FileLog : IManager
    {
        public void Write(string str)
        {
            StreamWriter sw = new StreamWriter("User.log", true);
            sw.WriteLine(str);
            sw.Close();
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
