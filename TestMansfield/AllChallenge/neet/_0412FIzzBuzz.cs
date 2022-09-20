public class _0412FIzzBuzz {
    public IList<string> FizzBuzz(int n) {
        List<string> x = new List<string>();

        for (int i = 1; i <= n; i++)
        {

            if (i%3 == 0 && i%5 ==0)
            {
                x.Add("FizzBuzz");
                continue;
            }
            
            if (i%3 == 0 && i%5 !=0)
            {
                x.Add("Fizz");
                continue;
            }
            if (i%3 != 0 && i%5 ==0)
            {
                x.Add("Buzz");
                continue;
            } 

            x.Add(i.ToString());
        }

        return x;
    }
}