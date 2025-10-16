namespace CSharp100Knocks.Problems02_array
{
    public class Prob28
    {
        public static void Solve()
        {
            int[] num = { 4, -1, 1, 10, 8 };
            Array.Sort(num);
            Console.WriteLine(string.Join(", ", num));
        }
    }
}