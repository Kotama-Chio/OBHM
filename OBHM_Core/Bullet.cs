using System.Numerics;
using Raylib_cs;

namespace OBHM_Core;

public record Bullet
{
    Shape shape;
    Color Color;
    float Size;
    Vector2 BeginPosition;
    Dictionary<Vector2, double> Positions = new Dictionary<Vector2, double>();
}
