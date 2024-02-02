namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score { get; set; }

        protected Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalScore(); // Calls UpdateTotalScore which updates CollectionBoard's TotalScore
        }

        protected void UpdateTotalScore()
        {
            if (Board != null)
            {
                Board.TotalScore += Score; // Directly updates the TotalScore in CollectionBoard
                Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
            }
        }
    }
}