// Generated by Fuzzlyn on 2018-06-24 04:37:19
// Seed: 13400355486130066949
// Reduced from 51.8 KiB to 0.2 KiB
// Debug: Outputs 32769
// Release: Outputs -32767
public class Program
{
    public static void Main()
    {
        var vr26 = new short[]{-32767};
        char vr28 = (char)(1L | vr26[0]);
        System.Console.WriteLine((int)vr28);
    }
}
