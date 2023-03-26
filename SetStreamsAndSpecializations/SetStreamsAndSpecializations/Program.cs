// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Text.Json;
using SetStreamsAndSpecializations;

var csvPath = @"C:\Users\d.vorobyev1\offersReport.csv";
var downloadsPath = @"C:\Users\d.vorobyev1\Downloads";
var streamsPath = downloadsPath + @"\streams.json";
var specializationsPath = downloadsPath + @"\specializations.json";


var streamsStr = File.ReadAllText(streamsPath);
var streams = JsonSerializer.Deserialize<StreamModel[]>(streamsStr);
var specializationsStr = File.ReadAllText(specializationsPath);
var specializations = JsonSerializer.Deserialize<SpecializationModel[]>(specializationsStr);

var reportStr = new StringBuilder(File.ReadAllText(csvPath));

foreach (var stream in streams!)
{
    reportStr.Replace(stream.Id.ToString(), stream.Name);
}

foreach (var specialization in specializations!)
{
    reportStr.Replace(specialization.Id.ToString(), specialization.Name);
}

File.WriteAllText(csvPath, reportStr.ToString());
