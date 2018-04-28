using ProjImposto.Imposto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImposto
{
    class Program
    {
        public static object Calculador { get; private set; }

        static void Main(string[] args)
        {
            Orcamento objOrc = new Orcamento(5000);
            Calculador objCalculador = new Calculador();
            I_Imposto IVA_N = new IVA_Normal();

            objCalculador.RealizaCalculo(objOrc, new IVA_Isento());
            objCalculador.RealizaCalculo(objOrc, IVA_N);
            objCalculador.RealizaCalculo(objOrc, new IVA_Luxo());
            Console.ReadKey();

        }
    }
}
