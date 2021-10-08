using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        private List<double> Grades { get; set; }
        public string Name { get; set; }

        public string GetName()
        {
            return Name;
        }

        public Book(string name)
        {
            this.Name = name;
            Grades = new();
        }

        public void AddGrade(double grade)
        {
            if(grade>=0 && grade <= 20)
            {
                Grades.Add(grade);
            }else
            {
                throw new ArgumentException($"Invalide {nameof(grade)}");
            }
        }
        public void AddGrade(char c)
        {
            switch (c)
            {
                case 'A':
                    AddGrade(10);
                    break;
                case 'B':
                    AddGrade(11);
                    break;
                case 'C':
                    AddGrade(11);
                    break;
                default:
                    break;
            }
        }
        public void AddGrade(string c)
        {
            switch (c)
            {
                case "dix":
                    AddGrade(10);
                    break;
                case "onze":
                    AddGrade(11);
                    break;
                case "douze":
                    AddGrade(11);
                    break;
                default:
                    break;
            }
        }

        public List<double> GetGrades()
        {
            return Grades;
        }
        public void DeleteGrade(double grade)
        {
            Grades.Remove(grade);
        }
        public void ShowStatistics()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Nom du Livre  : " + Name);
            }
            if (Grades.Count != 0)
            {
                Console.Write("Les notes sont :");
                Grades.ForEach(x => {
                    Console.Write(x + " ");
                });
                Console.WriteLine("\nLe nombre de notes  :" + Grades.Count + "\nLa moyenne est " + MoyenneListe() 
                    + "\nle maximum est  : " + MaxListe() + " \nle minimum : " + MinListe());
            }
        }
        public double MoyenneListe()
        {
            return Grades.Average(x => x);
        }

        public double MaxListe()
        {
            return Grades.Max(x => x);
        }
        public double MinListe()
        {
            return Grades.Min(x => x);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public Statistics GetStatistics()
        {
            char Level;
            switch (MoyenneListe())
            {
                case var d when d >= 18:
                    Level = 'A';
                    break;
                case var d when d >= 16:
                    Level = 'B';
                    break;
                case var d when d >= 14:
                    Level = 'C';
                    break;
                case var d when d >= 12:
                    Level = 'D';
                    break;
                default:
                    Level = 'E';
                    break;
            }
            return new Statistics() { Average = MoyenneListe(), HighValue = MaxListe(),
                LowValue = MinListe(), Level = Level
            };
        }
    }
}
