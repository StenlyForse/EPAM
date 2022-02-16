namespace M09
{
    using System.Text.Json.Serialization;

    public class Student
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("test")]
        public string? Test { get; set; }
        [JsonPropertyName("date")]
        public DateOnly Date { get; set; }
        [JsonPropertyName("mark")]
        public int Mark { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Student &&
                Mark == ((Student)obj).Mark &&
                Date == ((Student)obj).Date &&
                Test == ((Student)obj).Test &&
                Name == ((Student)obj).Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Test, Mark, Date);
        }
    }
}