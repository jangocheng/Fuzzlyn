// Generated by Fuzzlyn on 2018-06-26 18:27:41
// Seed: 17784597591231425621
// Reduced from 213.4 KiB to 0.2 KiB
// Debug: Outputs 0
// Release: Outputs 255
public class Program
{
    public static void Main()
    {
        byte[] vr0 = new byte[]{255};
        byte vr1 = vr0[0];
        vr1 >>= 1998841516;
        System.Console.WriteLine(vr1);
    }
}
