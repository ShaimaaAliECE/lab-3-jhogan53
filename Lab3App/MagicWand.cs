namespace Lab3App
{
    public class MagicWand : Tool
    {
        public MagicWand(string description) : base(description) { }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }

        public override void Display()
        {
            Console.WriteLine($"Magicwand {Description} is displayed");
        }
    }

}