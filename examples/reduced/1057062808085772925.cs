// Generated by Fuzzlyn on 2018-07-20 11:34:20
// Seed: 1057062808085772925
// Reduced from 12.0 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static uint s_2;
    static byte[, ] s_5 = new byte[, ]{{0}};
    public static void Main()
    {
        uint vr0 = default(uint);
        vr0 >>= 0 & s_5[0, 0];
        s_5[0, 0] = 0;
        s_2 %= (vr0 | 1);
    }
}
