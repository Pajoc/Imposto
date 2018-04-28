using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImposto.Imposto
{
    class IVA_Test : I_Imposto
    {
        public double Calcula(Orcamento montante) => montante.Valor + montante.Valor * 0.3;
    }
}
