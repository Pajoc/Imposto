using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImposto.Imposto
{
    public class Calculador
    {
        //1 única responsabilidade-> COESÃO
        public void RealizaCalculo(Orcamento orcamento, I_Imposto tipoImposto)
        {
            Console.WriteLine ("Valor:"+tipoImposto.Calcula(orcamento));
        }
    }
}
