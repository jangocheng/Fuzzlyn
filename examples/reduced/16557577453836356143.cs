// Generated by Fuzzlyn on 2018-07-08 16:17:13
// Seed: 16557577453836356143
// Reduced from 48.0 KiB to 0.2 KiB
// Debug: Outputs 131
// Release: Outputs -125
public class Program
{
    static sbyte s_4;
    static sbyte s_15 = -127;
    public static void Main()
    {
        s_4 = s_15;
        byte vr48 = (byte)(s_4 | 2U);
        int vr50 = vr48;
        System.Console.WriteLine(vr50);
    }
}
