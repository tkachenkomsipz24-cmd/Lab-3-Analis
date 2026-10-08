using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    { 
        List<string> log = new List<string>();

        log.Add("Запис 1: Запуск системи");
        log.Add("Запис 2: Помилка з'єднання з сервером");
        log.Add("Запис 3: Користувач увійшов у систему");
        log.Add("Запис 4: Оновлення конфігурації");

        Console.WriteLine("=== Журнал у зворотному порядку ===");
        for (int i = log.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(log[i]);
        }
    }
}
