// Generated by Fuzzlyn v1.1 on 2018-09-03 15:22:51
// Seed: 6632779078713315537
// Reduced from 258.8 KiB to 0.7 KiB in 00:08:35
// Debug: Outputs 0
// Release: Outputs -75
public class Program
{
    static uint s_11;
    static int s_28 = -1;
    static uint[] s_36 = new uint[]{0};
    static short[] s_39 = new short[]{0};
    public static void Main()
    {
        uint vr5 = s_36[0]--;
        uint vr6 = s_36[0];
        short vr8 = (short)vr6;
        ulong vr3 = (ulong)vr8;
        var vr4 = (short)vr3;
        M70(vr4);
    }

    static void M70(short arg0)
    {
        try
        {
            M71();
        }
        finally
        {
            s_39[0] = arg0;
        }

        arg0 <<= s_28;
        sbyte var2 = -69;
        var2 = (sbyte)(arg0 / var2);
        System.Console.WriteLine(var2);
    }

    static uint M71()
    {
        return s_11;
    }
}
