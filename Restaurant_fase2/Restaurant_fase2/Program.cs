using System;
using System.Collections.Generic;   //para listas siempre escribiremos esto
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b5 = 5, b10 = 10, b20 = 20, b50 = 50, b100 = 100, b200 = 200, b500 = 500;// 5, 10, 20, 50, 100, 200, 500 
            int preu_total;

            string[] menu = new string[5];  // menu que conte 5 plats
            double[] preu = new double[5];   //preu de cada plat 

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Plato:");
                menu[i] = Console.ReadLine();
                Console.WriteLine("Precio:");
                preu[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("¿Qué desea comer? Aquí tiene la carta:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(menu[i] + " - " + preu[i] + " euros \n");
            }
            
            List<string> comanda = new List<string>(); //creem la llista on guardarem tot el que demana el client
            bool seguir = true;
            int more = 1;

            while (seguir)
            {
                comanda.Add(Console.ReadLine());  //anem afegint el que diu el client
                Console.WriteLine("¿Algo más? (1: Sí / 0: No)");
                more = int.Parse(Console.ReadLine());

                if (more == 0)
                    seguir = false;

                else if (more == 1)
                    seguir = true;

                else
                    Console.WriteLine("Dame una respuesta válida, ¿si o no?");        
            }

         
        }
    }
}
