// Generated by Fuzzlyn v1.1 on 2018-08-20 18:57:14
// Seed: 13248288063026507216
// Reduced from 313.9 KiB to 0.7 KiB in 00:07:07
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public long F0;
    public ulong F1;
    public S0(long f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_5;
    static S0[] s_39 = new S0[]{new S0(1)};
    static long s_42;
    public static void Main()
    {
        var vr4 = new short[][]{new short[]{0}};
        M10(vr4, (int)M15()) = s_39[0];
        long vr6 = s_5.F0;
        System.Console.WriteLine(vr6);
    }

    static ref S0 M10(short[][] arg0, int arg3)
    {
        try
        {
        }
        finally
        {
            arg0[0][0] = 0;
        }

        return ref s_5;
    }

    static long M15()
    {
        s_39 = new S0[]{new S0(0)};
        return s_42;
    }
}
