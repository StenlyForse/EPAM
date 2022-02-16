using System.Text.Json;
using M09;

JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
options.Converters.Add(new DateOnlyConverter());

var students = StudentDeserializator.Deserialize("Students.json");

var lst = DataRetriever.Retrieve(students, "-name Ivan -sort mark desc");
foreach (var srt in lst)
    Console.WriteLine($"Name: {srt.Name}\t Test: {srt.Test}\t Date: {srt.Date}\t Mark: {srt.Mark}");