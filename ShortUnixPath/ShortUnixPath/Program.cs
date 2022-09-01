// Необходимо написать функцию, которая получает строку с абсолютным UNIX путем
// и возвращает укороченную версию, удалив все ненужное
//
// Input: "/foo/../test/../test/../foo//bar/./baz"
// Output: "/foo/bar/baz"
// Пояснения
//
//     .. - возврат на директорию выше
//     . - означает текущую директорию, по сути просто мусор
//     /// - просто мусор
//     нельзя выйти выше корневой директории

// https://wiki2.tcsbank.ru/pages/viewpage.action?pageId=1415519426

string ShortenPath(string path)
{
    var segments = path.Split('/').Where(x => x.Length > 0 && x != ".");
    var stack = new Stack<string>();
    foreach (var segment in segments)
    {
        if (segment == "..")
        {
            stack.TryPop(out _);
        }
        else
        {
            stack.Push(segment);
        }
    }

    return "/" + string.Join('/', stack.ToArray().Reverse());
}


Console.WriteLine(ShortenPath("/foo/../test/../test/../foo//bar/./baz"));
Console.WriteLine(ShortenPath("///////"));
Console.WriteLine(ShortenPath("/../../../"));