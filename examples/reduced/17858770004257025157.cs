// Generated by Fuzzlyn v1.1 on 2018-09-22 21:36:53
// Seed: 17858770004257025157
// Reduced from 7.2 KiB to 0.3 KiB in 00:00:15
// Debug: Runs successfully
// Release: Throws 'System.DivideByZeroException'
class C0
{
    public byte F1;
    public C0(byte f1)
    {
        F1 = f1;
    }
}

public class Program
{
    static ulong s_1;
    public static void Main()
    {
        C0 vr0 = new C0(19);
        long vr1 = (uint)(-1 % vr0.F1) + (0 / vr0.F1);
        s_1 = (ulong)(1 / vr1);
    }
}
