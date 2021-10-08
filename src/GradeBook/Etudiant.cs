using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Etudiant
        {
        public int Age { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public float Note { get; set; }
        public static void Resume(List<Etudiant> ListEtudiants)
        {
            float Max = ListEtudiants.Max(x => x.Note);
            float Min = ListEtudiants.Min(x => x.Note);
            float Moy = ListEtudiants.Average(x => x.Note);
            int Size = ListEtudiants.Count;
            Console.WriteLine("la moyenne est " + $"{Moy:N2}"
                + " , le maximun :" + Max
                + " et le minimum :" + Min
                + " et le nombre d'etudiants : " + Size);
        }
        public static List<Etudiant> InitialisationTableauEtudiant()
        {
            return new()
            {
                new Etudiant() { Age = 21, Nom = "diop", Prenom = "babacar", Note = 9 },
                new Etudiant() { Age = 21, Nom = "ndiaye", Prenom = "Adama", Note = 18.2F },
                new Etudiant() { Age = 21, Nom = "Mbodji", Prenom = "Modou", Note = 16.2F }
            };
        }
    }

}
