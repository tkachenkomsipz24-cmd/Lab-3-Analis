using System;

class Program
{
    static void Main()
    {
        string[] eventStream = new string[] 
        { 
            "Подія 1", "Подія 2", "Подія 3", "Подія 4", "Подія 5", "Подія 6", "Подія 7" 
        };

        int N = 5;
        string[] buffer = new string[N];
        int writeIndex = 0;
        int totalCount = 0;

        foreach (var ev in eventStream)
        {
            buffer[writeIndex] = ev;
            writeIndex = (writeIndex + 1) % N;
            totalCount++;
        }

        int itemsToRead = Math.Min(totalCount, N);
        int readIndex = (totalCount < N) ? 0 : writeIndex;

        Console.WriteLine($"=== Останні {N} подій ===");
        for (int i = 0; i < itemsToRead; i++)
        {
            int index = (readIndex + i) % N;
            Console.WriteLine(buffer[index]);
        }
    }
} 
