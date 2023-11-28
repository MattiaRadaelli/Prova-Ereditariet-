using Prova_Ereditarietà;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Ereditarietà
{
    class Quadrato
    {
        protected double _lato;

        public Quadrato(double lato)
        {
            _lato = lato;
        }
        public void MostraA()
        {
            Console.WriteLine($"L'area è {_lato * _lato} mentre il perimetro {_lato * 4}");
        }
    }
    
    class Cubo : Quadrato
    {
            public Cubo(double lato) : base(lato) 
            {
                _lato = lato;
            }
            public void MostraB()
            {
                Console.WriteLine($"il volume è {_lato * _lato * _lato} mentre la superficie {(_lato * 4) * 24}");
            }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserici il lato");
            double latoo = double.Parse(Console.ReadLine());
            Quadrato AA = new Quadrato(latoo);
            Cubo BB = new Cubo(latoo);
            Console.Clear();
            AA.MostraA();
            BB.MostraB();
        }
    }
}

