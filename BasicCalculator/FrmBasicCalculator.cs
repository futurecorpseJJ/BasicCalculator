using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            textBox_Result.Text = "Total" + Environment.NewLine+ "000000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float number1, number2;
            if (!float.TryParse(textBox_Number1.Text, out number1))
            {
                MessageBox.Show("First Number Invalid");
                return;
            }
            if (!float.TryParse(textBox_Number2.Text, out number2))
            {
                MessageBox.Show("Second Number Invalid");
                return;
            }
            string oper = cmBox_Operator.Text;
            switch (oper)
            {
                case "+":
                    BasicComputation.BasicCompute add = new BasicComputation.BasicCompute();
                    textBox_Result.Text = "Total" + Environment.NewLine + Convert.ToString(add.Addition(Convert.ToInt16(textBox_Number1.Text), Convert.ToInt16(textBox_Number2.Text)));
                    break;
                case "-":
                    BasicComputation.BasicCompute subtract = new BasicComputation.BasicCompute();
                    textBox_Result.Text = "Total" + Environment.NewLine + Convert.ToString(subtract.Subtraction(Convert.ToInt16(textBox_Number1.Text), Convert.ToInt16(textBox_Number2.Text)));
                    break;
                case "*":
                    BasicComputation.BasicCompute multiply = new BasicComputation.BasicCompute();
                    textBox_Result.Text = "Total" + Environment.NewLine + Convert.ToString(multiply.Multiplication(Convert.ToInt16(textBox_Number1.Text), Convert.ToInt16(textBox_Number2.Text)));
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        MessageBox.Show("Division by ZERO");
                    }
                    else
                    {
                        BasicComputation.BasicCompute divide = new BasicComputation.BasicCompute();
                        textBox_Result.Text = "Total" + Environment.NewLine + Convert.ToString(divide.Division(Convert.ToInt16(textBox_Number1.Text), Convert.ToInt16(textBox_Number2.Text)));
                    }
                    break;
                default:
                    MessageBox.Show("Operator is invalid");
                    break;
            }
        }
    }
}
