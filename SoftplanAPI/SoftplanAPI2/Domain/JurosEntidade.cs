using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SoftplanAPI2.Model
{
    public class JurosEntidade
    {
        [Required]
        public decimal valorInicial { get; set; }
        [Required]
        public int meses { get; set; }
       
        public decimal taxajuros { get; set; }
        public decimal valorFinal { get; set; }

        public JurosEntidade()
        {

        }

        public JurosEntidade (JurosEntidade jurosEntidade)
        {
            double x;
            double y;
            decimal calculo1; 

            x = (double)((decimal)1 + jurosEntidade.taxajuros);
            y = (double)jurosEntidade.meses;

            calculo1 = (decimal)Math.Pow(x, y);
           
            this.valorFinal = Decimal.Parse((calculo1 * jurosEntidade.valorInicial).ToString("##.##"));

        }

    }
}
