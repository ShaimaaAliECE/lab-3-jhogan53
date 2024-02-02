namespace Lab3App
{
    // Diamond Class
    public class Diamond : Treasure
    {
        public Diamond(string description, int score) : base(description, score) { }

        public override void Display()
        {
            Console.WriteLine($"Diamond {Description} is displayed");
        }
    }
}