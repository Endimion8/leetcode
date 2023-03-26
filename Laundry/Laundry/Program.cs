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

// O(MN)

int getTime(IReadOnlyCollection<int> clientTimes, int machinesCount)
{
    var machines = new int[machinesCount];

    foreach (var time in clientTimes)
    {
        // находим машину с минимальным временем
        var minMachineIndex = findMinMachineIndex(machines);

        // добавляем к нему время следующего клиента
        machines[minMachineIndex] += time;
    }

    // в результате получаем массив с полным временем загруженности машин.
    // выбираем максимальное - это время, за которое вся очередь полностью постирается
    return machines.Max();
}

int findMinMachineIndex(int[] machines)
{
    var min = machines.Min();
    return Array.IndexOf(machines, min);
}

Console.WriteLine(getTime(new []{1, 2, 3}, 1)); // 6
Console.WriteLine(getTime(new []{1, 2, 3}, 2)); // 4
Console.WriteLine(getTime(new []{1, 2, 3}, 3)); // 3
Console.WriteLine(getTime(new []{3, 2, 1}, 2)); // 3