// Generated by Fuzzlyn v1.1 on 2018-09-18 07:25:18
// Seed: 7230262569088964085
// Reduced from 116.2 KiB to 0.9 KiB in 00:02:16
// Debug: Outputs 0
// Release: Outputs -2
public class Program
{
    static short s_27;
    static sbyte s_46 = -1;
    static sbyte[] s_60 = new sbyte[]{0};
    static sbyte[] s_62;
    public static void Main()
    {
        var vr4 = s_60[0];
        M59(vr4);
    }

    static void M59(sbyte arg0)
    {
        ulong var3 = default(ulong);
        sbyte var5 = default(sbyte);
        try
        {
            arg0 = s_46;
            arg0 /= -127;
        }
        finally
        {
            s_62 = new sbyte[]{1};
            M60();
            short var4 = s_27;
            M62();
            System.Console.WriteLine(var3);
            System.Console.WriteLine(var4);
            System.Console.WriteLine(var5);
        }

        System.Console.WriteLine(arg0);
    }

    static sbyte M60()
    {
        return default(sbyte);
    }

    static sbyte M62()
    {
        return default(sbyte);
    }
}
