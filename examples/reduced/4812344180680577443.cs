// Generated by Fuzzlyn on 2018-06-21 13:04:15
// Seed: 4812344180680577443
// Reduced from 7.3 KiB to 0.2 KiB
// Debug: Outputs 65452
// Release: Outputs -84
public class Program
{
    static sbyte[, ] s_2 = new sbyte[, ]{{0}};
    public static void Main()
    {
        s_2[0, 0] |= -127;
        char vr20 = (char)('-' ^ s_2[0, 0]);
        System.Console.WriteLine((int)vr20);
    }
}
