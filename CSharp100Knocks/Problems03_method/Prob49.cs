namespace CSharp100Knocks.Problems03_method
{
    public class Prob49
    {
        public static Func<int> Solve()
        {
            int count = 0;
            return () =>
            {
                count++;
                return count;
            };
        }
    }
}