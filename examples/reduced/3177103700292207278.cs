// Generated by Fuzzlyn v1.1 on 2018-09-21 17:59:02
// Seed: 3177103700292207278
// Reduced from 244.4 KiB to 0.8 KiB in 00:05:45
// Debug: Prints 1 line(s)
// Release: Prints 0 line(s)
struct S0
{
    public ushort F2;
    public ulong F3;
}

struct S1
{
    public S0 F0;
    public S0 F2;
}

struct S2
{
    public bool F0;
    public uint F4;
    public ushort F5;
    public ulong F6;
    public S2(bool f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1 s_9;
    public static void Main()
    {
        var vr15 = new S2(true);
        bool vr21 = vr15.F0;
        var vr16 = new S2(vr21);
        var vr17 = new S2(false);
        var vr18 = new S1();
        M23(vr16, M23(vr17, vr18));
    }

    static ref S1 M23(S2 arg0, S1 arg1)
    {
        if (arg0.F0)
        {
            sbyte[] var0 = new sbyte[]{0};
            System.Console.WriteLine(var0[0]);
        }

        return ref s_9;
    }
}
