using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaStudenti2
{
    public class Student
    {
        // date membre private
        string nume;
        int[] note;

        // contructor implicit
        public Student()
        {

        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
        }

        public void SetNote(string sirNote)
        {
            // initializare vector cu note 
            if (!sirNote.Equals(""))
            {
                string[] note1 = sirNote.Split(' ');
                note = new int[note1.Length];
                int i = 0;
                foreach (var nota in note1)
                {
                    int number;
                    bool succes = Int32.TryParse(nota, out number);
                    if (succes)
                    {
                        note[i] = number;
                        i++;
                    }
                }
            }
            //note = new int[] { 1, 5, 3, 2, 4, -5 };
            // DE IMPLEMENTAT:
            // extrage note din sir si adauga in vectorul note

        }

        public void SetNote1(int[] noteNoi)
        {
            note = noteNoi;
        }
        public string ConversieLaSir()
        {
            string sNote = "Nu exista (Nu ati apelat metoda **setNote**)";
            if (note != null)
            {
                sNote = string.Join(",", note);
            }
            string s = string.Format("Studentul {0} are notele:.... {1}", nume, sNote);

            return s;
        }
        /*
        public void NumarareNote(out int valSub5,out int valPeste5)
        {

        }
        */
    }
}
