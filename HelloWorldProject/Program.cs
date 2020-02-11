using System;

namespace HelloWorldProject {
    class Program {
        static void Main(string[] args) {

            var s1 = new Student();
            s1.Name = "Fred";
            s1.FavoriteColor = "Blue";
            s1.FavoriteNumber = 88;
            s1.ToConsole();

            var s2 = new Student();
            s2.Name = "Betty";
            s2.FavoriteColor = "Green";
            s2.FavoriteNumber = 27;
            s2.ToConsole();



            Console.WriteLine("This is my Hello World, C# Program!");
            Console.WriteLine("Turn left, into the corridor");
            Console.WriteLine("FIND THE KEY!");

            var counter = 1;
            //counter = "123";
            var name = "Greg";
            name = "123";

            if (counter == 0) {
                Console.WriteLine("Count is zero");
                } else {
                Console.WriteLine("Count is not zero");
                }

                counter = counter + 1;
                Console.WriteLine("Count value is " + counter);

            counter += 1;
            Console.WriteLine("Count value is {0}", counter);

            counter++;
            Console.WriteLine($"Count value is {counter}");

            var sum = 0;
            for(var index = 0; index <= 1000; index++) {
                sum += index;
                }
            Console.WriteLine($"Sum is {sum}");
            }
        }
    }
