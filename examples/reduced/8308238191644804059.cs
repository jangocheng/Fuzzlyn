// Generated by Fuzzlyn v1.1 on 2018-08-26 01:15:29
// Seed: 8308238191644804059
// Reduced from 173.6 KiB to 0.8 KiB
// Debug: Outputs 161
// Release: Outputs 0
struct S0
{
    public bool F0;
    public bool F1;
    public byte F2;
    public S0(byte f2): this()
    {
        F2 = f2;
    }
}

class C0
{
    public ulong F3;
}

struct S1
{
    public C0 F0;
    public S1(C0 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_5;
    static S0[] s_25 = new S0[]{new S0(0)};
    static S1[][, ][] s_65 = new S1[][, ][]{new S1[, ][]{{new S1[]{new S1(new C0())}}}};
    public static void Main()
    {
        M1(ref s_25);
        System.Console.WriteLine(s_5.F2);
    }

    static ulong M1(ref S0[] arg0)
    {
        M24() = arg0[0];
        return s_65[0][0, 0][0].F0.F3;
    }

    static ref S0 M24()
    {
        S0[] vr10 = new S0[]{new S0(161)};
        s_25 = vr10;
        return ref s_5;
    }
}
