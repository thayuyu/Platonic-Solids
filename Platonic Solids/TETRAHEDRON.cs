using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platonic_Solids
{
  internal class TETRAHEDRON
  {
    // konstruktor
    public TETRAHEDRON() 
    {
      _s = 10;
    }

    // membervariable
    private double _s;

    // methode
    public double get_s()
    {
      return _s;
    }
    public void set_s(double val) 
    {
      _s = val;
    }
    public double getVol()
    {
      return (Math.Pow(_s,3) * Math.Sqrt(2)) / 12;
    }
    public double getSur()
    {
      return Math.Pow(_s,2) * Math.Sqrt(3);
    }
  }
}
