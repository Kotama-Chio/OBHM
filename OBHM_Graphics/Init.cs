using System.Numerics;
using Raylib_cs;
using OBHM_Library;
using Color = Raylib_cs.Color;

namespace OBHM_Graphics
{
    public class Init
    {
        public static void init()
        {
            Raylib.InitWindow(Raylib.GetScreenWidth() / 2, Raylib.GetScreenHeight() / 2, "OBHM");
            Raylib.SetTargetFPS(60);
        }

        public static bool IsGameClose()
        {
            return Raylib.WindowShouldClose();
        }

        public static void DrawBullet(Shape shape, Vector2 position, float size, Color color)
        {
            switch (shape)
            {
                case Shape.Circle :
                    Raylib.DrawCircle((int) position.X,(int) position.Y, size, color);
                    break;
                case Shape.Square :
                    Raylib.DrawRectangle((int) position.X,(int) position.Y, (int) size,(int) size, color);
                    break;
            }
        }
    }
}
