// Generated by Fuzzlyn v1.1 on 2018-08-19 23:29:44
// Seed: 18003725702415287223
// Reduced from 194.3 KiB to 0.7 KiB in 00:04:29
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public short F0;
    public sbyte F1;
    public byte F2;
    public bool F6;
    public uint F7;
    public S0(uint f7): this()
    {
        F7 = f7;
    }
}

struct S2
{
    public S0 F2;
    public S2(S0 f2): this()
    {
        F2 = f2;
    }
}

class C1
{
    public S0 F3;
}

public class Program
{
    static S2[] s_7 = new S2[]{new S2(new S0(1))};
    static C1 s_20 = new C1();
    public static void Main()
    {
        M26() = s_7[0].F2;
        System.Console.WriteLine(s_20.F3.F7);
    }

    static ref S0 M26()
    {
        s_7 = new S2[]{new S2(new S0(0))};
        return ref s_20.F3;
    }
}
