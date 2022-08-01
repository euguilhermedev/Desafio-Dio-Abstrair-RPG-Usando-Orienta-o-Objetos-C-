using Desafio_Dotnet.src.Entities;
namespace dotnet____poo

{
    class program
    {

        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");
            
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}