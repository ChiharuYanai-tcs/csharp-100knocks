namespace CSharp100Knocks.Problems04_class
{
    public sealed class Prob62
    {
        private readonly string _serviceName;

        public Prob62(string serviceName)
        {
            _serviceName = serviceName;
        }

        public string Execute() => $"{_serviceName} is done.";
    }
}