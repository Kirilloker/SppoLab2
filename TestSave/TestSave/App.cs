using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestSave;

public class App
{
    public static void Main()
    {

        JsonSerializerOptions options = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true
        };

        if (!false)
        {
            //Square figure1 = new Square();

            //Point2D point1 = new Point2D(10, 10, "Red");
            //Point2D point2 = new Point2D(20, 20, "Green");
            //Point2D point3 = new Point2D(30, 40, "Blue");
            //Point2D point4 = new Point2D(40, 40, "Purple");

            //figure1.AddPoint(point1);
            //figure1.AddPoint(point2);
            //figure1.AddPoint(point3);
            //figure1.AddPoint(point4);

            //figure1.PrintFull();

            //Console.WriteLine();


            //Square figure2 = new Square();

            //figure2.AddPoint(point3);
            //figure2.AddPoint(point4);

            //Console.WriteLine();

            //figure2.PrintFull();

            //figure1.changeColor("HARD", 3);

            //Console.WriteLine();
            //figure1.PrintFull();

            //Console.WriteLine();
            //figure2.PrintFull();





            //Point2D point5 = new Point2D()
            //{
            //    x = 10,
            //    y = 15,
            //    color = "Dsad"
            //};

            //List<Square> squares = new List<Square>();
            //squares.Add(figure1);
            //squares.Add(figure2);



            //string personJson = JsonSerializer.Serialize(squares, options);


            ////string personJson = JsonSerializer.Serialize(person, typeof(Person));
            //StreamWriter file = File.CreateText("person.json");
            //Console.WriteLine(personJson);
            //Console.WriteLine(file);
            //file.WriteLine(personJson);
            //file.Close();

            Test test1 = new Test() { name = "Test1"};
            Test test2 = new Test() { name = "Test2", test = test1};
            test1.test = test2;

            List<Test> testList = new List<Test>();
            testList.Add(test1);
            testList.Add(test2);

            string personJson = JsonSerializer.Serialize(testList, options);


            //string personJson = JsonSerializer.Serialize(person, typeof(Person));
            StreamWriter file = File.CreateText("person.json");
            Console.WriteLine(personJson);
            Console.WriteLine(file);
            file.WriteLine(personJson);
            file.Close();

        }
        else
        {
            string data = File.ReadAllText("person.json");
            //List <Square> squres = JsonSerializer.Deserialize<List <Square>> (data);

            List<Square> squres = JsonSerializer.Deserialize<List<Square>>(data, options);

            squres[0].PrintFull();
            squres[1].PrintFull();

            squres[0].changeColor("ASdsad", 3);

            Console.WriteLine();
            squres[0].PrintFull();
            squres[1].PrintFull();
        }

        //Person person = new Person()
        //{
        //    Name = "Ваня",
        //    Surname = "Пупкин",
        //    Age = 11,
        //    Birthday = new DateTime(1983, 01, 16)
        //};

        //string personJson = JsonSerializer.Serialize(person, typeof(Person));

        //StreamWriter file = File.CreateText("person.json");
        //Console.WriteLine(file);
        //Console.WriteLine(personJson);
        //file.WriteLine(personJson);
        //file.Close();

    }
}
