namespace rr_cli
{
    public abstract class Reward
    {
        public string Name { get; set; }
        public int Pot { get;  set; }
        public int Length { get; set; }
        public abstract float GetReward(int n);
    }
}