// Generated by Fuzzlyn v1.1 on 2018-09-10 22:15:20
// Seed: 7732399674853592982
// Reduced from 263.7 KiB to 0.6 KiB in 00:04:29
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public byte F0;
    public ulong F4;
    public ushort F5;
    public S0(byte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_6;
    public static void Main()
    {
        var vr5 = new S0(1);
        short vr9 = default(short);
        var vr6 = (ulong)vr9;
        var vr7 = new S0(0);
        M18(vr5, M54(vr6, vr7));
    }

    static void M18(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }

    static ref S0 M54(ulong arg0, S0 arg9)
    {
        System.Console.WriteLine(arg0);
        return ref s_6;
    }
}
