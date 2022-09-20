public class _0190ReverseBits {
    public uint reverseBits(uint n) {

        //Console.WriteLine(n);
        //Console.WriteLine(Convert.ToString(n, 2));

        string xxx = Convert.ToString(n, 2).PadLeft(32, '0');

        List<char> r = new List<char>();

        for (int i = xxx.Length -1; i >=0; i--)        {
            r.Add(xxx[i]);
        }

        //Console.WriteLine(String.Join("", r.ToArray()));

        //return 0;

        return Convert.ToUInt32(String.Join("", r.ToArray()),2);
    }
}