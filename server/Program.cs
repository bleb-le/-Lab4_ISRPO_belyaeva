string fio = "belyaeva";
string group = "ИСП-241";

Console.WriteLine("Добро пожаловать!");
Console.WriteLine($"ФИО: {fio}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Текущая дата и время: {DateTime.Now}");
Console.WriteLine("\nМеню:");
Console.WriteLine("1 - Показать ФИО");
Console.WriteLine("2 - Показать группу");
Console.WriteLine("3 - Показать дату");
Console.WriteLine("4 - Выход");
Console.Write("Выберите пункт: ");
string? input = Console.ReadLine();
int choice = int.Parse(input!);

if (choice == 1)
    Console.WriteLine($"ФИО: {fio}");
else if (choice == 2)
    Console.WriteLine($"Группа: {group}");
else if (choice == 3)
    Console.WriteLine($"Дата: {DateTime.Now}");
else if (choice == 4)
    Console.WriteLine("Выход из программы.");
else
    Console.WriteLine("Неверный пункт меню!");