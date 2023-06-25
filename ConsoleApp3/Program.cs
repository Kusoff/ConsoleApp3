using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите название месяца: ");
        string month = Console.ReadLine();

        int daysInMonth;

        switch (month.ToLower())
        {
            case "январь":
            case "март":
            case "май":
            case "июль":
            case "август":
            case "октябрь":
            case "декабрь":
                daysInMonth = 31;
                break;
            case "февраль":
                daysInMonth = 28;
                break;
            case "апрель":
            case "июнь":
            case "сентябрь":
            case "ноябрь":
                daysInMonth = 30;
                break;
            default:
                Console.WriteLine("Некорректное название месяца.");
                Console.ReadKey();
                return;
        }

        Console.WriteLine($"Количество дней в {month}: {daysInMonth}");
        Console.ReadKey();
    }
}
