public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return CollatzFilter.collatz(XORFilter.XOR21s(xs));
    }

}
