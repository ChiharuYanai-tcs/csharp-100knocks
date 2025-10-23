namespace CSharp100Knocks.Problems02_array
{
    public class Prob34
    {
        public static void Solve()
        {
            var num_list = new List<int> { 1, 2, 3, 4, 5 };
            int[] num_array = num_list.ToArray();
            Console.WriteLine($"num_list: {num_list.GetType()}");
            Console.WriteLine($"num_array: {num_array.GetType()}");

            foreach (var i in num_list) Console.Write(i + " ");
            Console.WriteLine();
            foreach (var i in num_array) Console.Write(i + " ");
        }
    }
}