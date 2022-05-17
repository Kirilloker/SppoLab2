using System;
using System.Text.Json.Serialization;

namespace TestSave
{
    public class Person
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        //private int age;
        ////[JsonIgnore]
        //public int Age //теперь свойство Age не будет сериализоваться
        //{
        //    get => age;
        //    set
        //    {
        //        if ((value < 0) || (value > 100))
        //            throw new Exception("Возраст должен находится в интервале от 0 до 100 лет");
        //        else
        //            age = value;
        //    }
        //}
        //public DateTime Birthday { get; set; }

        //public Person(string _name)
        //{
        //    Name = _name;
        //}

        //public string getName() { return Name; }

        public Person()
        {
            Name = "x";
            //Age = 100;
            Surname = "y";
            //Birthday = new DateTime(2000, 01, 16);
        }
    }
}
