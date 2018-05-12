using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        public enum Gender { Female, Male };
        static void Main(string[] args)
        {
            int year=0 , month=0 , day=0 ;
            char genderLetter;
            Gender gender;
            
            Console.WriteLine("Year:");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month:");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Day:");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gender: M/F");
            genderLetter = Convert.ToChar(Console.ReadLine());
            if (genderLetter.Equals("F"))
                gender = Gender.Female;
            else 
              if(genderLetter.Equals("M"))
                gender = Gender.Male;
              else
                gender = 0;

            DateTime value = new DateTime(year, month, day);
            Console.WriteLine($"DateTime of birth: {value}");
            int age = DateTime.Now.Year- year;
            if (DateTime.Now.Month < month || (DateTime.Now.Month == month && DateTime.Now.Day < day))
                age--;
            Console.WriteLine($"Age: {age}");

            if (gender.Equals(Gender.Male))
                if (age >= 65)
                    Console.WriteLine("Retired");
                else
                {
                    Console.WriteLine("Retireing age: 65");
                    Console.WriteLine($"Years till retirement: {65 - age}");
                }
            else
                     if (age >= 63)
                Console.WriteLine("Retired");
            else
            {
                Console.WriteLine("Retiring age: 63");
                Console.WriteLine($"Years till retirement: {63 - age}");
            }

            
            Console.ReadLine();
        }
    }
}
