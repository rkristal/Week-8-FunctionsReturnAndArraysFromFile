using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static int GeneralRandomIndex(string[] someArray)
        {

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }


        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };

           
            Console.WriteLine($"Computer picked: {foods[GeneralRandomIndex(foods)]}");

        }

        private static void DisplayRandomDrink()
        {

            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };

            
            Console.WriteLine($"Computer picked: {drinks[GeneralRandomIndex(drinks)]}");


        }

        private static void DisplayRandomMovie()
        {


            string[] movies = { "Back to the future", "Jumanij", "Central Intelligence", "Fast and Furios" };

           
            Console.WriteLine($"Computer picked: {movies[GeneralRandomIndex(movies)]}");




        }
    }
}
