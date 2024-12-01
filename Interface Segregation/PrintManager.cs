
namespace Interface_Segregation
{
    class PrintManager
    {
        IManager? manager;
        public void SetManager(IManager manager)
        {
            this.manager = manager;
        }
        public void Print(List<Human>? list)
        {
            if (list?.Count == 0)
            {
                manager?.Write("Список пуст!");
                return;
            }
            foreach (Human j in list)
            {
                manager?.Write(j.Name + "\t" + j.Age);
            }
        }        
    }
}
