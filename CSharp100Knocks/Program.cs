using System.Security.Cryptography.X509Certificates;
using CSharp100Knocks.Problems04_class;
using Microsoft.VisualBasic;

namespace CSharp100Knocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hoge: {Prob64.Hoge}");
            var p64 = new Prob64(100);
            Console.WriteLine($"Foge(p64): {p64.Foge}"); 
        }
    }
    
    
}