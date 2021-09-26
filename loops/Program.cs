using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
           double grade;
           bool MenuActive = true;
           string Continue;
           int i = 1;
           Console.WriteLine("Registre una calificación: ");
           grade = Convert.ToDouble(Console.ReadLine());
           if (grade <= 10 && grade >= 0)
           {
           while (MenuActive)
               {
                    Console.WriteLine("¿Desea Registrar otra calificación? S/N");
                    Continue = Console.ReadLine();
                    if (Continue == "S")
           {
                   Console.WriteLine("Registre una calificación: ");
                   double gradeTwo = Convert.ToDouble(Console.ReadLine());
                   if (gradeTwo <= 10 && gradeTwo >= 0)
                   {
                    grade = grade + gradeTwo;
                    i++; 
                    Console.WriteLine(grade);
                    Console.WriteLine("Total de calificaciones registradas es " + i);
                   } else 
                   {
                       Console.WriteLine("El dato proporcionado no es valido.");
                   }
                  
           } else break;
               } 
                
             Console.WriteLine("El promedio es " + grade / i);
           } else {
               Console.WriteLine("El dato proporcionado no es valido.");
           }
          
        }
       
    }
}
