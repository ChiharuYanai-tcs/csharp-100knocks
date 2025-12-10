namespace CSharp100Knocks.Problems04_class
{
    public class Prob63
    {
        private static int _instanceCount;
        public Prob63()
        {
            _instanceCount++;
        }

        public static int InstanceCount => _instanceCount;
    }
}