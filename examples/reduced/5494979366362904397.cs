// Generated by Fuzzlyn v1.1 on 2018-09-21 13:45:26
// Seed: 5494979366362904397
// Reduced from 142.7 KiB to 0.7 KiB in 00:04:49
// Debug: Outputs 18446744073709551615
// Release: Outputs 255
public class Program
{
    static ulong s_14;
    static int[] s_24;
    static ushort s_32;
    static sbyte s_62 = -1;
    public static void Main()
    {
        M69(0);
    }

    static void M69(sbyte arg0)
    {
        try
        {
            M70();
        }
        finally
        {
            arg0 = s_62;
            sbyte var3 = arg0;
            ulong var4 = s_14;
            s_24 = new int[]{1};
            uint[] var6 = new uint[]{0, 1, 0, 0, 0, 0};
            var4 = (ulong)var3;
            System.Console.WriteLine(s_32);
            System.Console.WriteLine(var4);
        }

        System.Console.WriteLine(arg0);
    }

    static bool M70()
    {
        return default(bool);
    }
}
