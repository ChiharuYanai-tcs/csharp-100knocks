namespace CSharp100Knocks.Problems02_array
{
    public class Prob23
    {
        public static void Solve()
        {
            List<int> num = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                num.Add(i + 1);
            }

            double mean = 0.0;
            foreach (int item in num)
            {
                mean += item;
            }
            mean /= num.Count;
            Console.WriteLine(mean);
        }
    }
}