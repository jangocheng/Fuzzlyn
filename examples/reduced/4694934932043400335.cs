// Generated by Fuzzlyn v1.1 on 2018-08-13 02:50:46
// Seed: 4694934932043400335
// Reduced from 14.6 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        M3();
    }

    static int M3()
    {
        uint[][, ] var0 = new uint[][, ]{new uint[, ]{{0}}};
        return (int)((0 & var0[0][0, 0]) ^ var0[0][0, 0]);
    }
}
