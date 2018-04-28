using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImposto.Imposto
{
    public class IVA_Normal: I_Imposto
    {
        public double Calcula(Orcamento montante)
        {
            return (montante.Valor + (montante.Valor * 0.23));
        }
        
    }
}
