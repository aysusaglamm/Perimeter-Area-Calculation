using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolex
{
    class Program
    {
        static void Main(string[] args)
        {
            int decision, opr ,x,y,area,perimeter;
            
            Console.WriteLine("Please select a math figure");
            Console.WriteLine("1-Square");
            Console.WriteLine("2-Rectangle");
            decision =Convert.ToInt32(Console.ReadLine());


            if (decision == 1)
            {
                Console.Clear();
                Console.WriteLine("--You chose Square(1)--");
                Console.WriteLine("Please select an operation");
                Console.WriteLine("1-Perimeter");
                Console.WriteLine("2-Area");
                opr = int.Parse(Console.ReadLine());



                if (opr == 1)
                {
                    Console.WriteLine("Please enter a number:   ");
                    x = int.Parse(Console.ReadLine());
                    perimeter = 4 * x;
                    Console.WriteLine("Perimeter is:   " + perimeter);

                }
                else if (opr == 2)
                {
                    Console.WriteLine("Please enter a number:   ");
                    x = int.Parse(Console.ReadLine());
                    area = x * x;
                    Console.WriteLine("Area is:  " + area);


                }
                else
                {
                    Console.WriteLine("Invalid operation,please click enter for quit");

                }
            }
            else if (decision == 2)
            {
                    
                    Console.Clear();
                    Console.WriteLine("--You chose Rectangle(2)--");
                    Console.WriteLine("Please select an operation");
                    Console.WriteLine("1-Perimeter");
                    Console.WriteLine("2-Area");
                    opr = int.Parse(Console.ReadLine());
                    
                    
                    if (opr==1)
                    {
                        Console.WriteLine("Please enter a number:   ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter a number:   ");
                        y = int.Parse(Console.ReadLine());
                        perimeter = 2 * x*y;
                        Console.WriteLine("Perimeter is:   " + perimeter);
                    }
                    else if (opr==2)
                    {
                        Console.WriteLine("Please enter a number:   ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter a number:   ");
                        y = int.Parse(Console.ReadLine());
                        area = x * y;
                        Console.WriteLine("Area is:    " + area);
                        
                    }

                Console.ReadKey();
            }
                


            }


            


           

        }
    }

