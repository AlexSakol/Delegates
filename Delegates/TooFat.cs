//Event for cat Tom

namespace Delegates
{
    internal class TooFat
    {
        public void Print(Cat cat) => Console.WriteLine($"{cat.Name} слишком толстый");
    }

}

