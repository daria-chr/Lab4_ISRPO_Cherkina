// See https://aka.ms/new-console-template for more information
Console.WriteLine("Здравствуйте. Добро пожаловать");
string fio="Черкина Дарья Алексеевна";
string group="ИСП-231";
Console.WriteLine($"ФИО: {fio}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Дата: {DateTime.Now}");
int choice;
do
{
    Console.WriteLine("Меню:");
    Console.WriteLine("1 — Показать ФИО");
    Console.WriteLine("2 — Показать группу");
    Console.WriteLine("3 — Показать дату");
    Console.WriteLine("4 — Выход");
    Console.WriteLine("Выберите пункт меню: ");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
    case 1:
    Console.WriteLine($"ФИО: {fio}");
    break;
    case 2:
    Console.WriteLine($"Группа: {group}");
    break;
    case 3:
    Console.WriteLine($"Дата: {DateTime.Now}");
    break;
    case 4:
    Console.WriteLine("Программа завершает работу");
    break;
    default:
    Console.WriteLine("Неверный выбор");
    break;
    }
} while (choice != 4);

