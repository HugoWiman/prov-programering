using System;

namespace prov_programering
{
    class Program
    {
        static void Main(string[] args)

        {
            int amountOfCars =  1;
           
            Console.WriteLine("Hur många billar vill du skapa?");
            int numbercars = Convert.ToInt32(Console.ReadLine());
            // här har jag gjort så att den tar i det som ett tal.


            while  (numbercars == 0)
            {
                Console.WriteLine("Error inte mindre än 1");

                numbercars = Convert.ToInt32(Console.ReadLine());

                //här får man error ifall man skriver talet 0

            // han tyvär inte skappa så att den tar emot ifall man skriver något annat än ett tal

            }



            if ( numbercars != 0)
            {
            Console.WriteLine( "what car do you want to search first");
                while (numbercars > amountOfCars)
                {
                    car amountOfcars = new car();
                  
                    
                    
                    Console.ReadKey();
                    amountOfCars++;
                    
                    //här skappar den så många olika klasser bilar som man skrivit tidgare han tyävr inte klart med det här .
                }
                
            }
            
            
           
           
             
            
           
        }
    }
}
