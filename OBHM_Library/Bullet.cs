using System.Numerics;

namespace OBHM_Library
{
    public class Bullet
    {
        Shape shape;
        Color Color;
        float Size;
        Vector2 BeginPosition;
        Dictionary<Vector2, double> Positions = new Dictionary<Vector2, double>();
    }
}

