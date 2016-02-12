using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Edu.Uninpahu.Programmer.BLL; 

namespace Edu.Uninpahu.Programmer.Consola
{
    class Program
    {
        static void Main(string[] args)

        {
            Animal labrador = new Mamifero();
            labrador.NombreCientifico = "Topo";
            labrador.EdadPromedio = 5;
            Animal nemo = new Pez();
            nemo.NombreCientifico = "Batman";
            nemo.EdadPromedio = 5;
            Console.WriteLine(labrador.comer());
            Console.WriteLine(labrador.comer(true));
            Console.WriteLine(labrador.comer(false));
            Console.WriteLine(labrador.comer(nemo));
            Console.WriteLine(labrador.comer());
            Console.WriteLine(nemo.comer());
            Console.ReadKey();
          
  


        }
    }
}
