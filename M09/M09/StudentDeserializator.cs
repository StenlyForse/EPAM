namespace M09
{
    using System.Text.Json;

    internal class StudentDeserializator
    {
        public static List<Student> Deserialize(string filename)
        {
            JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            options.Converters.Add(new DateOnlyConverter());

            string filepath = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename));

            var students = JsonSerializer.Deserialize<List<Student>>(filepath, options)!;
            return students;
        }
    }
}