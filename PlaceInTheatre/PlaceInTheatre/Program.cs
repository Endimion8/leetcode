// Программист решил пойти в театр. Но он хочет сесть
// как можно дальше от других людей, чтобы не заразиться covid. 
//     Поэтому он хочет написать функцию, которая найдет
// максимальное расстояние, на которое можно сесть от других зрителей в одном ряду.
//
//     Дан массив из 0 и 1 описывающий посадку зрителей в ряду.
// 0 - место свободно, 1 - место занято другим зрителем.
//     Вывести максимальное расстояние, на котором можно сесть от других зрителей.
//     Гарантируется, что есть 0 и 1.
//
//     Пример: [1,0,0,0,1] ->  2
//     Пример: [0,1,1,1,1] ->  1
//     Пример: [1,0,0,1,1] ->  1
//     Пример: [1,0,1,0,1] ->  1

// https://wiki2.tcsbank.ru/pages/viewpage.action?pageId=1311724464

var row1 = new[] {1,0,0,0,1};
var row2 = new[] {0,0,1,0,0};
var row3 = new[] {0,0,0,1,1};
var row4 = new[] {0,0,1,1,1};
var row5 = new[] {1,0,0,1,1};
var row6 = new[] {0,1,1,1,1};
var row7 = new[] {1,0,1,0,1};
var row8 = new[] {1,0,1,0,0,1,0,0,0,1};
var row9= new[] {1, 0, 0, 0, 0, 0};
var row10= new[] {0, 0, 0, 0, 0, 1};
var row11= new[] {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0};

int GetMaxDistance(int[] row)
{
    var maxDistance = 0;
    var freeCount = 0;
    var leftServed = false;
    for (int i = 0; i < row.Length; i++)
    {
        if (row[i] == 1 || i == row.Length - 1)
        {
            if (row[i] != 1) freeCount++;
            var rightServed = row[i] == 1;
            var distance = 0;
            if (freeCount == 1) distance = 1;
            if (freeCount > 1)
            {
                distance = freeCount + 1;
                if (leftServed) distance--;
                if (rightServed) distance--;
            }
            maxDistance = Math.Max(maxDistance, distance);
            freeCount = 0;
            leftServed = true;
            continue;
        }

        freeCount++;
    }

    return maxDistance;
};

Console.WriteLine(GetMaxDistance(row1));
Console.WriteLine(GetMaxDistance(row2));
Console.WriteLine(GetMaxDistance(row3));
Console.WriteLine(GetMaxDistance(row4));
Console.WriteLine(GetMaxDistance(row5));
Console.WriteLine(GetMaxDistance(row6));
Console.WriteLine(GetMaxDistance(row7));
Console.WriteLine(GetMaxDistance(row8));
Console.WriteLine(GetMaxDistance(row9));
Console.WriteLine(GetMaxDistance(row10));
Console.WriteLine(GetMaxDistance(row11));