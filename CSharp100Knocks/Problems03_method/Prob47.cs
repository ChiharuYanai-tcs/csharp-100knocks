namespace CSharp100Knocks.Problems03_method
{
    public class Prob47
    {
        public static void Solve()
        {
            Action<string> output = message => Console.WriteLine(message);
            output("hogehoge");

            Action<string, int> printInfo = (name, age) =>
            {
                Console.WriteLine($"Name is {name}.");
                Console.WriteLine($"Age is {age}.");
            };
            printInfo("Tom", 17);
        }
    }
}