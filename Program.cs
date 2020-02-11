using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tluong_QA_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            string userInput;
            do
            {
                ShowMenu();
                userInput = Console.ReadLine();
            
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Radius = " + circle.GetRadius());
                        break;

                    case "2":
                        Console.WriteLine("Enter your radius:");
                        userInput = Console.ReadLine();
                        circle.SetRadius(Convert.ToInt32(userInput));
                        Console.WriteLine("Radius changed to " + circle.GetRadius());
                        break;

                    case "3":
                        Console.WriteLine("The Circumferenece of the circle is : " + circle.GetCircumference());
                        break;

                    case "4":
                        Console.WriteLine("The area of the circle is : " + circle.GetArea());
                        break;

                    case "5":
                        Console.WriteLine("Application closing!");
                        break;

                    default:
                        Console.WriteLine("Wrong selection, please try again!");
                        break;
                }
            }
            while (userInput != "5");
            Console.ReadKey();
        }
        static void ShowMenu()
        {
            Console.WriteLine( "Please select the following option: \n 1. Get Circle \n 2. Change Circle Radius \n 3. Get Circle Circumference \n 4. Get Circle \n 5. Exit");
        }
    }
}
