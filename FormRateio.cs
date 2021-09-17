using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rateio
{
    /// <summary>Class <c>FormRateio</c> calculates taxes for each 
    /// operation.</summary>
    /// Created on: 2021-06-22
    ///
    public partial class FormRateio : Form
    {
        private MoedaConverter moedaConverter;
        private Boolean anularEnterAsTab = false;
        public FormRateio()
        {
            InitializeComponent();
            moedaConverter = new MoedaConverter();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarAtivo();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            listViewAtivos.Items.RemoveAt(listViewAtivos.SelectedIndices[0]);
            LimparAtivo();
        }

        private void listViewAtivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAtivos.SelectedItems.Count > 0)
            {
                textBoxTicket.Text = listViewAtivos.SelectedItems[0].SubItems[0].Text;
                textBoxValor.Text = listViewAtivos.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparAtivo();
        }

        private void buttonZerar_Click(object sender, EventArgs e)
        {            
            textBoxVendas.Clear();
            textBoxCompras.Clear();
            textBoxCorretagem.Clear();
            textBoxValorLiquido.Clear();
            textBoxCustos.Clear();
            LimparAtivo();
            listViewAtivos.Items.Clear();
            textBoxVendas.Focus();
        }

        private void textBoxValor_Leave(object sender, EventArgs e)
        {
            moedaConverter.ConverterParaMoeda(sender);
        }

        private void textBoxCompras_Leave(object sender, EventArgs e)
        {
            moedaConverter.ConverterParaMoeda(sender);
        }

        private void textBoxVendas_Leave(object sender, EventArgs e)
        {
            moedaConverter.ConverterParaMoeda(sender);
        }

        private void textBoxCorretagem_Leave(object sender, EventArgs e)
        {
            moedaConverter.ConverterParaMoeda(sender);
        }

        private void textBoxValorLiquido_Leave(object sender, EventArgs e)
        {
            moedaConverter.ConverterParaMoeda(sender);

            double totalCompras = moedaConverter.ConverterDeMoeda(textBoxCompras);
            double totalVendas = moedaConverter.ConverterDeMoeda(textBoxVendas);
            double valorLiquido = moedaConverter.ConverterDeMoeda(textBoxValorLiquido);
            double custoTotal = Math.Abs(valorLiquido - Math.Abs(totalVendas - totalCompras));
            textBoxCustos.Text = moedaConverter.ConverterParaMoeda(custoTotal.ToString());
        }

        private void buttonRatear_Click(object sender, EventArgs e)
        {
            if (! ValidarRateio())
            {
                return;
            }
            RateioVO rateioVO = new RateioVO();
            rateioVO.TotalCompras = moedaConverter.ConverterDeMoeda(textBoxCompras);
            rateioVO.ValorLiquido = moedaConverter.ConverterDeMoeda(textBoxValorLiquido);
            rateioVO.TotalVendas = moedaConverter.ConverterDeMoeda(textBoxVendas);
            rateioVO.Corretagem = moedaConverter.ConverterDeMoeda(textBoxCorretagem);
            rateioVO.Items = listViewAtivos.Items;

            textBoxCustos.Text = moedaConverter.ConverterParaMoeda(rateioVO.CustoTotal.ToString());

            RateioService rateioService = new RateioService();
            rateioService.RatearCustos(rateioVO);
        }

        private Boolean ValidarRateio()
        {
            double totalCompras = moedaConverter.ConverterDeMoeda(textBoxCompras);
            double totalVendas = moedaConverter.ConverterDeMoeda(textBoxVendas);
            if (totalCompras == 0.0 && totalVendas == 0.0)
            {
                MessageBox.Show("O total de compras ou o total de vendas deve ser maior que zero", "Rateio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxVendas.Focus();
                return false;
            }

            int quantidadeAtivos = listViewAtivos.Items.Count;
            if (quantidadeAtivos == 0)
            {
                MessageBox.Show("Nenhuma operação foi incluída", "Rateio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTicket.Focus();
                return false;
            }

            double totalOperacao = 0.0;
            for (int i = 0; i < listViewAtivos.Items.Count; i++)
            {
                double valor = moedaConverter.ConverterDeMoeda(listViewAtivos.Items[i].SubItems[1].Text);
                totalOperacao += valor;
            }
            if (totalOperacao != (totalCompras + totalVendas))
            {
                MessageBox.Show("O total da operação [" + totalOperacao.ToString() + "] não corresponde a soma das compras e vendas [" 
                    + (totalCompras + totalVendas).ToString(), "Rateio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter) && !this.anularEnterAsTab)
            {
                SendKeys.Send("{TAB}");
            }
            anularEnterAsTab = false;

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBoxValor_KeyDown(object sender, KeyEventArgs e)
        {
            anularEnterAsTab = true;
            if (e.KeyCode == Keys.Enter)
            {
                moedaConverter.ConverterParaMoeda(sender);
                AdicionarAtivo();
            }
        }

        private void AdicionarAtivo()
        {
            if (textBoxTicket.Text == "")
            {
                MessageBox.Show("O Ticket não pode ser vazio", "Rateio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTicket.Focus();
                return;
            }
            string[] operacoes = new string[3];
            operacoes[0] = textBoxTicket.Text;
            operacoes[1] = textBoxValor.Text;
            operacoes[2] = moedaConverter.ConverterParaMoeda("0");

            ListViewItem listViewItem = new ListViewItem(operacoes);
            listViewAtivos.Items.Add(listViewItem);
            LimparAtivo();
        }

        private void LimparAtivo()
        {
            textBoxTicket.Clear();
            textBoxValor.Clear();
            textBoxTicket.Focus();            
        }
    }

}
