// Generated by Fuzzlyn on 2018-07-09 03:07:20
// Seed: 5402954071561405575
// Reduced from 39.9 KiB to 0.2 KiB
// Debug: Outputs 65534
// Release: Outputs 4294967294
public class Program
{
    static short s_7;
    public static void Main()
    {
        short vr22 = s_7--;
        var vr24 = (char)(1L ^ s_7);
        ulong vr35 = vr24;
        System.Console.WriteLine(vr35);
    }
}
