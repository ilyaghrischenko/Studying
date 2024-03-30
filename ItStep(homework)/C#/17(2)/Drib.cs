using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _17_2_
{
    public class Drib
    {
        public int Chiselnik { get; set; }
        public int Znamenik { get; set; }

        public Drib()
        {
            Chiselnik = 0;
            Znamenik = 0;
        }
        public Drib(int chiselnik, int znamenik)
        {
            Chiselnik = chiselnik;
            Znamenik = znamenik;
        }

        public void Show()
        {
            WriteLine(this);
        }

        public override string ToString()
        {
            return $"Chiselnik: {Chiselnik}, Znamenik: {Znamenik}";
        }
    }
}
