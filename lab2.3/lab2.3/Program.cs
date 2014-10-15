using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.Clear();

                ViewMenu();
                int userSelection;
                string choice = Console.ReadLine();

                try
                {
                    userSelection = int.Parse(choice);


                    switch (userSelection)
                    {
                        case 0:
                            return;

                        case 1:
                            ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                            break;

                        case 2:
                            ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                            break;


                        default:
                            Console.WriteLine("Var snäll och ange ett av valen 0-2!");
                            break;
                    }

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nTryck valfri tangent för ny uträkning - ESC avslutar");
                    Console.ResetColor();
                }


                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL!\n'{0}' är inte ett menyalternativ.", choice);
                    Console.ResetColor();

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\n\nVar god att försök igen! \nTryck valfri tangent för att komma tillbaka till menyval - ESC avslutar", choice);
                    Console.ResetColor();
                    
                    
                }
           
            
            }

            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        
        }
            


        private static Shape CreateShape(ShapeType shapeType)
        {

            switch (shapeType)
            { 
            
                case ShapeType.Ellipse:
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║                    Ellipse                     ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();
                break;

                case ShapeType.Rectangle:
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║                    Rectangle                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();
                break;
            

            }

            Shape newShape = null;
            
            double length = ReadDoubleGreaterThanZero(string.Format("Ange längden på {0}:", shapeType));
            double width = ReadDoubleGreaterThanZero(string.Format("Ange bredden på {0}:", shapeType));

            if (shapeType == ShapeType.Rectangle)
            {
            newShape = new Rectangle(length, width);
            }
            
            if (shapeType == ShapeType.Ellipse)
            {
            newShape = new Ellipse(length, width);
            }

            return newShape; 

            }







        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double size;

            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();
                
                try
                {

                    size = double.Parse(userInput);
                    if (size <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("FEL! Ange ett tal större än 0!");
                        Console.ResetColor();
                    }

                    return size; 

                }

                catch

                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! '{0}' är inte rätt format. Ange en siffra större än noll!", userInput);
                    Console.ResetColor();
                }
            }
        }








        private static void ViewMenu()
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("║              Geometriska Figurer               ║");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine("0 - Avsluta.");
            Console.WriteLine("1 - Ellipse");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("══════════════════════════════════════════════════");
            Console.WriteLine("Ange ett nummer i menyn [0-2]");
        
        }

        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║                    Detaljer                    ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine("══════════════════════════════════════════════════");
        }

    }

    public enum ShapeType
    {
        Ellipse, Rectangle
    }

}
