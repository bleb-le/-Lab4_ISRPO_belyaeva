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