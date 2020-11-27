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

                        if (operators == "+")
                        {
                            result = num1 + x;
                            values.Push(result);
                            result_number.Text = Convert.ToString(result);
                            txt_values.Text = "";
                        }
                        else if (operators == "-")
                        {
                            result = (num1 - x) * -1;                            
                            values.Push(result);
                            result_number.Text = Convert.ToString(result);
                            txt_values.Text = "";

                        }
                        else if (operators == "*")
                        {
                            result = num1 * x;
                            values.Push(result);
                            result_number.Text = Convert.ToString(result);
                            txt_values.Text = "";
                        }
                        else if (operators == "/")
                        {
                            result = x / num1;
                            values.Push(result);
                            result_number.Text = Convert.ToString(result);
                            txt_values.Text = "";
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
                values.Push(Convert.ToInt32(txt_values.Text));

                txt_values.Text = "";
            }

        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_values.Text = bt.Text;
        }
    }
}
