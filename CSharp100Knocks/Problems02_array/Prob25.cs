namespace CSharp100Knocks.Problems02_array
{
    public class Prob25
    {
        public static void Solve()
        {
            Queue<int> num = new Queue<int>();
            num.Enqueue(4);
            num.Enqueue(9);
            num.Enqueue(-2);

            int i = num.Dequeue();
            Console.WriteLine(i);
        }
    }
}