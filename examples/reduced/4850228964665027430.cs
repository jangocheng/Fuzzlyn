// Generated by Fuzzlyn v1.1 on 2018-09-10 19:04:55
// Seed: 4850228964665027430
// Reduced from 296.4 KiB to 0.8 KiB in 00:05:21
// Debug: Outputs 0
// Release: Outputs 4294921728
public class Program
{
    static short s_5;
    static bool[] s_7 = new bool[]{false};
    static bool[][] s_30 = new bool[][]{new bool[]{false}};
    public static void Main()
    {
        M70(0);
    }

    static void M70(sbyte arg0)
    {
        bool var13 = default(bool);
        arg0 = -1;
        try
        {
            System.Console.WriteLine(var13);
        }
        finally
        {
            bool var14 = arg0 == s_5;
            if (var14)
            {
                s_30[0][0] = s_7[0];
            }
        }

        arg0 = (sbyte)M71();
        uint var17 = (uint)(arg0 * 178);
        System.Console.WriteLine(var17);
    }

    static uint M71()
    {
        s_30[0][0] = s_7[0];
        return 0;
    }
}
