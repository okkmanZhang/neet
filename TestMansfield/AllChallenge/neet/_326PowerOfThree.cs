public class _326PowerOfThree {
    public bool IsPowerOfThree(int n) {

        if (n ==1) return true;
        if (n < 3) return false;
        if (n == 3) return true;

        if (n % 3 > 0) return false;

        return IsPowerOfThree(n/3);   
    }
}