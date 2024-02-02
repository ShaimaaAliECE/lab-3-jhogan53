namespace Lab3Apps
{
    public class Coin : Treasure
    {
        public int Value { get; set; }

        public Coin(string description, int score, int value) : base(description, score)
        {
            Value = value;
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list); // This calls the AddMe in Treasure, which updates the score
            UpdateTotalValue(); // Now we need to update the total value with a message
        }

        protected void UpdateTotalValue()
        {
            if (Board != null)
            {
                Board.TotalValue += Value;
                Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
            }
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }
}