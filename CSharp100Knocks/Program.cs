using System.Security.Cryptography.X509Certificates;
using CSharp100Knocks.Problems04_class;
using Microsoft.VisualBasic;

namespace CSharp100Knocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problem();
        }
    }
    
    class Problem
    {
        // private Prob58 car;  // こっちでも Car の override 版が動く
        private Car car;
        
        public Problem()
        {
            car = new Car("Tokyo");
            car.Accelerate();
            car.ShowInfo();
        }
    }
}