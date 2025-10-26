namespace CSharp100Knocks.Problems03_method
{
    public class Prob38
    {
        public static bool Squareroot(double x, out double y)
        {
            if (x < 0)
            {
                y = 0;
                return false;
            }

            y = Math.Sqrt(x);
            return true;
        }
    }
}