using System;

namespace vladhoes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, here you can create your list of the best porn actors about your opinion.");
            Console.WriteLine("Please, write your name.");
            var array = new string[4];
            var name = Console.ReadLine();
            Console.WriteLine(name + " ,we have pleasure see you here.");
            Console.WriteLine("Please write the name of porn actor");
            var a = Console.ReadLine();
            array[0] = a;
            Console.WriteLine("You wrote the name is " + array[0]);
            Console.WriteLine("Write the next 5 names");
            var b = Console.ReadLine();
            var c = Console.ReadLine();
            var d = Console.ReadLine();
            // muss
            array[1] = b;
            array[2] = c;
            array[3] = d;

            Console.WriteLine("If you want to search actor, just write his name:");

            var names = Console.ReadLine();
            //cycle
            foreach (var t in array)
            {
                if (names == t)
                {
                    Console.WriteLine(t + " it's your actor!");
                }
                else
                {
                    Console.WriteLine("We can't found this name, please try again");
                    break;
                }
            }

            Console.WriteLine("Thank you for using our group.");
        }
    }
}

