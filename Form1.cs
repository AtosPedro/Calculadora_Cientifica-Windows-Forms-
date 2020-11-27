using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Cientifica
{
    public partial class Form1 : Form
    {
        string operators;
        int num1;
        int result;

        Stack<int> values = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_values.Text += bt.Text;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_values.Text == "+" || txt_values.Text == "-" || txt_values.Text == "/" || txt_values.Text == "*")
            {
                operators = txt_values.Text;

                //varificação de pilha vazia 1
                if (values.Count != 0)
                {
                    num1 = Convert.ToInt32(values.Pop());

                    //verificação de pilha vazia 2
                    if (values.Count != 0)
                    {
                        int x = Convert.ToInt32(values.Pop());

                        switch (operators)
                        {
                            case "+":
                                result = num1 + x;
                                values.Push(result);
                                result_number.Text = Convert.ToString(result);
                                txt_values.Text = "";
                                break;
                            case "-":
                                result = (num1 - x) * -1;
                                values.Push(result);
                                result_number.Text = Convert.ToString(result);
                                txt_values.Text = "";
                                break;
                            case "*":
                                result = num1 * x;
                                values.Push(result);
                                result_number.Text = Convert.ToString(result);
                                txt_values.Text = "";
                                break;
                            case "/":
                                result = x / num1;
                                values.Push(result);
                                result_number.Text = Convert.ToString(result);
                                txt_values.Text = "";
                                break;
                        }

                    }
                    // Erro - um valor e um operador
                    else
                    {
                        values.Push(num1);
                        MessageBox.Show("Um valor e um operador", "Erro", MessageBoxButtons.OK);
                        txt_values.Text = "";

                    }
                }
                //  Erro - numhum valor e um operador
                else
                {
                    MessageBox.Show("Numhum valor e um operador", "Erro", MessageBoxButtons.OK);
                    txt_values.Text = "";
                }
            }
            else
            {
                string test = txt_values.Text;

                bool isNumeric = int.TryParse(test, out _);

                if (isNumeric)
                    values.Push(Convert.ToInt32(txt_values.Text));
                else
                    MessageBox.Show("Numero Inválido", "Erro", MessageBoxButtons.OK);

                txt_values.Text = "";
            }

        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_values.Text = bt.Text;
        }

        private void btn_clear1_Click(object sender, EventArgs e)
        {
            int number = 0;
            if (values.Count != 0)
            {
                number = values.Pop();
                MessageBox.Show($"O número {number} foi retirado da pilha", "Retirar Número", MessageBoxButtons.OK);
            }

        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            if (values.Count != 0)
            {
                values.Clear();
                MessageBox.Show("Pilha esvaziada com sucesso", "Limpar a Pilha", MessageBoxButtons.OK);
            }
                
           
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Desenvolvido por: Atos Pedro Ferreira Rocha" +
                "\nContagem, MG" +
                "\nE-mail: atospedrocontato@gmail.com",
                 "Info",
                MessageBoxButtons.OK);
        }

        private void elementosNaPilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Atualmente possuem {values.Count} números na pilha", "Pilha", MessageBoxButtons.OK);
        }
    }
}
