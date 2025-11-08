using CSharp100Knocks.Problems03_method;

namespace CSharp100Knocks
{
    class Problem
    {
        static void Main(string[] args)
        {
            int x = 3, y = 8;
            Prob50.TrySwapByValue(x, y);
            Console.WriteLine($"(x, y) = ({x}, {y})");

            Prob50.Swap(ref x, ref y);
            Console.WriteLine($"(x, y) = ({x}, {y})");
        }
    }
}