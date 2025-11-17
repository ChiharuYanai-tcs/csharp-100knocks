namespace CSharp100Knocks.Problems04_class
{
    public class Prob55
    {
        public double R {get;}
        public double Area => Math.PI * R * R;
        public Prob55(double r) => R = r;
    }
}