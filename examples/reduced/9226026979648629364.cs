// Generated by Fuzzlyn v1.1 on 2018-09-12 02:55:52
// Seed: 9226026979648629364
// Reduced from 53.9 KiB to 0.7 KiB in 00:01:00
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public int F0;
    public byte F2;
    public byte F3;
    public ushort F5;
    public S0(int f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public S0 F0;
    public int F1;
    public int F2;
    public S0 F3;
    public S1(S0 f0, int f1, S0 f3): this()
    {
        F0 = f0;
        F1 = f1;
        F3 = f3;
    }
}

struct S2
{
    public S1 F0;
    public S2(S1 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        S2 vr6 = new S2(new S1(new S0(1), 0, new S0(0)));
        S1 vr7 = new S1(vr6.F0.F3, vr6.F0.F0.F0, vr6.F0.F3);
        System.Console.WriteLine(vr7.F1);
    }
}
