// Generated by Fuzzlyn on 2018-07-14 07:36:55
// Seed: 8550215191445258409
// Reduced from 170.9 KiB to 0.3 KiB
// Debug: Outputs 65526
// Release: Outputs 4294967286
public class Program
{
    static sbyte[, ] s_7 = new sbyte[, ]{{0}};
    static int s_11;
    public static void Main()
    {
        s_7[0, 0] = -10;
        uint vr16 = (ushort)(s_11 | s_7[0, 0]);
        System.Console.WriteLine(vr16);
    }
}
