using System;

namespace Lesson2PullRequest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("   *****   ");
            Console.WriteLine(" *       * ");
            Console.WriteLine("*  O   O  *");
            Console.WriteLine("*    ^    *");
            Console.WriteLine(" * \\___/ *");
            Console.WriteLine("   *****   ");
        }
        
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Person(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
        public string Greeting(string name)
        {
            return $"Hello, {name}";
        }
        public string HowAreYouDoing (string name)
        {
            return $"How are you doing, {name}?";
        }

            
    }
}