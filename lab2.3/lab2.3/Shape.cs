using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._3
{
    public abstract class Shape
    {

double _length;
double _width;

public abstract double Area
{
    get; 
}



public double Length
{


  get 
  { 
      return _length; 
  }

  set 
  { 

      
      if (value < 0)
      {
          throw new ArgumentException();
      }
      _length = value;
  }


}

 
 
    

public abstract double Perimeter 
{
    get; 
    
}



public double Width
{


    get
    {
        return _width;
    }

    set
    {

        
        if (value < 0)
        {
            throw new ArgumentException();
        }
        _width = value;

    }


}

protected Shape (double length, double width)
{

    Length = length;
    Width = width;

}

public override string ToString()

{

    return String.Format("Längd    : {0, 10:f2}\nBredd    : {1, 10:f2}\nOmkrets  : {2, 10:f2}\nArea     : {3, 10:f2}", Length, Width, Perimeter, Area); 

}



    }
}
