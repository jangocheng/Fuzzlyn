// Generated by Fuzzlyn on 2018-07-22 00:06:13
// Seed: 18340721169828721191
// Reduced from 252.9 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    static sbyte s_60;
    public static void Main()
    {
        short[][, ] vr11 = new short[][, ]{new short[, ]{{0}}};
        M3(vr11, s_60);
    }

    static int M3(short[][, ] arg0, sbyte arg1)
    {
        sbyte var0 = (sbyte)(0 & arg0[0][0, 0]);
        bool vr4 = true;
        System.Console.WriteLine(vr4);
        arg0[0][0, 0] = 0;
        arg1 = var0;
        System.Console.WriteLine(arg1);
        return 0;
    }
}
