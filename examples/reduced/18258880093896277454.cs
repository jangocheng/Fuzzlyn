// Generated by Fuzzlyn on 2018-07-14 00:04:41
// Seed: 18258880093896277454
// Reduced from 56.9 KiB to 0.3 KiB
// Debug: Outputs 65408
// Release: Outputs 4294967168
public class Program
{
    public static void Main()
    {
        var vr16 = new sbyte[]{0};
        char vr17 = M14(vr16);
        ulong vr11 = vr17;
        System.Console.WriteLine(vr11);
    }

    static char M14(sbyte[] arg1)
    {
        arg1[0] = -128;
        return (char)(0 ^ arg1[0]);
    }
}
