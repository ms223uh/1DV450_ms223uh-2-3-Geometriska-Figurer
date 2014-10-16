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
                
                Console.Clear(); // Rensar konsolen på information/text.

                ViewMenu();     //  Kallar på metoden "ViewMenu".
                int userSelection;   // Skapar ett fält för användarval i menyn. Vi använder oss av typen "int" för valen är heltal 0-2.
                string choice = Console.ReadLine(); //  Applikationen väljer det nummer som användaren matar in, "choice".

                try
                {
                    userSelection = int.Parse(choice);  // "userSelection" = med användaren väljer "choise".


                    // Hämtar metoden "CreateShape".
                    switch (userSelection) // Switch-satsen = "userSelection".
                    {
                        case 0:  // Exit.
                            return;

                        case 1:  // Användaren väljer "Ellipse".
                            ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                            break;

                        case 2:  // Användaren väljer "Rectangle".
                            ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                            break;


                        default:  // Inget alternativ utan visar enbart text i switch-satsen.
                            Console.WriteLine("Var snäll och ange ett av valen 0-2!");
                            break;
                    }
                    // Text till användaren.
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nTryck valfri tangent för ny uträkning - ESC avslutar");
                    Console.ResetColor();
                }


                catch
                {
                    // Fångar alla felmeddelande. Om användaren skulle skriva in fel värde. {0} = med användaren skriver in.

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL!\n'{0}' är inte ett menyalternativ.", choice);
                    Console.ResetColor();

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\n\nVar god att försök igen! \nTryck valfri tangent för att komma tillbaka till menyval - ESC avslutar", choice);
                    Console.ResetColor();
                    
                    
                }
           
            
            }
            // Så länge användaren trycker in en tangent som inte är "ESC" så fortsätter applikationen att köra.
           //  "ESC" avslutar applikationen.
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);  
        
        }
            

        // Ny metod där vi skapar våra former.
       //  Vi använder oss av en switch-sats där de olika casen kommer att väljas beroende på vilket val användaren gör i metoden "Main".
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

            Shape newShape = null;  // Den nya formen nollställs så att vi kan mata in värden.
            
            double length = ReadDoubleGreaterThanZero(string.Format("Ange längden på {0}:", shapeType));  //  Läser in värdet användaren väljer att mata in.
            double width = ReadDoubleGreaterThanZero(string.Format("Ange bredden på {0}:", shapeType));   //  Läser in värdet användaren väljer att mata in.

            // Om användaren väljer "Rectangle" så skapas en ny form & värdena ifrån fälten ovan läses in.
            if (shapeType == ShapeType.Rectangle)
            {
            newShape = new Rectangle(length, width);
            }

            // Om användaren väljer "Ellipse" så skapas en ny form & värdena ifrån fälten ovan läses in.
            if (shapeType == ShapeType.Ellipse)
            {
            newShape = new Ellipse(length, width);
            }

            return newShape; // Vi returnerar/skapar "newShape".

            }






        // Skapar en metod som hjälper oss att kontrollera om användaren skriver in ett större tal än 0 på längd & bredd i klassen "CreateShape".
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double size;

            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();  // Läser in värdet som användaren anger.
                
                try
                {

                    size = double.Parse(userInput);
                    if (size <= 0) // "Size" måste vara större än 0. "Size" = värdet som användaren skriver in.
                    {
                        // Om värdet inte är större än 0 så skicas ett meddelande till användaren.
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("FEL! Ange ett tal större än 0!");
                        Console.ResetColor();
                    }

                    return size; // Returnerar "size".

                }

                catch

                {
                    // Om användaren skriver in fel värde eller format så skickas ett meddelande.
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! '{0}' är inte rätt format. Ange en siffra större än noll!", userInput);
                    Console.ResetColor();
                }
            }
        }







        // Presentation av meny.
        private static void ViewMenu()
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("║              Geometriska Figurer               ║");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine("0 - Avsluta");
            Console.WriteLine("1 - Ellipse");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("══════════════════════════════════════════════════");
            Console.WriteLine("Ange ett nummer i menyn [0-2]");
        
        }

        // Presentation av detaljer.
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║                    Detaljer                    ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(shape.ToString()); // Kallar på metoden "ToString" i klassen "Shape".
            Console.WriteLine("══════════════════════════════════════════════════");
        }

    }

    // Vi skapar en metod som hämtar formler ifrån de respektive klasserna när användaren gör ett val i "main" om vilken form den vill ha.
    public enum ShapeType
    {
        Ellipse, Rectangle
    }

}
