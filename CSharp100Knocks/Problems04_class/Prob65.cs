namespace CSharp100Knocks.Problems04_class
{
    public class Person
    {
        private string _name = string.Empty;
        private int _age;

        public static int InstanceCount {get; private set;}

        public System.Guid Id {get; init;} = System.Guid.Empty;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new System.ArgumentException("Name is empty", nameof(Name));
                _name = value.Trim();
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 150)
                {
                    throw new System.ArgumentOutOfRangeException(nameof(Age), "Age is 1 ~ 149");
                }
                _age = value;
            }
        }

        public bool IsAdult => Age >= 18;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            InstanceCount++;
        }

        public override string ToString()
            => $"Person(Name={Name}, Age={Age}, IsAdult={IsAdult}, Id={Id})";
    }
}