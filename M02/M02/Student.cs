namespace M02
{
    internal class Student
    {
        private string fullName;
        private string email;

        public Student(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException($"\"{nameof(email)}\" can not be blank or empty.", nameof(email));
            }

            this.email = email;
            string[] sep = new string[] { "@mail.ru" };
            string[] temp = email.Split(sep, StringSplitOptions.None);
            fullName = string.Join("", temp);
            fullName = fullName.Replace('.', ' ');
        }

        public Student(string name, string surname)
        {
            fullName = $"{name.ToLower()} {surname.ToLower()}";
            email = $"{name.ToLower()}.{surname.ToLower()}@mail.ru";
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   fullName == student.fullName &&
                   email == student.email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(fullName, email);
        }
    }
}