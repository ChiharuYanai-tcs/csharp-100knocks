namespace CSharp100Knocks.Problems02_array
{
    public class Prob24
    {
        public static void Solve()
        {
            Dictionary<string, string> en_jp = new Dictionary<string, string>();
            en_jp.Add("Apple", "リンゴ");
            Console.WriteLine(en_jp["Apple"]);
        }
    }
}