using CSharp100Knocks.Problems03_method;

namespace CSharp100Knocks
{
    class Problem
    {
        static void Main(string[] args)
        {
            bool ans = Prob38.Squareroot(5.0, out double result);
            if (ans)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}