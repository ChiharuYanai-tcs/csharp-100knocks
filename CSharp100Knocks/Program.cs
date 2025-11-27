using System.Security.Cryptography.X509Certificates;
using CSharp100Knocks.Problems04_class;
using Microsoft.VisualBasic;

namespace CSharp100Knocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new List<Animal>
            {
                new Dog("Pochi"),
                new Bird("Pico")
            };

            foreach (var a in animal)
            {
                a.Speak();
                a.Move();
            }
        }
    }
    
    
}