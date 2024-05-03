using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platonic_Solids
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welche Form wollen sie berechnen?\n[cube]\n[pyramid]\n[tetrahedron]\n ");
      string ourobject = Console.ReadLine().ToLower();

      // Cube
      if(ourobject == "cube")
      {
        Console.Clear();
        Console.WriteLine("Cube\n----\n");
        // herstellung cube
        CUBE cube1 = new CUBE();

        Console.Write("Geben sie die Seitenlänge an:\t");
        cube1.set_s(Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine("\nVolumen:\t{0:0.00}", cube1.getVol());
        Console.WriteLine("Oberfläche:\t{0:0.00}", cube1.getSur());
        Console.ReadKey();
      }

      // Pyramid
      else if(ourobject == "pyramid")
      {
        Console.Clear();
        Console.WriteLine("Pyramid\n-------\n");
        // herstellung pyramide
        PYRAMID pyramid1 = new PYRAMID();

        Console.Write("Geben sie die Grunkante an:\t");
        pyramid1.set_s(Convert.ToDouble(Console.ReadLine()));
        Console.Write("Geben sie die Höhe an:\t");
        pyramid1.set_h(Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine("\nVolumen:\t{0:0.00}", pyramid1.getVol());
        Console.WriteLine("Oberfläche:\t{0:0.00}", pyramid1.getSur());
        Console.ReadKey();
      }

      // Tetrahedron
      else if(ourobject == "tetrahedron")
      {
        Console.Clear();
        Console.WriteLine("Tetrahedron\n-----------\n");
        // herstellung tetrahedron
        TETRAHEDRON tetrahedron1 = new TETRAHEDRON();

        Console.Write("Geben sie eine Kante an:\t");
        tetrahedron1.set_s(Convert.ToDouble(Console.ReadLine()));
      
        Console.WriteLine("\nVolumen:\t{0:0.00}", tetrahedron1.getVol());
        Console.WriteLine("Oberfläche:\t{0:0.00}", tetrahedron1.getSur());
        Console.ReadKey();
      }
    }
  }
}
