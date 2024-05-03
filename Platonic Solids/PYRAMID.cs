using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Platonic_Solids
{
  internal class PYRAMID
  {

    //konstruktor
    public PYRAMID()
    {
      _s = 10;
    }

    //Membervariable
    private double _s;
    private double _h;

    //Methode
    public void set_s(double value)
    {
      _s = value;
    }
    public double get_s()
    {
      return _s;
    }
    public void set_h(double value)
    {
      _h = value;
    }
    public double get_h()
    {
      return _h;
    }
    public double getVol()
    {
      return (Math.Pow(_s,2) * _h) / 3;
    }
    public double getSur()
    {
      double GeradeaufSeite = Math.Sqrt(Math.Pow(_s / 2, 2) + Math.Pow(_h, 2));
      return (Math.Pow(_s, 2)) + (4 * _s * GeradeaufSeite / 2);
    }
  }
}
