using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            string drSeuss = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

            //string [] words = drSeuss.Split(" ");   splits the words at each space

            //Console.WriteLine(string.Join(" ", words));   rejoins the words at each space


            string[] words = drSeuss.Split(".");  //splits into sentences at each .

            Console.WriteLine(string.Join(".", words));  //rejoins the sentences at each .



            //Console.WriteLine("Hello Strings!");
        }
    }
}
