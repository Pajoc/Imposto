using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImposto.Imposto
{
    public class IVA_Luxo : I_Imposto
    {
        public double Calcula(Orcamento montante)=> montante.Valor + montante.Valor * 0.4;
    }
}
