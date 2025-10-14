namespace CSharp100Knocks.Problems02_array
{
    public class Prob26
    {
        public static void Solve()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(11);
            stack.Push(-4);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}