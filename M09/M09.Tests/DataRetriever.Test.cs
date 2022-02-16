namespace M09.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using NUnit.Framework;

    [TestFixture]
    internal class DataRetriever
    {
        [Test]
        public void DataRetriever_NormalInput_Test()
        {
            // Assume
            List<Student> expected = new List<Student>();
            expected.Add(new Student() { Name = "Ivan", Test = "Math", Mark = 4, Date = DateOnly.Parse("21.01.1999") });
            JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            options.Converters.Add(new DateOnlyConverter());

            var students = Student.Deserialize("Students.json");
            string token = "-name Ivan -minmark 4 -maxmark 4";

            // Act
            var actual = M09.DataRetriever.Retrieve(students, token);
            var compare = new HashSet<Student>(expected).SetEquals(actual);

            // Assert
            Assert.That(compare, Is.EqualTo(true));
        }

        [Test]
        public void DataRetriever_NotEqualsParams_Test()
        {
            // Assume
            List<Student> expected = new List<Student>();
            expected.Add(new Student() { Name = "Alex", Test = "Sports", Mark = 4, Date = DateOnly.Parse("21.01.1999") });
            JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            options.Converters.Add(new DateOnlyConverter());

            var students = Student.Deserialize("Students.json");
            string token = "-name Ivan -minmark 4 -maxmark 4";

            // Act
            var actual = M09.DataRetriever.Retrieve(students, token);
            var compare = new HashSet<Student>(expected).SetEquals(actual);

            // Assert
            Assert.That(compare, Is.EqualTo(false));
        }

        [Test]
        public void DataRetriever_FewInstancesInput_Sorted_Name_Asc_Test()
        {
            // Assume
            List<Student> expected = new List<Student>();
            expected.Add(new Student() { Name = "Ivan", Test = "Math", Mark = 4, Date = DateOnly.Parse("21.01.1999") });
            expected.Add(new Student() { Name = "Ivan Petrov", Test = "Geography", Mark = 2, Date = DateOnly.Parse("30.09.2020") });
            expected.Add(new Student() { Name = "Ivan Kurlin", Test = "Math", Mark = 5, Date = DateOnly.Parse("30.09.2020") });
            JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            options.Converters.Add(new DateOnlyConverter());

            var students = Student.Deserialize("Students.json");
            string token = "-name Ivan -sort name asc";

            // Act
            var actual = M09.DataRetriever.Retrieve(students, token);
            var compare = new HashSet<Student>(expected).SetEquals(actual);

            // Assert
            Assert.That(compare, Is.EqualTo(true));
        }

        [Test]
        public void DataRetriever_NotExistingParam_Inputed_Test()
        {
            // Assume
            List<Student> expected = new List<Student>();
            JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            options.Converters.Add(new DateOnlyConverter());

            var students = Student.Deserialize("Students.json");
            string token = "-name Vasya";

            // Act
            var actual = M09.DataRetriever.Retrieve(students, token);
            var compare = new HashSet<Student>(expected).SetEquals(actual);

            // Assert
            Assert.That(compare, Is.EqualTo(true));
        }

        [Test]
        public void DataRetriever_NullToken_Inputed_Test()
        {
            // Assume
            List<Student> expected = new List<Student>();
            JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            options.Converters.Add(new DateOnlyConverter());

            var students = Student.Deserialize("Students.json");
            string? token = null;

            // Act & Assert
            Assert.That(() => M09.DataRetriever.Retrieve(students, token!), Throws.ArgumentNullException);
        }
    }
}