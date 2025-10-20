namespace CSharp100Knocks.Problems02_array
{
    public class Prob30
    {
        public static void Solve()
        {
            var sources = new Dictionary<string, int>
            {
                {"Mutate", 10},
                {"Crossover", 20},
                {"Drift", 3}
            };

            if (sources.TryGetValue("Mutate", out int source))
            {
                Console.WriteLine(source);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}