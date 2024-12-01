namespace Interface_Segregation
{
    class Program
    {
        static void Client(IManager log, IManager serializer)
        {
            Сontainer c = new Сontainer();
            c.Add(new Human("Larry Page", 50));
            c.Add(new Human("Satya Nadella", 56));
            c.Add(new Human("Tim Cook", 62));
            PrintManager printmanager = new PrintManager();
            List<Human>? list = c.Get();
            printmanager.SetManager(log);
            printmanager.Print(list);
            HumanRepository repository = new HumanRepository();
            repository.SetManager(serializer);
            repository.Save(list);
            c.RemoveAll();
            list = c.Get();
            printmanager.Print(list);
            list = repository.Load();
            printmanager.Print(list);
        }
        static void Main(string[] args)
        {
            IManager log = new ConsoleLog();
            IManager serializer = new XMLFormatter();
            Client(log, serializer);
            log = new FileLog();
            serializer = new JSONSerializer();
            Client(log, serializer);
        }
    }
}
