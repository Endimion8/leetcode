// See https://aka.ms/new-console-template for more information

using ClosedXML.Excel;
using Newtonsoft.Json;
using KafkaMessageConverter;

Console.WriteLine("Hello, World!");
var eventsDictionary = new Dictionary<int, SecurityFormChangedEvent>();

using (StreamReader sr = new StreamReader("C:/Users/d.vorobyev1/kafka_messages.csv"))
{
    string currentLine;
    // currentLine will be null when the StreamReader reaches the end of file
    while((currentLine = sr.ReadLine()) != null)
    {
        currentLine = currentLine.Replace("\"", "");
        var arr = currentLine.Split(',');
        var offset = int.Parse(arr[0]);
        // From string to byte array
        var buffer = Helper.StringToByteArray(arr[1]);

        // From byte array to string
        var json = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);
        var @event = JsonConvert.DeserializeObject<SecurityFormChangedEvent>(json);
        eventsDictionary.Add(offset, @event);
    }

    var wb = new XLWorkbook();
    var ws = wb.Worksheets.Add("SecurityChecks");
    ws.Cell(1, 1).Value = "Offset";
    ws.Cell(1, 2).Value = "CandidateId";
    ws.Cell(1, 3).Value = "Id";
    ws.Cell(1, 4).Value = "SecurityFormId";
    ws.Cell(1, 5).Value = "SecurityFormStatus";
    ws.Cell(1, 6).Value = "Time";
    ws.Cell(1, 7).Value = "Comment";
    ws.Cell(1, 8).Value = "SecurityFormStatusId";
    ws.Cell(2, 1).Value = eventsDictionary.Keys.AsEnumerable();
    ws.Cell(2, 3).Value = eventsDictionary.Values.AsEnumerable();
    ws.Cell(2, 8).Value = eventsDictionary.Values.Select(x => (int) x.SecurityFormStatus);
    ws.Columns().AdjustToContents();

    wb.SaveAs("KafkaMessages.xlsx");
    
}