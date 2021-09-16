using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rateio
{
    class RateioService
    {
        public void RatearCustos(RateioVO rateioVO)
        {
            MoedaConverter moedaConverter = new MoedaConverter();
            double custoRestante = rateioVO.CustoTotal;
            for (int i = 0; i < rateioVO.Items.Count; i++)
            {
                string ticket = rateioVO.Items[i].SubItems[0].Text;
                double valor = moedaConverter.ConverterDeMoeda(rateioVO.Items[i].SubItems[1].Text);
                if (valor == 0.0) return;
                double rateio = 0.0;
                // calcula rateio
                if ((i + 1) == rateioVO.Items.Count)
                {
                    rateio = custoRestante;
                }
                else
                {
                    rateio = (valor / (rateioVO.TotalCompras + rateioVO.TotalVendas)) * rateioVO.CustoExcetoCorretagem + rateioVO.Corretagem;
                    rateio = Math.Round(rateio, 2);
                    custoRestante -= rateio;
                }
                rateioVO.Items[i].SubItems[2].Text = moedaConverter.ConverterParaMoeda(rateio.ToString());
            }
        }
    }
}
