using System.Security.Cryptography.X509Certificates;
using CSharp100Knocks.Problems04_class;
using Microsoft.VisualBasic;

namespace CSharp100Knocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var alice = new Person("Alice", 30) {Id = System.Guid.NewGuid()};
            Console.WriteLine(alice);
        }
    }
    
    
}