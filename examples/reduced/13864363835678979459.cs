// Generated by Fuzzlyn v1.1 on 2018-09-11 15:53:19
// Seed: 13864363835678979459
// Reduced from 193.7 KiB to 0.9 KiB in 00:04:17
// Debug: Outputs 0
// Release: Outputs 6912
class C0
{
    public ushort F1;
    public ushort F6;
}

public class Program
{
    static long[] s_6 = new long[]{0};
    static C0[][] s_11 = new C0[][]{new C0[]{new C0()}};
    public static void Main()
    {
        M31(-1, false, 0);
        C0 vr0 = s_11[0][0];
        vr0.F1 = vr0.F6;
        System.Console.WriteLine(s_11[0][0].F1);
    }

    static void M31(sbyte arg0, bool arg3, sbyte arg4)
    {
        try
        {
            arg4 &= arg0;
        }
        finally
        {
            ushort var2;
            try
            {
                long var4 = s_6[0];
            }
            finally
            {
                var2 = 0;
            }

            System.Console.WriteLine(var2);
        }

        if (!arg3)
        {
            arg0 = arg4;
            s_11[0][0].F6 = (ushort)(22501 * arg0);
        }

        System.Console.WriteLine(arg0);
    }
}
