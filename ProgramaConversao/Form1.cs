using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoConversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValorConvert.Text.ToUpper();
            short base1 = 0, base2 = 0;
            string caracteres = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";      
            if (comboBoxBaseValor.SelectedIndex == 0)
            {
                base1 = 2;
            }
            else if (comboBoxBaseValor.SelectedIndex == 1)
            {
                base1 = 8;
            }
            else if (comboBoxBaseValor.SelectedIndex == 2)
            {
                base1 = 10;
            }
            else if (comboBoxBaseValor.SelectedIndex == 3)
            {
                base1 = 16;
            }
            if (comboBoxBaseConvert.SelectedIndex == 0)
            {
                base2 = 2;
            }
            else if (comboBoxBaseConvert.SelectedIndex == 1)
            {
                base2 = 8;
            }
            else if (comboBoxBaseConvert.SelectedIndex == 2)
            {
                base2 = 10;
            }
            else if (comboBoxBaseConvert.SelectedIndex == 3)
            {
                base2 = 16;
            }
            if (!(valor1 != "" && base1 != 0 && base2 != 0))
            {
                MessageBox.Show("Selecione alguma base ou preencha um número valido para ser convertido!", "Erro");
                return;
            }
            for (int i = 0; i < valor1.Trim().Length; i++)
            {

                for (int x = base1; x < caracteres.Length; x++)
                {

                    if (!valor1.Contains(caracteres[x]))
                    {
                        
                    }

                    else
                    {
                        MessageBox.Show("Valor fora da faixa de inteiro 64 bits ou contém dígitos inválidos", "Erro");
                        return;
                    }
                }

            }
            long resul = baseToDecimal(valor1, base1);
            if (base2 == 10)
            {
                richTextBoxResultado.AppendText(valor1 + " Convertido para " + comboBoxBaseConvert.SelectedItem.ToString() + " " + resul.ToString() + Environment.NewLine);
            }
            else
            {
                richTextBoxResultado.AppendText(valor1 + " Convertido para " + comboBoxBaseConvert.SelectedItem.ToString() + " " + decimalToBase(resul, base2) + Environment.NewLine);
            }


        }
        private string decimalToBase(long n, short b)
        {
            string resultado = null;
            while (n / b >= 1)
            {
                if (b == 16)
                {
                    if ((n % b) == 10)
                    {
                        resultado = "A" + resultado;
                    }
                    else if ((n % b) == 11)
                    {
                        resultado = "B" + resultado;
                    }
                    else if ((n % b) == 12)
                    {
                        resultado = "C" + resultado;
                    }
                    else if ((n % b) == 13)
                    {
                        resultado = "D" + resultado;
                    }
                    else if ((n % b) == 14)
                    {
                        resultado = "E" + resultado;
                    }
                    else if ((n % b) == 15)
                    {
                        resultado = "F" + resultado;
                    }
                    else
                    {
                        resultado = Convert.ToString(n % b) + resultado;
                    }
                }
                else
                {
                    resultado = Convert.ToString(n % b) + resultado;
                }

                n = n / b;
            }
            resultado = Convert.ToString(n) + resultado;

            return resultado;
        }
        private long baseToDecimal(string n, short b)

        {
            long resultado = 0;
            long num = 0;
            for (int i = 1; i <= n.Length; i++)
            {
                string ultimo = n[n.Length - i].ToString();
                if (ultimo == "A")
                {
                    num = 10;
                }
                else if (ultimo == "B")
                {
                    num = 11;
                }
                else if (ultimo == "C")
                {
                    num = 12;
                }
                else if (ultimo == "D")
                {
                    num = 13;
                }
                else if (ultimo == "E")
                {
                    num = 14;
                }
                else if (ultimo == "F")
                {
                    num = 15;
                }
                else
                {
                    num = Convert.ToInt64(ultimo);
                }

                resultado += num * (int)Math.Pow(b, i - 1);
            }

            return resultado;
        }

    }
}
