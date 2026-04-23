using OBHM_Library;

namespace OBHM_Core;

public class Program
{
    public static List<Bullet> Logic(double time, List<TimeCode> timeCodes)
    {
        foreach (TimeCode tc in timeCodes)
            if (tc.Time == time)
                return tc.Bullets;

        return null;
    }
}
