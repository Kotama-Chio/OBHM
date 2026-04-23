using System.Numerics;

namespace OBHM_Library
{
    public class Bullet
    {
        public Vector2 BeginPosition;
        public Color Color;
        public Dictionary<Vector2, double> Positions = new Dictionary<Vector2, double>();
        public Shape shape;
        public float Size;
    }
}
