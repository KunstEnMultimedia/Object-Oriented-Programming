using System.ComponentModel.Design;

namespace Opdracht_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht125b();
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
                Console.WriteLine(student.IsWerkStudent ? "wel een werk student" : "geen werk student");
            }

            foreach (var student in presentieLijst)
            {
                student.GeboorteJaar++;
                Console.Write($"{student.Naam} is geboren in {student.GeboorteJaar} en is ");
                Console.WriteLine(student.IsWerkStudent ? "wel een werk student" : "geen werk student");
            }
        }

        public static void Opdracht124()
        {
            Queue<string> wachtrij = new Queue<string>();

            wachtrij.Enqueue("Nummer 1");
            wachtrij.Enqueue("Nummer 2");
            wachtrij.Enqueue("Nummer 3");

            Console.WriteLine("ik verwijder " + wachtrij.Dequeue());
            Console.WriteLine(wachtrij.Peek());
            Console.WriteLine(wachtrij.Peek());
            Console.WriteLine("Nu zin er " + wachtrij.Count() + " Elementen in de wachtrij");


            Stack<string> stapel = new Stack<string>();

            stapel.Push("Eerste papier");
            stapel.Push("Tweede papier");
            stapel.Push("Laatste papier");
            Console.WriteLine();

            stapel.Pop();
            stapel.Pop();
            Console.WriteLine("Hoogte van de stapel is " + stapel.Count());
            Console.WriteLine();


            Dictionary<int, string> PairsDict = new Dictionary<int, string>();
            PairsDict.Add(6363 ,"James Bond");
            PairsDict.Add(123, "Tim Dams");
            PairsDict.Add(666, "The Beast");
            PairsDict.Add(700, "James Bond");

            foreach (var Pair in PairsDict)
            {
                Console.WriteLine($"{Pair.Key} : {Pair.Key}");
            }
        }

        public static void Opdracht125a()
        {
            double[] prijzen = new double[5];
            double nummer;
            double som = 0;

            foreach (var prijs in prijzen)
            {
              Opnieuw:
                 Console.Write($"Prijs {Array.IndexOf(prijzen, prijs) + 1}  : ");
                 bool v = Double.TryParse(Console.ReadLine(), out nummer);
             
                 if (!v) // error handling
                 {
                     Console.WriteLine("Foute invoer");
                     goto Opnieuw;
                 }
             
                 prijzen[Array.IndexOf(prijzen, prijs)] = nummer; // Zet de index van prijs naar nummer
            }
            Console.WriteLine("De prijzen hoger of gelijk aan vijf 5 zijn/is: ");

            foreach (var numbers in prijzen)
            {
                som += numbers;

                if (numbers >= 5)
                { 
                 Console.WriteLine($"{numbers}");
                }
            }
            Console.WriteLine("Het gemiddelde van alle getallen is: " + som / prijzen.Length);

        }

        public static void Opdracht125b()
        {
            List<Speelkaart> Deck = Speelkaart.MaakSpel();

            Speelkaart.checkDeck(Deck);
        }
    }
}
