namespace CSharp100Knocks.Problems02_array
{
    public class Prob29
    {
        public static void Solve()
        {
            List<int> num = new List<int>() { 4, 10, 1, 5, -2, 9 };
            if (num.Contains(3))
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }
    }
}