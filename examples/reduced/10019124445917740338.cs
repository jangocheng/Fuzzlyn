// Generated by Fuzzlyn v1.1 on 2018-08-13 13:00:48
// Seed: 10019124445917740338
// Reduced from 331.0 KiB to 0.8 KiB
// Debug: Outputs -10
// Release: Outputs 10726
public class Program
{
    static long[] s_7 = new long[]{0};
    static ulong[] s_99 = new ulong[]{1047217248190091471UL};
    static short[] s_131 = new short[]{-10};
    static long s_159;
    public static void Main()
    {
        ulong vr13 = s_99[0];
        var vr10 = (short)vr13;
        bool vr11 = M143(vr10) == 0;
    }

    static short M143(short arg0)
    {
        bool[][][] var16;
        try
        {
            System.Console.WriteLine(s_7[0]);
        }
        finally
        {
            var16 = new bool[][][]{new bool[][]{new bool[]{true}}, new bool[][]{new bool[]{true}}, new bool[][]{new bool[]{true}}, new bool[][]{new bool[]{true}}};
        }

        s_159 %= arg0;
        arg0 = s_131[0];
        arg0 %= 10960;
        System.Console.WriteLine(arg0);
        return arg0;
    }
}
