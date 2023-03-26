// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Text.RegularExpressions;

var csvPath = @"C:\Users\d.vorobyev1\section_leads.csv";
var csv2Path = @"C:\Users\d.vorobyev1\sec_lead.csv";
var txtPath = @"C:\Users\d.vorobyev1\section_leads.txt";
Regex DigitsRegex = new("\\D+");

var leadsStr = File.ReadAllText(csv2Path);
leadsStr = leadsStr
    .Trim();
var leads = leadsStr
    .Split('\n')
    .Select(x => DigitsRegex.Replace(x, string.Empty))
    .Where(x => x.Length > 0)
    .Select(int.Parse)
    .ToArray();

var pairsStr = File.ReadAllText(csvPath);
pairsStr = pairsStr
    .Trim();
var numbers = pairsStr
    .Split(';')
    .Select(x => DigitsRegex.Replace(x, string.Empty))
    .Where(x => x.Length > 0)
    .Select(int.Parse)
    .ToArray();
var pairs = new List<int[]>();
for (int i = 0; i < numbers.Length-1; i++)
{
    pairs.Add(new []{ numbers[i], numbers[++i]});
}

foreach (var pair in pairs)
{
    if (!leads.Contains(pair[0]))
    {
        Console.WriteLine(pair[0]);
    }
}

// var sb = new StringBuilder(
//     "INSERT INTO interviewers.\"SectionLeadsInterviewSections\"\n(\"SectionLeadMasterId\", \"InterviewSectionId\")\nvalues");
// foreach (var pair in pairs)
// {
//     sb.AppendFormat("({0},{1}),\n", pair[0], pair[1]);
// }
//
// sb.Remove(sb.Length - 2, 2);
// sb.Append(';');
//
// File.WriteAllText(txtPath, sb.ToString());
