using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rateio
{
    public class RateioVO
    {
        public double TotalCompras { get; set; }
        public double ValorLiquido { get; set; }
        public double TotalVendas { get; set; }
        public double Corretagem { get; set; }
        public ListView.ListViewItemCollection Items { get; set; }

        public double CustoTotal {
            get { return Math.Abs(ValorLiquido - Math.Abs(TotalVendas - TotalCompras)); }
        }

        public double CustoExcetoCorretagem
        {
            get { return CustoTotal - (Corretagem * Items.Count); }
        }

    }
}
