using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace Task3
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<MovieStar> movieStars = JsonConvert.DeserializeObject<List<MovieStar>>(File.ReadAllText("../../../input.json"));

            foreach (var star in movieStars)
            {
                var age = CurrentAge(star.DateOfBirth);
                Console.WriteLine(star.Name + " " + star.Surname);
                Console.WriteLine(star.Sex);
                Console.WriteLine(star.Nationality);
                Console.WriteLine(age + " years old");
                Console.WriteLine();
            }
        }

        private static int CurrentAge(DateTime dateOfBirth)
        {
            var currentAge = 0;

            currentAge = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                currentAge -= 1;

            return currentAge;
        }
    }
}
