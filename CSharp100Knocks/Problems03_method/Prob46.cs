namespace CSharp100Knocks.Problems03_method
{
    public class Prob46
    {
        public static void Solve()
        {
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(5, 8));

            Func<int, int> square = x => x * x;
            Console.WriteLine(square(12));

            Func<int> getrand = () => new Random().Next(1, 99);
            Console.WriteLine(getrand());
        }
    }
}