namespace M09
{
    using System.Reflection;

    public class DataRetriever
    {
        public static List<Student> Retrieve(List<Student> students, string tokens)
        {
            if (tokens == null)
                throw new ArgumentNullException("Inputed tokens can't be null");
            string name, test, minmark, maxmark;
            DateOnly datefrom, dateto;
            var orderby = typeof(Student).GetProperty("Name")!;
            bool isAscending = true;
            string[] tokenArray = tokens.Split(" ");

            var query = from student in students
                        select student;

            for (int i = 0; i < tokenArray.Length - 1; i++)
            {
                switch (tokenArray[i])
                {
                    case "-name":
                        {
                            name = tokenArray[i + 1];
                            query = query.Where(x => x.Name!.Split().First() == name);
                            break;
                        }

                    case "-test":
                        {
                            test = tokenArray[i + 1];
                            query = query.Where(x => x.Test == test);
                            break;
                        }

                    case "-minmark":
                        {
                            minmark = tokenArray[i + 1];
                            query = query.Where(x => x.Mark >= Convert.ToInt32(minmark));
                            break;
                        }

                    case "-maxmark":
                        {
                            maxmark = tokenArray[i + 1];
                            query = query.Where(x => x.Mark <= Convert.ToInt32(maxmark));
                            break;
                        }

                    case "-datefrom":
                        {
                            datefrom = DateOnly.Parse(tokenArray[i + 1]);
                            query = query.Where(x => x.Date >= datefrom);
                            break;
                        }

                    case "-dateto":
                        {
                            dateto = DateOnly.Parse(tokenArray[i + 1]);
                            query = query.Where(x => x.Date <= dateto);
                            break;
                        }

                    case "-sort":
                        {
                            orderby = typeof(Student).GetProperty(tokenArray[i + 1], BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance)!;
                            isAscending = (tokenArray[i + 2] == "asc") ? true : false;
                            break;
                        }
                }
            }

            if (isAscending)
                query = query.OrderBy(x => orderby);
            else
                query = query.OrderByDescending(x => orderby);
            var result = query.ToList();
            if (isAscending)
                result = result.OrderBy(result => orderby.GetValue(result, null)).ToList();
            else
                result = result.OrderByDescending(result => orderby.GetValue(result, null)).ToList();
            return result;
        }
    }
}