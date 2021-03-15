using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SDraperAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            bool goForward = false;
            int length = 1;
            int width = 1;
            int response = 0;

            do
            {
                Console.WriteLine("What is the length?");
                string sLength = Console.ReadLine();
                if (int.TryParse(sLength, out length))
                {
                    if (length > 0)
                    {
                        rectangle.SetLength(length);
                        goForward = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive integer.");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid integer, above zero.");
                }
            } while (!goForward);

            goForward = false;

            do
            {
                Console.WriteLine("What is the width?");
                string sWidth = Console.ReadLine();
                if (int.TryParse(sWidth, out width))
                {
                    if (width > 0)
                    {
                        rectangle.SetWidth(width);
                        goForward = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive integer.");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid integer, above zero.");
                }
            } while (!goForward);

            do
            {
                goForward = false;
                Console.WriteLine();
                Menu();
                string sResponse = Console.ReadLine();
                if(int.TryParse(sResponse, out response))
                {
                    if(response == 1)
                    {
                        Console.WriteLine("The length is: " + rectangle.GetLength());
                    }
                    else if(response == 2)
                    {
                        do
                        {
                            Console.WriteLine("What would you like to change the length to?");
                            string sLength = Console.ReadLine();
                            if (int.TryParse(sLength, out length))
                            {
                                if (length > 0)
                                {
                                    rectangle.SetLength(length);
                                    goForward = true;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a positive integer.");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid integer, above zero.");
                            }
                        } while (!goForward);

                    }
                    else if (response == 3)
                    {
                        Console.WriteLine("The rectangle's width is: " + rectangle.GetWidth());
                    }
                    else if (response == 4)
                    {
                        do
                        {
                            Console.WriteLine("What would you like to change the width to?");
                            string sWidth = Console.ReadLine();
                            if (int.TryParse(sWidth, out width))
                            {
                                if (width > 0)
                                {
                                    rectangle.SetWidth(width);
                                    goForward = true;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a positive integer.");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid integer, above zero.");
                            }
                        } while (!goForward);
                    }
                    else if (response == 5)
                    {
                        Console.WriteLine("The rectangle's perimeter is: " + rectangle.GetPerimeter());
                    }
                    else if (response == 6)
                    {
                        Console.WriteLine("The rectangle's area is: " + rectangle.GetArea());
                    }
                    else if (response == 7)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid 1-7 number.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a 1-7 integer");
                }    
            } while (response != 7);
        }

        static void Menu()
        {
            Console.WriteLine("Type in the number that corresponds with the action you would like to perform.");
            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");
        }
    }
}
