using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic.SalaLogic a = new Logic.SalaLogic();
            var view = a.GetSalaView();

            Console.WriteLine("Nombre sala: " + view.Nombre);
            
            foreach(var asientos in view.Asientos)
            {
                Console.WriteLine(asientos.Nombre + " Libre : " + asientos.Libre);
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
