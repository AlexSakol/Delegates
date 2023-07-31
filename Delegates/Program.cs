using Delegates;

Cat cat1 = new Cat();
Console.WriteLine(cat1);
cat1.AddMessage(Meow);
cat1.AddMessage(() => Console.WriteLine($"{cat1.Name} не умеет мурлыкать")); // анонимный метод через лямбду
Console.Write($"{cat1.Name} говорит ");
cat1.RunMessage();
Console.WriteLine();

Cat tom = new("Том", 6000);
Console.WriteLine(tom);
tom.AddMessage(Mur);
tom.AddMessage(delegate () { Console.WriteLine($"{tom.Name} только мурлыкает"); }); // анонимный метод через делегат
Console.Write($"{tom.Name} говорит ");
tom.RunMessage();
Console.WriteLine();
Console.WriteLine();

Cat angela = new("Анжелла", 3700);
Console.WriteLine(angela);
angela.AddMessage(Meow);
angela.AddMessage(Mur);
Console.Write($"{angela.Name} говорит ");
angela.RunMessage();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Сравним делегаты Тома и Анжелы");
if (tom.Compare(angela)) Console.WriteLine("Делегаты равны");
else Console.WriteLine("Делегаты не равны");

TooFat fat = new();

tom.OnFeed += fat.Print;


Console.WriteLine("Кормим Тома и Анжелу");
tom.AddParametr(feed1);
tom.Feed(300);
angela.AddParametr(feed2);
angela.Feed(250);
Console.WriteLine($"Вес Тома {tom.Weight}");
Console.WriteLine($"Вес Анжелы {angela.Weight}");
Console.WriteLine();

// методы для подстановки в делегаты без параметров
static void Meow() => Console.Write("Мяу! ");

static void Mur() => Console.Write("Мур! ");

// методы для подставновки в делегаты с параметром

static double feed1(double weight_of_feed) => weight_of_feed * 0.25;

static double feed2(double weight_of_feed) => weight_of_feed * 0.18;

