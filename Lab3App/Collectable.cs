namespace Lab3App
{
    // Collectable Abstract Class
    public abstract class Collectable : IDisplayable
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set; }

        protected Collectable(string description)
        {
            Description = description;
        }

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }

        public abstract void Display();
    }
}
