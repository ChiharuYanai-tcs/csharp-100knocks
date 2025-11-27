namespace CSharp100Knocks.Problems04_class
{
    abstract class Animal
    {
        public string Name {get;}
        protected Animal(string name)
        {
            Name = name;
        }

        public abstract void Speak();
        public virtual void Move()
        {
            Console.WriteLine($"{Name} is walking.");
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base (name) { }
        public override void Speak()
        {
            Console.WriteLine($"{Name}: Won");
        }
    }

    class Bird : Animal
    {
        public Bird(string name) : base(name) { }
        public override void Speak()
        {
            Console.WriteLine($"{Name}: ChicChi");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }
}