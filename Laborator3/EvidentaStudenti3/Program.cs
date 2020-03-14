using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaStudenti3
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine("S:Citire note de la tastatura ca un sir de caractere");
            Console.WriteLine("T:Citire note de la tastarura (cate o nota pe rand)");
            Console.WriteLine("C:Citire note de la linia de comanda");
            Console.WriteLine("A:Afisare note");
            Console.WriteLine("I:Info autor");
            Console.WriteLine("X:Iesire");
        }
        static int[][] citireNote()
        {
            int nrNote;
            int[][]noteCitite = new int[4][];
            for (int k = 1; k <= 4; k++)
            {
                Console.WriteLine("Introduceti numarul de note din anul {0} :", k);
                nrNote = Convert.ToInt32(Console.ReadLine());
                noteCitite[k - 1] = new int[nrNote];
                for (int i = 0; i < nrNote; i++)
                {
                    noteCitite[k - 1][i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return noteCitite;
        }

        static void Main(string[] args)
        {
            string optiune, noteString = "";
            bool ok = true;
            Student s = new Student("Ionescu");
            while (ok == true)
            {
                menu();
                optiune = Console.ReadLine();
                switch (optiune)
                {
                    case "S":
                        noteString = Console.ReadLine();
                        s.SetNote(noteString);
                        break;
                    case "T":
                        s.SetNote1(citireNote());
                        break;
                    case "C":
                        s.SetNote(String.Join(" ", args));
                        break;
                    case "A":
                        Console.WriteLine(s.ConversieLaSir());
                        break;
                    case "I":
                        Console.WriteLine("Autor: Iulian - Elisei!");
                        break;
                    case "X":
                        ok = false;
                        break;

                }
            }

            Console.ReadKey();
        }
    }
}
