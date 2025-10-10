namespace CSharp100Knocks.Problems02_array
{
    public class Prob22
    {
        public static void Solve()
        {
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                num[i] = i;
            }
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}