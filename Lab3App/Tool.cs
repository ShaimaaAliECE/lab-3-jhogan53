namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        protected Tool(string description) : base(description) { }

        public override void AddMe(List<Collectable> list)
        {
            DoAction();
            base.AddMe(list);
        }
        public abstract void DoAction();
    }


}