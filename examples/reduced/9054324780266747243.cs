// Generated by Fuzzlyn on 2018-07-22 22:22:26
// Seed: 9054324780266747243
// Reduced from 14.9 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static char s_1;
    public static void Main()
    {
        var vr5 = new short[][, ]{new short[, ]{{0}}};
        s_1 = (char)(vr5[0][0, 0] & 0);
        short vr8 = vr5[0][0, 0];
    }
}
