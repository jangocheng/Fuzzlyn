// Generated by Fuzzlyn on 2018-07-08 02:09:54
// Seed: 5943323206675757545
// Reduced from 18.4 KiB to 0.3 KiB
// Debug: Outputs 65408
// Release: Outputs -128
class C0
{
    public sbyte F0;
    public C0(sbyte f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static C0 s_3 = new C0(127);
    static long s_6;
    public static void Main()
    {
        var vr5 = s_3.F0++;
        char vr9 = (char)(s_3.F0 | (char)(s_6 | 0));
        System.Console.WriteLine((int)vr9);
    }
}
