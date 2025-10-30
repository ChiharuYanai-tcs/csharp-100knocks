namespace CSharp100Knocks.Problems03_method
{
    public class Prob43
    {
        public static int Sum_n(params int[] num)
        {
            int total = 0;
            foreach (int i in num)
            {
                total += i;
            }
            return total;
        }
    }
}