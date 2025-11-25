namespace CSharp100Knocks.Problems04_class
{
    public class Prob58
    {
        public int Speed {get; protected set;} = 0;

        public void Accelerate()
        {
            this.Speed += 10;
            Console.WriteLine($"Accelerate, {this.Speed}.");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"INFO: {this.Speed} km/h.");
        }
    }

    public class Car : Prob58
    {
        public string LicensePlate {get; set;}
        public Car(string licensePlate)
        {
            this.LicensePlate = licensePlate;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Car INFO: {this.LicensePlate}, {this.Speed} km/h.");
        }
    }
}