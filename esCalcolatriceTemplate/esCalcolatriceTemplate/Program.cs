using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esCalcolatriceTemplate
{
    class Program
    {
        static void Main(string[] args)
        {

            CalcolatriceStandard cst = new CalcolatriceStandard();
            cst.Calcola(5,10);

            Console.WriteLine();

            CalcolatriceSomma cso = new CalcolatriceSomma();
            cso.Calcola(5, 10);

            Console.ReadLine();

            
        }
    }

    abstract class Calcolatrice:ICalcolatrice
    {
        protected abstract void Moltiplicazione(int n1,int n2);

        public void Calcola(int n1, int n2)
        {
            Moltiplicazione(n1, n2);
        }
    }

    interface ICalcolatrice
    {

        void Calcola(int n1,int n2);
    }

    class CalcolatriceStandard : Calcolatrice
    {
        protected override void Moltiplicazione(int n1,int n2)
        {
            Console.WriteLine(n1 * n2);
        }
    }

    class CalcolatriceSomma: Calcolatrice
    {
        protected override void Moltiplicazione(int n1, int n2)
        {
            int result=0;

            for(int i=0; i<n2;i++)
            {
                result += n1;
            }

            Console.WriteLine(result);
        }
    }
}
