using M02;

string[] subjects = { "Math", "Computer science", "Chemistry", "Geography", "History", "Literature" };
var student1c1 = new Student("ivan.ivanov@mail.ru");
var student1c2 = new Student("alex.kurlin@mail.ru");
var student1c3 = new Student("sergey.vyatckin@mail.ru");

var student2c1 = new Student("Ivan", "Ivanov");
var student2c2 = new Student("Alex", "Kurlin");
var student2c3 = new Student("Sergey", "Vyatckin");

Dictionary<Student, HashSet<string>> studentSubjectDict = new Dictionary<Student, HashSet<string>>();

Random random = new Random();

studentSubjectDict[student1c1] = BuildHashSet(subjects);
studentSubjectDict[student1c2] = BuildHashSet(subjects);
studentSubjectDict[student1c3] = BuildHashSet(subjects);
studentSubjectDict[student2c1] = BuildHashSet(subjects);
studentSubjectDict[student2c2] = BuildHashSet(subjects);
studentSubjectDict[student2c3] = BuildHashSet(subjects);

foreach (KeyValuePair<Student, HashSet<string>> kvp in studentSubjectDict)
{
    Console.WriteLine(
        "Key = {0}, Value = {1}",
        kvp.Key,
        kvp.Value);
}

HashSet<string> BuildHashSet(string[] subjects)
{
    var hashset = new HashSet<string>();
    while (hashset.Count != 3)
    {
        hashset.Add(subjects[random.Next(0, subjects.Length)]);
    }

    return hashset;
}

Console.ReadLine();