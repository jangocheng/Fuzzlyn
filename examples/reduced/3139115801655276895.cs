// Generated by Fuzzlyn on 2018-07-19 02:16:39
// Seed: 3139115801655276895
// Reduced from 70.7 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public long F2;
}

public class Program
{
    static C0[,, ] s_14 = new C0[,, ]{{{new C0()}}};
    public static void Main()
    {
        long vr7 = 0 & s_14[0, 0, 0].F2;
        s_14[0, 0, 0] = s_14[0, 0, 0];
        System.Console.WriteLine(vr7);
    }
}
