namespace CSharp100Knocks.Problems02_array
{
    public class Prob27
    {
        public static void Solve()
        {
            int[] num = { 3, 6, 9 };
            Array.Reverse(num);
            
            foreach (int i in num)
            {
                Console.Write(i + " ");
            }
        }
    }
}