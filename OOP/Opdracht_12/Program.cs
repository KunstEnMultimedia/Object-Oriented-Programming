namespace Opdracht_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht123();
            Console.ReadLine();
        }

        public static void Opdracht121()
        {
            Random random = new Random();
            Student jos = new Student("Jos");


            Student[] students = new Student[20];

            for (int i = 0; i <= students.Length - 1; i++)
            {
                students[i] = new Student
                {
                    GeboorteJaar = random.Next(1940, 2011)
                };
                Console.WriteLine(students[i].Naam + " " + students[i].GeboorteJaar);
            }
            students[0] = jos;


            Student[] moreStudents = new Student[]
            {
               new Student(),
               new Student(),
               new Student(),
               new Student()

            };
            moreStudents[0].Naam = "Frank";

            Console.WriteLine(moreStudents[0].Naam);
        }

        public static void Opdracht122()
        {
            List<int> alleGetallen = new List<int>();
            alleGetallen.Add(1);
            alleGetallen.Add(2);
            alleGetallen.Add(3);


            List<bool> binaryList = new List<bool>();
            binaryList.Add(true);
            binaryList.Add(true);
            binaryList.Add(false);

            List<Student> presentieLijst = new List<Student>()
            {
               new Student() { Naam = "Brent", GeboorteJaar = 1991, IsWerkStudent = false },
               new Student() { Naam = "Albert", GeboorteJaar = 1989, IsWerkStudent = false }
            };

            List<string[]> listOfStringarrays = new List<string[]>();
            listOfStringarrays.Add(["Yo"]);
            listOfStringarrays.Add(["Waddup"]);
            listOfStringarrays.Add(["Hallo"]);
            listOfStringarrays.Add(["Yo"]);


            for (int i = 0; i <= listOfStringarrays.Count - 1; i++)
            {
                Console.WriteLine(listOfStringarrays[i].ElementAt(0));
            }

            for (int i = 0; i <= alleGetallen.Count - 1; i++)
            {
                Console.WriteLine(alleGetallen[i]);
            }

            for (int i = 0; i <= presentieLijst.Count - 1; i++)
            {
                Console.WriteLine($"{presentieLijst[i].Naam} is geboren in {presentieLijst[i].GeboorteJaar}");
            }

            for (int i = 0; i <= binaryList.Count - 1; i++)
            {
                Console.WriteLine(binaryList[i]);
            }

            // ik hed de List.clear methode getest het verwijderd alles in een list
        }

        public static void Opdracht123()
        {
            List<Student> presentieLijst = new List<Student>()
            {
               new Student() { Naam = "Brent", GeboorteJaar = 1991, IsWerkStudent = false },
               new Student() { Naam = "Albert", GeboorteJaar = 1989, IsWerkStudent = false },
               new Student() { Naam = "Marinus", GeboorteJaar = 2004, IsWerkStudent = false},
               new Student() { Naam = "Jurgen", GeboorteJaar = 2006, IsWerkStudent = true}
            };
            foreach (Student student in presentieLijst)
            {
                Console.Write($"{student.Naam} is geboren in {student.GeboorteJaar} en is ");
                Console.WriteLine(student.IsWerkStudent ? "geen werk student" : "wel een werk student");
            }

            foreach (var student in presentieLijst)
            {
                student.GeboorteJaar++;
                Console.Write($"{student.Naam} is geboren in {student.GeboorteJaar} en is ");
                Console.WriteLine(student.IsWerkStudent ? "geen werk student" : "wel een werk student");
            }
        }
    }
}
