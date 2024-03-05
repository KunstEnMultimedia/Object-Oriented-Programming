namespace Opdracht_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht121();
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
    }
}
