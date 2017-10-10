using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> testScores = new List<int> { 100, 96, 37, 88, 79, 70 };
            //testScores.Add(90);
            //testScores.Add(87);

            //List<int> luckNumbers = new List<int>();
            //luckNumbers.Add(1);
            //luckNumbers.Add(2);
            //luckNumbers.Add(3);

            //Console.WriteLine(luckNumbers.Count);

            //List<string> favFoods = new List<string> { "steak", "shrimp", "salmon", "chocolate", "savory delights" };
            //Console.WriteLine(favFoods[0]);
            //Console.WriteLine(favFoods[2]);
            //Console.WriteLine(favFoods[4]);

            //List<string> leastFaveFoods = new List<string>();
            //leastFaveFoods.Add("Beets");
            //leastFaveFoods.Add("Pumpkin");
            //leastFaveFoods.Add("carrot");


            //leastFaveFoods[0] = "Pizza";


            //Console.WriteLine(leastFaveFoods[0]);

            //List<string> favShows = new List<string>() { "One Piece", "HunterxHunter", "One Punch Man", "Bleach", "My Hero Academia" };
            //for (int i = 0; i < favShows.Count; i++)
            //{
            //    Console.WriteLine(favShows[i]);
            //}

            //Console.WriteLine();
            //favShows.Insert(2, "Naruto");
            //favShows.Insert(3, "LOTR");
            //favShows.Insert(4, "YUYUHAKUSHO");

            //foreach (string show in favShows)
            //{
            //    Console.WriteLine(show);
            //}

            //favShows.Remove("One Piece");
            //favShows.Remove("HunterxHunter");
            //Console.WriteLine();
            //foreach (string show in favShows)
            //{
            //    Console.WriteLine(show);
            //}

            //favShows.RemoveAt(2);

            List<string> animals = new List<string>();
            animals.Add("Cheetah");
            animals.Add("Koala");
            animals.Add("Meerkat");
            animals.Add("Butterfly");
            animals.Add("Cat");

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();

            List<bool> boolList = new List<bool>() { true, false, false, true, false };
            foreach (bool boolean in boolList)
            {
                if (boolean == true)
                {
                    Console.WriteLine("Better Bring an Umbrella");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
            }

            Console.WriteLine();

            List<int> numbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));

            numbers.Remove(27);
            numbers.Remove(77);
            numbers.Remove(32);
            numbers.Remove(6);
            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));
            Console.WriteLine();

            List<int> birthdayDays = new List<int>() { 21, 2, 15, 23, 6, 25, 10 };
            Console.WriteLine(birthdayDays.IndexOf(21));
            birthdayDays.Sort();
            Console.WriteLine(birthdayDays.IndexOf(21));

            for (int i = 0; i < birthdayDays.Count; i++)
            {
                Console.WriteLine("On day number " + birthdayDays[i] + " of your month, happy birthday!!");
            }

            birthdayDays.Clear();

            foreach (int day in birthdayDays)
            {
                Console.WriteLine(day);
            }






        }

        }
    }

