using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBaum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willst baum? bekommtst baum!");

            bool isUneven = false;
            int breite = 0;
            do
            {
               
                Console.WriteLine("Gib mal breite:");
                breite = Convert.ToInt32(Console.ReadLine());
                if (breite % 2 != 0 && breite <= 100)
                {
                    isUneven = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Es sollte ungerade sein! BROO");
                 
                }
            }
            while (!isUneven);


            int spaces = (breite - 1) / 2;
            int stammspace = spaces - 1;
            int height = (breite + 1) / 2;
            int stammheight = height / 5 - height % 5;
            int stars = 1;
            // Blätter
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int f = 0; f < stars; f++)
                {
                    Console.Write("*");
                }
                stars += 2;
                // Für Style
                for (int k = 0; k < spaces; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
                spaces--;
            }

            // Stamm
            string stammspaces = "";
            if (stammheight <= 1)
            {
                stammheight = 1;
            }
            for (int h = 0; h < stammspace; h++)
            {
                stammspaces = stammspaces + " ";
            }
            for (int andrin = 0; andrin < stammheight; andrin++)
            {
                Console.WriteLine($"{stammspaces}| |{stammspaces}");
            }
            Console.WriteLine("\nVielen Dank dass sie bei uns Baum macht haben Herr bro");
           
            Console.ReadLine();

            
        }
    }
}
