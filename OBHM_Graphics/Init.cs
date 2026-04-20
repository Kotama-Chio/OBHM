using Raylib_cs;

namespace OBHM_Graphics
{
    public class Init
    {
        public static void init()
        {
            Raylib.InitWindow(Raylib.GetScreenWidth(), Raylib.GetScreenHeight(), "OBHM");
            Raylib.SetTargetFPS(60);

        }

        public static bool IsGameClose()
        {
            return Raylib.WindowShouldClose();
        }
    }
}
