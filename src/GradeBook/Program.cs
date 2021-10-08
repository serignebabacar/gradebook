using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        //private static string Chaine = null;
        static void Main(string[] args)
        {
            //if (args.Length == 0)
            //{
            //    args = new[] { "ababacar", "baba" };
            //}
            //Chaine = args[0];
            //Console.WriteLine("Hello " + Chaine + " !");
            //List<Etudiant> ListEtudiants = Etudiant.InitialisationTableauEtudiant();
            //Etudiant.Resume(ListEtudiants);
            var book = new Book("Test");
            var input="";
            while(true)
            {
                Console.WriteLine("entrer un chiffre ou Q pour quitter");
                input = Console.ReadLine();
                if (input == "Q")
                {
                    break;
                }
                try
                {
                    var value = double.Parse(input);
                    book.AddGrade(value);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            } 
            book.ShowStatistics();
        }

    }
}

