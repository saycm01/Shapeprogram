using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int X,A,Y;
            Console.WriteLine("Enter the angle of your shape: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first length of your shape: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second length of your shape: ");
            Y = int.Parse(Console.ReadLine());
            if (A == 90)
            {
                if (X == Y) 
                {
                    Console.WriteLine("Your shape is a Square!");
                }
                else
                {
                    Console.WriteLine("Your shape is a Rectangle!");
                }
            }
            else
            {
                if(A==60||A==120)
                {
                    Console.WriteLine("Your shape is a Hexagon!");
                }
                else
                    {
                        if(X==Y)
                        {
                            Console.WriteLine("Your shape is a Rhombus!");
                        }
                        else
                        {
                            Console.WriteLine("Your shape is a Parallelogram!");
                        }
                    
                    }
                    
                }
            }
        }
    }

