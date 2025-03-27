namespace ConsoleApp4

{ 
 internal class Program
{
    static void Main(string[] args)
    {


        while (true)
        {

            Console.WriteLine("Choose an operation");
            Console.WriteLine("1 - to Select");
            Console.WriteLine("2 - to lookup");
            Console.WriteLine("3 - save file: ");
            Console.WriteLine("4 - Create number pyramid:");
            Console.WriteLine("0 - to exit");
            Console.WriteLine("Enter your choice");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    UseSelect();
                    break;
                case "2":
                    UseLookup();
                    break;
                case "3":
                    SaveFile();
                    break;
                case "4":
                    GetPyramid();
                    break;
                case "0":
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }




    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    static void UseSelect()
    {

        List<Person> list = new List<Person>
            {
                new Person { Name = "Andreas", Age = 29 },
                new Person { Name = "Hen", Age = 22 },
                new Person { Name = "Allar", Age = 25 },
                new Person { Name = "Tom", Age = 27 },

            };


        var names = list.Select(p => p.Name);
        Console.WriteLine("Names of people: ");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

    }
    static void UseLookup()
    {

        List<Person> list = new List<Person>
            {

            new Person { Name = "Andrus", Age = 20 },
            new Person { Name = "Hendrik", Age = 22 },
            new Person { Name = "Alar", Age = 26 },
            new Person { Name = "Toomas", Age = 29 },

            };
        var lookup = list.ToLookup(p => p.Age);
        Console.WriteLine("People grouped by age: ");

        foreach (var group in lookup)
        {
            Console.WriteLine($"Age {group.Key}:");

            foreach (var person in group)
            {
                Console.WriteLine($"name - {person.Name}");
            }
        }
    }

    static void SaveFile()
    {
        Console.WriteLine("Enter text to save: ");
        string inputText = Console.ReadLine();
        Console.WriteLine("Enter the file path to save the text: ");
        string filePath = Console.ReadLine();

        try
        {
            if (Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                File.WriteAllText(filePath, inputText);
                Console.WriteLine("File saved successfully");

            }
            else
            {
                Console.WriteLine("Error Directory does not exist");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());

        }

    }

    static void GetPyramid()
    {
        int i, j, rows;

        Console.WriteLine("Sisesta ridadae arv!");
        rows = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= rows; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();
        }

    }

}
}
