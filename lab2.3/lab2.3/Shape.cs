using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._3
{
    public abstract class Shape
    {
        // Skapar fält.
        double _length;
        double _width;

        // Hämtar in metoden "area" ifrån klasserna "Ellipse" & "Rectangle". Men enbart en klass (beroende på vilken form användaren väljer).
        public abstract double Area
        {
            get; 
        }



        public double Length
        {


          get 
          { 
              return _length; // Returnerar längd.
          }

          set 
          { 

              // Om värdet är mindre än noll så "kastas" ett nytt undantag,
              if (value < 0)
              {
                  throw new ArgumentException();
              }
              _length = value;
          }


        }




// Hämtar in metoden "perimeter" ifrån klasserna "Ellipse" & "Rectangle". Men enbart en klass (beroende på vilken form användaren väljer).
public abstract double Perimeter 
{
    get; 
    
}



public double Width
{


    get
    {
        return _width; // Returnerar bredd.
    }

    set
    {

        // Om värdet är mindre än noll så "kastas" ett nytt undantag,
        if (value < 0)
        {
            throw new ArgumentException();
        }
        _width = value;

    }


}

protected Shape (double length, double width) // "Protected metod" med fält. Protected är skyddad ifrån andra klasser.
{

    Length = length;
    Width = width;

}

// Ny metod som skriver ut text + att den läser in vad användaren skriver in för värden i klassen "program" där vi kallar på den.
public override string ToString()

{

    return String.Format("Längd    : {0, 10:f2}\nBredd    : {1, 10:f2}\nOmkrets  : {2, 10:f2}\nArea     : {3, 10:f2}", Length, Width, Perimeter, Area); 

}



    }
}
