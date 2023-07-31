
namespace Delegates
{
    internal class Cat
    {
        private string? name;
        private double? weight;

        private Message? message;
        private AddParam? parametr;

        private event Action<Cat> _onfeed;

        public event Action<Cat> OnFeed
        {
            add { _onfeed += value; }
            remove { _onfeed -= value; }
        }

        public Cat() : this(null, null)
        {
        }

        public Cat(string? name, double? weight)
        {
            Name = name;
            Weight = weight;
        }

        public string? Name
        {
            get => name;
            set
            {
                if (value == null) name = "noname";
                else name = value;
            }
        }
        public double? Weight
        {
            get => weight;
            set
            {
                if (value <= 0 | value == null) weight = 3000;
                else weight = value;
            }
        }

        public void AddMessage(Message m) => message += m;
        public void RunMessage() => message?.Invoke();

        public void AddParametr(AddParam p) => parametr += p;

        public void Feed(double eating)
        {
            if (parametr != null) Weight += parametr(eating);
            if (weight > 5000) _onfeed?.Invoke(this);
        }

        public bool Compare(Cat cat) => this.message == cat.message;
        public override string? ToString() => $"Кот {Name} весит {Weight} г.";

    }
}

delegate void Message();
delegate double AddParam(double w);  


