// Есть прачечная с N стиральными машинами.
// На входе в прачечную в очереди стоят M человек для того, чтобы постирать свои вещи.
// Про каждого человека известно, сколько времени он будет стирать свои вещи.
// Каждый человек использует первую освободившуюся машину.
// Сколько времени займёт стирка всех вещей?

// https://wiki2.tcsbank.ru/pages/viewpage.action?pageId=698959352

// Примеры:
// getTime([1, 2, 3], 1) → 6
// getTime([1, 2, 3], 2) → 4
// getTime([1, 2, 3], 3) → 3
// getTime([3, 2, 1], 2) → 3

int getTime(IReadOnlyCollection<int> times, int machinesCount)
{
    var queue = new Queue<int>(times);
    var machines = new int[machinesCount];
    var counter = 0;
    
    while (queue.Any() || machines.Any(x => x > 0))
    {
        // назначаем клиентов свободным машинам
        for (int i = 0; i < machines.Length; i++)
        {
            if (machines[i] > 0)
            {
                continue;
            }

            if (queue.TryDequeue(out var time))
            {
                machines[i] = time;
            }
        }
        
        // вычитаем один такт времени
        for (int i = 0; i < machines.Length; i++)
        {
            if (machines[i] == 0)
            {
                continue;
            }

            machines[i]--;
        }

        counter++;
    }

    return counter;
}

Console.WriteLine(getTime(new []{1, 2, 3}, 1)); // 6
Console.WriteLine(getTime(new []{1, 2, 3}, 2)); // 4
Console.WriteLine(getTime(new []{1, 2, 3}, 3)); // 3
Console.WriteLine(getTime(new []{3, 2, 1}, 2)); // 3