using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rateio
{
    class MoedaConverter
    {
        public void ConverterParaMoeda(object sender)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = ConverterParaMoeda(textBox.Text);
        }

        public string ConverterParaMoeda(string texto)
        {
            string retorno;
            if (texto.Length > 0 && texto.Contains("$")) return texto;
            var count = texto.Count(x => x == '.');
            if (count == 1)
                texto = texto.Replace(".", ",");
            Double value;
            if (Double.TryParse(texto, out value))
            {
                retorno = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            }
            else
                retorno = String.Empty;
            return retorno;
        }

        public double ConverterDeMoeda(TextBox textBox)
        {
            return ConverterDeMoeda(textBox.Text);
        }

        public double ConverterDeMoeda(string text)
        {
            double value = 0.0;
            if (text == "")
                return value;
            try
            {
                value = Convert.ToDouble(Double.Parse(text, System.Globalization.NumberStyles.Currency));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("O valor não pode ser zero. Erro: " + fe.Message);
            }
            return value;
        }
    }
}
