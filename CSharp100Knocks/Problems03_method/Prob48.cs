namespace CSharp100Knocks.Problems03_method
{
    public class Prob48
    {
        public static void Solve()
        {
            var list = new List<int> { 4, 7, -1, 9, 13 , -6};
            Predicate<int> even = n => n % 2 == 0;
            Console.WriteLine(string.Join(",", list.FindAll(even)));
        }
    }
}