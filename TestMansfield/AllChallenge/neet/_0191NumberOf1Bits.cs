public class _0191NumberOf1Bits {
    public int HammingWeight(uint n) {
 
        string xxx = Convert.ToString(n, 2);
        int x = 0;
        

        for (int i = 0; i < xxx.Length ; i++){
            if (xxx[i] == '1') x++;
        }

        return x;
    }
}