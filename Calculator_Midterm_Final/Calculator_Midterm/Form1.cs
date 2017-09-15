using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Midterm
{
	public partial class Form1 : Form
	{
		string input = string.Empty;
		string num1 = string.Empty;
		string num2 = string.Empty;
		char operation;
		double result_value = 0.0;
		Boolean equal_click = false;
		Boolean op_click = false;
		double memory_store = 0;
		String ope;

		public Form1()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
		public void checkequal_click()
		{
			if (equal_click == true)
			{
				input = string.Empty;
				num1 = string.Empty;
				num2 = string.Empty;
				// if the opertor is click after equal the result then save to num1
				if (op_click == true)
					num1 = result.Text;
				result.Clear();
				result_value = 0;
			}
			equal_click = false;
		}
		
		private void number_function(String num)
		{
			checkequal_click();

			result.Text = "";
			input += num;
			result.Text += input;
			equal_click = false;
			
		}
		private void operation_function(Char ope)
		{
			op_click = true;
			checkequal_click();
			//check that it have operation or not
			if (op_click == true && !num1.Equals(""))
			{
				math_function();
			}
			op_click = false;
			equal_click = false;
			num1 = input;
			operation = ope;
			input = string.Empty;

		}
		private void math_function()
		{
			num2 = input;
			double number1, number2;
			double.TryParse(num1, out number1);
			double.TryParse(num2, out number2);
			if (operation == '+')
			{
				result_value = number1 + number2;
				result.Text = result_value.ToString();
				history.Text = num1 +  " + " + num2 + " = " + result_value.ToString() + "\n" + history.Text;

			}
			else if (operation == '-')
			{
				result_value = number1 - number2;
				result.Text = result_value.ToString();
				history.Text = num1 + " - " + num2 + " = " + result_value.ToString() + "\n" + history.Text;
			}
			else if (operation == 'x')
			{
				result_value = number1 * number2;
				result.Text = result_value.ToString();
				history.Text = num1 + " x " + num2 + " = " + result_value.ToString() + "\n" + history.Text;
			}
			else if (operation == '/')
			{
				if (number2 != 0)
				{
					result_value = number1 / number2;
					result.Text = result_value.ToString();
				}
				else
				{
					result.Text = "Error";
				}
				history.Text = num1 + " / " + num2 + " = " + result_value.ToString() + "\n" + history.Text;
			}
			else if (operation == '%')
			{
				if (number2 != 0)
				{
					result_value = number1 % number2;
					result.Text = result_value.ToString();
				}
				else
				{
					result.Text = "Error";
				}
				history.Text = num1 + " % " + num2 + " = " + result_value.ToString() + "\n" + history.Text;
			}
			else if (operation == 'y')
			{
				result_value = Math.Pow(number1, number2);
				result.Text = result_value.ToString();
				history.Text = num1 + " ^ " + num2 + " = " + result_value.ToString() + "\n" + history.Text; ;
			}
			else if (operation == '2')
			{
				result_value = Math.Pow(number1, 2);
				result.Text = number1.ToString();
				history.Text = num1 + " ^2 " + " = " + result_value.ToString() + "\n" + history.Text;
			}
			else if (operation == '3')
			{
				result_value = Math.Pow(number1, 3);
				result.Text = number1.ToString();
				history.Text = num1 + " ^3 " + " = " + result_value.ToString() + "\n" + history.Text;
			}
			
			else if (operation == 't')
			{
				result_value = Math.Pow(10, number1);
				result.Text = result_value.ToString();
				history.Text = "10^" +num1 + " = " + result_value.ToString() + "\n" + history.Text;
			}
			else if (operation == 'p')
			{
				result_value = Math.Exp(number1);
				result.Text = result_value.ToString();
				history.Text = "Exp" + num1 + " = " + result_value.ToString() + "\n" + history.Text;
			}
			else if (operation == '!')
			{
				double factorial;
				factorial = 1;
				while (number1 >= 1)
				{
					factorial = number1 * factorial;
					number1--;
				}
				
				result_value = factorial;
				result.Text = result_value.ToString();
				history.Text = num1 + "! " + " = " + result_value.ToString() + "\n" + history.Text;
				
			}

			
			input = result_value.ToString();
			result.Text = input;
			num2 = string.Empty;
		}

		private void n_Click(object sender, EventArgs e)
		{
			num1 = result.Text;
			operation = '!';
			operation_function('!');
			operation = ' ';
			equal_Click(sender, e);


		}
		private void number0_Click(object sender, EventArgs e)
		{
			number_function("0");
		}

		private void dot_Click(object sender, EventArgs e)
		{
			number_function(".");
		}

		private void number1_Click(object sender, EventArgs e)
		{
			number_function("1");
		}

		private void number2_Click(object sender, EventArgs e)
		{
			number_function("2");
		}

		private void number3_Click(object sender, EventArgs e)
		{
			number_function("3");
		}

		private void number4_Click(object sender, EventArgs e)
		{
			number_function("4");
		}

		private void number5_Click(object sender, EventArgs e)
		{
			number_function("5");
		}

		private void number6_Click(object sender, EventArgs e)
		{
			number_function("6");
		}

		private void number7_Click(object sender, EventArgs e)
		{
			number_function("7");
		}

		private void number8_Click(object sender, EventArgs e)
		{
			number_function("8");
		}

		private void number9_Click(object sender, EventArgs e)
		{
			number_function("9");
		}

		private void MC_Click(object sender, EventArgs e)
		{
			
			memory.Clear();
			memory_store = 0;
			memory.Text = "Nothing stored in Memeory";
		}

		private void Mplus_Click(object sender, EventArgs e)
		{
			checkequal_click();
			double nump1;
			double.TryParse(result.Text, out nump1);
			if (nump1 != 0 && equal_click == false)
			{
				memory_store += nump1;
			}
			else
			{
				memory_store += result_value;
			}
			memory.Text = Convert.ToString(memory_store);
			
		}
		private void Mminus_Click(object sender, EventArgs e)
		{
			double nump1;
			double.TryParse(result.Text, out nump1);
			if (nump1 != 0 && equal_click == false)
			{
				memory_store -= nump1;
			}
			else
			{
				memory_store -= result_value;
			}
			memory.Text = Convert.ToString(memory_store);
		}

		private void plus_Click(object sender, EventArgs e)
		{
			operation_function('+');
		}

		private void minus_Click(object sender, EventArgs e)
		{
			operation_function('-');
		}

		private void multiply_Click(object sender, EventArgs e)
		{
			operation_function('x');
		}

		private void divide_Click(object sender, EventArgs e)
		{
			operation_function('/');
		}

		private void expo2_Click(object sender, EventArgs e)
		{
			num1 = result.Text;
			operation = '2';
			operation_function('2');
			operation = ' ';
			equal_Click(sender, e);
		}

		private void expo3_Click(object sender, EventArgs e)
		{
			num1 = result.Text;
			operation = '3';
			operation_function('3');
			operation = ' ';
			equal_Click(sender, e);
		}

		private void expoy_Click(object sender, EventArgs e)
		{
			operation_function('y');
		}

		private void expo10_Click(object sender, EventArgs e)
		{
			num1 = result.Text;
			operation = 't';
			operation_function('t');
			operation = ' ';
			equal_Click(sender, e);
		}

		private void expo_Click(object sender, EventArgs e)
		{
			num1 = result.Text;
			operation = 'p';
			operation_function('p');
			operation = ' ';
			equal_Click(sender, e);
		}

		private void mod_Click(object sender, EventArgs e)
		{
			operation_function('%');
		}

		private void CE_Click(object sender, EventArgs e)
		{
			
			input = string.Empty;
			num1 = string.Empty;
			num2 = string.Empty;
			result.Clear();
		}

		private void C_Click(object sender, EventArgs e)
		{
			
			input = string.Empty;
			num1 = string.Empty;
			num2 = string.Empty;
			result.Clear();
			history.Clear();
		}

		private void DEL_Click(object sender, EventArgs e)
		{
			string del = RemoveLastChar(result.Text);
			input = del;
			result.Text = del;
		}

		public string RemoveLastChar(string fulltext)
		{
			string del = string.Empty;
			char[] text = fulltext.ToCharArray();
			for (int i = 0; i < text.Length - 1; i++)
			{
				del += text[i];
			}
			return del;
		}

		private void equal_Click(object sender, EventArgs e)
		{
			math_function();
			equal_click = true;
			op_click = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void equal_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void result_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void calculartorInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			CalculatorInfo f2 = new CalculatorInfo();
			f2.ShowDialog();
			this.Enabled = true;
		}

		private void convertBinaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			ConvertBinary f2 = new ConvertBinary();
			f2.ShowDialog();
			this.Enabled = true;
		}

		private void memory_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			/*
			num1 = input;
			if (listBoxCurrency.SelectedIndex == 0)
			{
				num1 = Convert.ToDouble(result.Text);
				result_value = num1 / 30.3;
				num1 = 0;
				result.Text = Convert.ToString(result_value);
				//CurOp.Text = "US";
			}
			if (listBoxCurrency.SelectedIndex == 1)
			{
				num1 = Convert.ToDouble(result.Text);
				result_value = num1 * 30.3;
				value = 0;
				result.Text = Convert.ToString(result_value);
				//CurOp.Text = "TH";
			}
			*/
		}
	}
}
