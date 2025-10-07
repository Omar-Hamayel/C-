namespace Taske2
{
    internal abstract class  Person
    {
        protected Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void DispalyInfo();
    }
}
