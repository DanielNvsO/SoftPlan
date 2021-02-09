using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftplanAPI1.Model
{
    public class TaxasEntidade
    {
        public decimal taxaJuros { get; set; }

        public TaxasEntidade()
        {
            taxaJuros = (decimal)0.01;
        }
    }
}
