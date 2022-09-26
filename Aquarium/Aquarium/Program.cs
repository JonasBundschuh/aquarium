using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Aquarium abfragen
            Console.WriteLine("How long do you want your aquarium to be?");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How wide do you want your aquarium to be?");
            int y = Convert.ToInt32(Console.ReadLine());
            
            
            string[,] aquarium = new string[x, y];

            for (int j = 0; j < x; j++)
            {
                for(int i = 0; i<y; i++)
                {
                    if(j == 0)
                    {
                        aquarium[i, j] = "-";
                    }
                    else if(i == y-1){
                        aquarium[i, j] = "|";
                    }
                    else
                    {
                        aquarium[i,j] = " ";
                    }

                    if(j == x-1)
                    {
                        aquarium[i, j] = "-";
                    }
                    
                }
            }

            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(aquarium[i,j]);
                }    
                Console.Write("\n");
            }

            List<Fishes> fishies = new List<Fishes>();
            fishies.Add(new Fishes());
            Console.ReadLine();
        }
    }
}
