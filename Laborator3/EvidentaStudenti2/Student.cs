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
        int[,] note;

        // contructor implicit
        public Student()
        {

        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
            note = new int[4, 15];
        }

        public void SetNote(string sirNote)
        {
            // initializare vector cu note 
            if (!sirNote.Equals(""))
            {
                string[] totalNoteAni = sirNote.Split(',');
                int k = 0;
                foreach (var nota in totalNoteAni)
                {
                    string[] note1 = nota.Split(' ');
                    int i = 0;
                    foreach (var n in note1)
                    {
                        int number;
                        bool succes = Int32.TryParse(n, out number);
                        if (succes)
                        {
                            note[k,i] = number;
                            i++;
                        }
                    }
                    k++;
                }
            }
            //note = new int[] { 1, 5, 3, 2, 4, -5 };
            // DE IMPLEMENTAT:
            // extrage note din sir si adauga in vectorul note

        }

        public void SetNote1(int[,] noteNoi)
        {
            note = noteNoi;
        }
        public string ConversieLaSir()
        {
            string sNote = "Nu exista (Nu ati apelat metoda **setNote**)";
            if (note != null)
            {
                sNote = "";
                for(int i = 0; i < 4; i++)
                {
                    sNote += string.Format("note an {0}: ", i + 1);
                    for (int j = 0; j < 15; j++)
                    {
                        
                        if (note[i, j] != 0)
                        {
                            sNote += string.Format("{0,-3}",note[i,j]);
                        }
                    }
                    sNote += "\n";
                }
            }
            string s = string.Format("Studentul {0} are notele:.... \n{1}", nume, sNote);

            return s;
        }
        /*
        public void NumarareNote(out int valSub5,out int valPeste5)
        {

        }
        */
    }
}
