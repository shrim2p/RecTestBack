using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECTESTBACK
{
    public class Filtro
    {
        public int FiltrarNome(List<string> Nomes)
        {
            return Nomes.Where(x => x.StartsWith("G")).Count();
        }
    }
}