// Generated by Fuzzlyn on 2018-06-23 23:04:10
// Seed: 3353778485770483665
// Reduced from 83.9 KiB to 0.2 KiB
// Debug: Outputs 44036
// Release: Outputs -21500
public class Program
{
    static short s_8 = -21500;
    public static void Main()
    {
        char vr2 = (char)(0U ^ s_8);
        System.Console.WriteLine((int)vr2);
    }
}
