// Generated by Fuzzlyn on 2018-06-23 17:16:01
// Seed: 14412385401399977672
// Reduced from 59.8 KiB to 0.2 KiB
// Debug: Outputs 247
// Release: Outputs 4294967287
public class Program
{
    static sbyte s_2;
    public static void Main()
    {
        s_2 = (sbyte)-10L;
        var vr42 = (byte)(1U | s_2);
        long vr43 = vr42;
        System.Console.WriteLine(vr43);
    }
}
