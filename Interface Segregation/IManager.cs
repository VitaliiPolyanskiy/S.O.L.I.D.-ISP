
namespace Interface_Segregation
{
    public interface IManager
    {
        void Write(string str);
        void Save(List<Human> collection);
        List<Human> Load();
    }
}
