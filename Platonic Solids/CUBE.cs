using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platonic_Solids
{
  internal class CUBE
  {
    //konstruktor
    public CUBE()
    {
      _s = 10;
    }

    //Membervariable
    private double _s;

    //Methode
    public void set_s(double value) 
    {
      _s = value;
    }
    public double get_s() 
    {
      return _s;
    }
    public double getVol()
    {
      return Math.Pow(_s,3);
    }
    public double getSur()
    {
      return Math.Pow(_s,2) * 6;
    }
  }
}
