namespace ClickTheBox.API.Models
{
    public class Level
    {
        public double[] Weights { get; set; }
        public double[] WaterSpeed { get; set; }
        public double Target { get; set; }
        public int MatchTime { get; set; }

        // Foreign Key
        public int PlayerId { get; set; }
        // Navigation property
        public Player Player { get; set; }



        public Level() { }

        public Level(double[] weights, double[] waterSpeed, double target, int matchTime)
        {
            Weights = weights;
            WaterSpeed = waterSpeed;
            Target = target;
            MatchTime = matchTime;
        }
    }
}
