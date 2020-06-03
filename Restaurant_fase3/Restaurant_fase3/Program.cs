using System;
using System.Collections.Generic;   //para listas siempre escribiremos esto

namespace Restaurant_fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int b5 = 5, b10 = 10, b20 = 20, b50 = 50, b100 = 100, b200 = 200, b500 = 500;// 5, 10, 20, 50, 100, 200, 500 
            float preu_total = 0;

            string[] menu = new string[5];  // menu que conte 5 plats
            float[] preu = new float[5];   //preu de cada plat 

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Plato:");
                menu[i] = Console.ReadLine();
                Console.WriteLine("Precio:");
                preu[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Aquí tiene la carta:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(menu[i] + " - " + preu[i] + " euros \n");
            }
            Console.WriteLine("¿Qué desea comer?  \n");

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
            }

            foreach(string plat_com in comanda)
            {
                if (Array.Exists(menu, plat_menu => plat_menu == plat_com))
                {
                    int p = Array.IndexOf(menu, plat_com);   //guardem el nº de casella del plat en el vector 'menu' per trobar el preu 
                    preu_total += preu[p];
                    Console.WriteLine(menu[p] +  " - " + preu[p]);
                }
                else
                    Console.WriteLine("El producto " + plat_com + " no existe en el menú");
            }

            Console.WriteLine("En total seran " + preu_total + " euros");

        }
    }
}
