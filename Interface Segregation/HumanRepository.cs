namespace Interface_Segregation
{
    class HumanRepository
    {
        IManager? manager;
        public void SetManager(IManager manager)
        {
            this.manager = manager;
        }  
        public void Save(List<Human> list)
        {
            manager?.Save(list);
        }
        public List<Human>? Load()
        {
            List<Human>? list = manager?.Load();
            return list;
        }
    }
}
