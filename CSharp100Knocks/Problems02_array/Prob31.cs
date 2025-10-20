namespace CSharp100Knocks.Problems02_array
{
    public class Prob31
    {
        public static void Solve()
        {
            int[] num = { 4, 20, -5, 9, 11, 1 , 4};
            var uniNum = new HashSet<int>(num);

            foreach (var n in uniNum)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("uniNum.Add(9): " + uniNum.Add(9));
            Console.WriteLine("uniNum.Add(13): " + uniNum.Add(13));
        }
    }
}