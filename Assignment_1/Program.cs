// Assignment 01 OOP
using System;

namespace Assignment01OOP
{
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public enum Permissions
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    public enum Colors
    {
        Red,
        Green,
        Blue
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            // Write a C# program that prints out all the days of the week using this Enum.
            Console.WriteLine("Days of the week:");
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            
            #endregion

            #region 2. Create an Enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            // Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            Console.WriteLine("Enter a season:");
            string season = Console.ReadLine();
            if (Enum.TryParse<Season>(season, out Season result))
            {
                if (result == Season.Spring)
                {
                    Console.WriteLine("Spring: March, April, May");
                }
                else if (result == Season.Summer)
                {
                    Console.WriteLine("Summer: June, July, August");
                }
                else if (result == Season.Autumn)
                {
                    Console.WriteLine("Autumn: September, October, November");
                }
                else if (result == Season.Winter)
                {
                    Console.WriteLine("Winter: December, January, February");
                }
            }
            else
            {
                Console.WriteLine("Invalid season");
            }

            #endregion

            #region 3. Assign the following Permissions (Read, Write, Delete, Execute) in a form of Enum.
            // Create a variable from the previous Enum to Add and Remove Permission from the variable.
            // Check if a specific Permission exists inside the variable.
            Permissions permissions = Permissions.Read | Permissions.Write;
            Console.WriteLine("Permissions: " + permissions);

            permissions |= Permissions.Delete;
            Console.WriteLine("Permissions: " + permissions);

            permissions &= ~Permissions.Write;
            Console.WriteLine("Permissions: " + permissions);

            if ((permissions & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("Read permission exists");
            }
            else
            {
                Console.WriteLine("Read permission does not exist");
            }

            if ((permissions & Permissions.Write) == Permissions.Write)
            {
                Console.WriteLine("Write permission exists");
            }
            else
            {
                Console.WriteLine("Write permission does not exist");
            }

            if ((permissions & Permissions.Delete) == Permissions.Delete)
            {
                Console.WriteLine("Delete permission exists");
            }
            else
            {
                Console.WriteLine("Delete permission does not exist");
            }

            if ((permissions & Permissions.Execute) == Permissions.Execute)
            {
                Console.WriteLine("Execute permission exists");
            }
            else
            {
                Console.WriteLine("Execute permission does not exist");
            }

            #endregion

            #region 4. Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            // Write a C# program that takes a color name as input from the user and displays a message
            // indicating whether the input color is a primary color or not.
            Console.WriteLine("Enter a color:");
            string color = Console.ReadLine();
            if (Enum.TryParse<Colors>(color, out Colors resultColor))
            {
                if (resultColor == Colors.Red || resultColor == Colors.Green || resultColor == Colors.Blue)
                {
                    Console.WriteLine("Primary color");
                }
                else
                {
                    Console.WriteLine("Not a primary color");
                }
            }
            else
            {
                Console.WriteLine("Invalid color");
            }
            
            #endregion
        }
    }
}
