namespace CSharp100Knocks.Problems03_method
{
    public class Prob50
    {
        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        public static void TrySwapByValue(int a, int b)
        {
            (a, b) = (b, a);
        }
    }
}