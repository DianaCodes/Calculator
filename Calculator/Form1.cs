using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

//Used code from www.instructables.com/id/Creating-a-Calculator-Visual-Studio-C to build
//simple calculator, will build sientific one on my own

namespace Calculator
{
    public partial class Form1 : Form
    {
        decimal num1;
        decimal num2;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void input(string a)
        {
            if (textBox.Text == "0")

                textBox.Text = a;

            else

                textBox.Text += a;
        }

        private void five_Click(object sender, EventArgs e)
        {
            input("5");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            input("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            input("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            input("9");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox.Text);
            operation = "/";
            textBox.Text = "0";
        }

        private void four_Click(object sender, EventArgs e)
        {
            input("4");
        }

        private void six_Click(object sender, EventArgs e)
        {
            input("6");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox.Text);
            operation = "*";
            textBox.Text = "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            input("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            input("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            input("3");
        }

        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"-.");

            if (rgx.IsMatch(textBox.Text)) {
                num1 = -1 * decimal.Parse(textBox.Text);
            } else {
                num1 = decimal.Parse(textBox.Text);
            }
            operation = "+";
            textBox.Text = "0";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            input("0");
        }

        private void dot_Click(object sender, EventArgs e)
        {
            input(".");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            this.operation = string.Empty;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if(textBox.Text == String.Empty)
            {
                num1 *= -1;
            } else
            {
                num1 = decimal.Parse(textBox.Text);
            }
            
            operation = "-";
            textBox.Text += "-";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(textBox.Text);

            switch (operation)
            {
                case "+":
                    textBox.Text = (num1 + num2).ToString();

                    break;
                case "-":
                    textBox.Text = (num1 - num2).ToString();

                    break;
                case "*":
                    textBox.Text = (num1 * num2).ToString();

                    break;
                case "/":
                    textBox.Text = (num1 / num2).ToString();

                    break;
                case "^":
                    textBox.Text = (int.Parse(num1.ToString()) ^ int.Parse(num2.ToString())).ToString();

                    break;
                case "%":
                    textBox.Text = (num1 % num2).ToString();

                    break;
            }
        }

        int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

        int find_ncr(int n, int r)
        {
            r = Factorial(n) / (Factorial(r) * Factorial(n - r));

            return r;
        }

        int find_npr(int n, int r)
        {
            r = Factorial(n) / Factorial(n - r);

            return r;
        }

        private void answer_Click(object sender, EventArgs e)
        {

        }

        private void square_Click(object sender, EventArgs e)
        {

        }

        private void tothe_Click(object sender, EventArgs e)
        {
        }

        private void fac_Click(object sender, EventArgs e)
        {
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
        }

        private void tothesqrt_Click(object sender, EventArgs e)
        {
        }

        private void leftparenthesis_Click(object sender, EventArgs e)
        {
        }

        private void rightparenthesis_Click(object sender, EventArgs e)
        {
        }

        private void sin_Click(object sender, EventArgs e)
        {
            textBox.Text = (Math.Sin(double.Parse(textBox.Text))).ToString();
        }

        private void cosine_Click(object sender, EventArgs e)
        {
            textBox.Text = (Math.Cos(double.Parse(textBox.Text))).ToString();
        }

        private void tangent_Click(object sender, EventArgs e)
        {
            textBox.Text = (Math.Tan(double.Parse(textBox.Text))).ToString();
        }

        private void pi_Click(object sender, EventArgs e)
        {
        }

        private void absolutevalue_Click(object sender, EventArgs e)
        {
        }

        private void percent_Click(object sender, EventArgs e)
        {
        }

        private void backspace_Click(object sender, EventArgs e)
        {
        }

        //When I click on Main, certain buttons will change name, text, and event handler
        private void mainbutton_Click(object sender, EventArgs e)
        {
            //mainbutton.BackColor = System.Drawing.Color.Gray;
            mainbutton.FlatStyle = FlatStyle.Flat;
            mainbutton.FlatAppearance.BorderColor = Color.Black;
            mainbutton.FlatAppearance.BorderSize = 1;

            square.Name = "square";
            square.Text = "a^2";
            square.Click -= this.log_Click;
            square.Click += this.square_Click;

            tothe.Name = "tothe";
            tothe.Text = "a^b";
            tothe.Click -= this.ln_Click;
            tothe.Click += this.tothe_Click;
            
            fac.Name = "fac";
            fac.Text = "!";
            fac.Click -= this.e_Click;
            fac.Click += this.fac_Click;

            sqrt.Name = "sqrt";
            sqrt.Text = "√";
            sqrt.Click -= this.prob_Click;
            sqrt.Click += this.sqrt_Click;

            tothesqrt.Name = "tothesqrt";
            tothesqrt.Text = "n√";
            tothesqrt.Click -= this.combi_Click;
            tothesqrt.Click += this.tothesqrt_Click;

            sin.Name = "sin";
            sin.Text = "sin";
            sin.Click -= this.asin_Click;
            sin.Click += this.sin_Click;

            cosine.Name = "cosine";
            cosine.Text = "cos";
            cosine.Click -= this.acosine_Click;
            cosine.Click += this.cosine_Click;

            tangent.Name = "tangent";
            tangent.Text = "tan";
            tangent.Click -= this.atangent_Click;
            tangent.Click += this.tangent_Click;
        }

        //When I click on Func, certain buttons will change name, text, and event handler
        private void func_Click(object sender, EventArgs e)
        {
            square.Name = "log";
            square.Text = "log";
            square.Click -= this.square_Click;
            square.Click += this.log_Click;

            tothe.Name = "ln";
            tothe.Text = "ln";
            tothe.Click -= this.tothe_Click;
            tothe.Click += this.ln_Click;

            fac.Name = "e";
            fac.Text = "e";
            fac.Click -= this.fac_Click;
            fac.Click += this.e_Click;

            sqrt.Name = "prob";
            sqrt.Text = "nPr";
            sqrt.Click -= this.sqrt_Click;
            sqrt.Click += this.prob_Click;

            tothesqrt.Name = "combi";
            tothesqrt.Text = "nCr";
            tothesqrt.Click -= this.tothesqrt_Click;
            tothesqrt.Click += this.combi_Click;

            sin.Name = "asin";
            sin.Text = "Asin";
            sin.Click -= this.sin_Click;
            sin.Click += this.asin_Click;

            cosine.Name = "acosine";
            cosine.Text = "Acos";
            cosine.Click -= this.cosine_Click;
            cosine.Click += this.acosine_Click;

            tangent.Name = "atangent";
            tangent.Text = "Atan";
            tangent.Click -= this.tangent_Click;
            tangent.Click += this.atangent_Click;
        }

        private void log_Click(object sender, EventArgs e)
        {
            textBox.Text = (Math.Log(double.Parse(textBox.Text))).ToString();
        }

        private void ln_Click(object sender, EventArgs e)
        {
        }

        private void e_Click(object sender, EventArgs e)
        {
        }

        private void prob_Click(object sender, EventArgs e)
        {
        }

        private void combi_Click(object sender, EventArgs e)
        {
        }

        private void asin_Click(object sender, EventArgs e)
        {
        }

        private void acosine_Click(object sender, EventArgs e)
        {
        }

        private void atangent_Click(object sender, EventArgs e)
        {
        }
    }
}
