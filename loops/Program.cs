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
           int i = 1; // Esta variable lleva la cuenta de los datos registrados, al recién registrarla se le asigna un valor de 1 pues el primer dato se obtiene fuera del ciclo.
           Console.WriteLine("Registre una calificación: ");
           grade = Convert.ToDouble(Console.ReadLine());
           if (grade <= 10 && grade >= 0) // Se agrega validación de datos, en caso de que el usuario registre algún dato no valido.
           {
           while (MenuActive)
               {
                    Console.WriteLine("¿Desea Registrar otra calificación? S/N");
                    Continue = Console.ReadLine();
                    if (Continue == "S")
           {
                   Console.WriteLine("Registre una calificación: ");
                   double gradeTwo = Convert.ToDouble(Console.ReadLine()); // Se genera una segunda variable, dentro del ciclo de 
                                                                          //repetición para no sobre escribir el primer dato obtenido.
                   if (gradeTwo <= 10 && gradeTwo >= 0) // Se agrega validación de datos, en caso de que el usuario registre algún dato no valido.
                   {
                    grade = grade + gradeTwo; // Al sumarle a la primer variable de calificación el número de la segunda, se lleva la cuenta para el promedio y
                                             //la segunda variable queda libre para ser sobreescrita cada que corra el ciclo. 
                    i++; // Cada que corre el ciclo, aumenta la cuenta. Este número se utilizará para sacar el promedio.
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
