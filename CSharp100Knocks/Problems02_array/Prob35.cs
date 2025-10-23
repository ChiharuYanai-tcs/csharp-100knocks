namespace CSharp100Knocks.Problems02_array
{
    public class Prob35
    {
        public static void Solve()
        {
            int[] num_array = { 1, 2, 3, 4, 5 };
            List<int> num_list = num_array.ToList();
            Console.WriteLine($"num_list: {num_list.GetType()}");
            Console.WriteLine($"num_array: {num_array.GetType()}");

            foreach (var i in num_list) Console.Write(i + " ");
            Console.WriteLine();
            foreach (var i in num_array) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}