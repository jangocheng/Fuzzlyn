// Generated by Fuzzlyn v1.1 on 2018-09-11 15:57:51
// Seed: 11114214175425683617
// Reduced from 353.7 KiB to 0.7 KiB in 00:13:47
// Debug: Outputs 0
// Release: Outputs -4
struct S1
{
    public short F2;
}

struct S3
{
    public S1 F1;
}

public class Program
{
    static long s_31 = -1;
    static S3 s_40;
    public static void Main()
    {
        var vr9 = (short)s_31;
        var vr10 = M51(vr9, ref s_40.F1.F2);
    }

    static long M51(short arg0, ref short arg1)
    {
        arg0 = arg1;
        arg0 %= 32766;
        try
        {
            var vr2 = new byte[]{0};
        }
        finally
        {
            ulong[][] var5 = new ulong[][]{new ulong[]{0}, new ulong[]{0, 1, 0, 0}, new ulong[]{0}, new ulong[]{1}, new ulong[]{0}, new ulong[]{0}, new ulong[]{0, 1}, new ulong[]{0}, new ulong[]{0}};
        }

        System.Console.WriteLine(arg0);
        return 0;
    }
}
