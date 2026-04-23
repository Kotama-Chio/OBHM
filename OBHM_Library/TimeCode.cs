namespace OBHM_Library
{
    public class TimeCode
    {
        public TimeCode(double time, List<Bullet> bullets)
        {
            Time = time;
            Bullets = bullets;
        }

        public List<Bullet> Bullets { get; set; }
        public double Time { get; set; }
    }
}
