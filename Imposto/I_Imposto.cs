using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjImposto.Imposto
{
    public interface I_Imposto
    {
        double Calcula(Orcamento montante);
    }
}
