using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.Id = 1;
            person1.Name = "Yunus";
            person1.City = "Istanbul";

            Person person2 = new Person();
            person2.Id = 2;
            person2.Name = "Sait";
            person2.City = "Istanbul";

            Person person3 = new Person();
            person3.Id = 3;
            person3.Name = "Ibrahim";
            person3.City = "Istanbul";

            Person[] people = new Person[] { person1, person2, person3};

            foreach (var kisi in people)
            {
                Console.WriteLine("Name : "+kisi.Name+"        ID : "+kisi.Id+"           City : "+kisi.City);
            }
            
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}