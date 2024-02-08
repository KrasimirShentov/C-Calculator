using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double result = 1;
        String command = "";
        bool enter_Value = false;
        float Celsium, Farenheit, Kelvin;
        char commandT;

        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Width = 324;
            textBox2.Width = 298;
        }

        private void toolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            this.Width = 635;
            textBox2.Width = 603;
        }


        private void toolStripMenuItem12_Click_1(object sender, EventArgs e)
        {
            this.Width = 963;
            textBox2.Width = 603;
            textBox3.Focus();

            groupBox1.Visible = true;
            Groupbox_2.Visible = false;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            this.Width = 963;
            textBox2.Width = 603;
            
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.Width = 963;
            textBox2.Width = 603;
            TextMultiply.Focus();

            groupBox1.Visible = false;
            Groupbox_2.Visible = true;
            Groupbox_2.Location = new Point(621, 37);
            Groupbox_2.Width = 317;
            Groupbox_2.Height = 401;
        }
        

        
        private void Button_Click_1(object sender, EventArgs e)
        {
            if ((textBox2.Text == "0") || (enter_Value))
                textBox2.Text = "";
            enter_Value = false;

            Button number = (Button)sender;

            if (number.Text == ".")
            {
                if (!textBox2.Text.Contains("."))
                    textBox2.Text = textBox2.Text + number.Text;

            }
            else
                textBox2.Text = textBox2.Text + number.Text;
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            label6.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            label6.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            switch (command)
            {
                case "+":
                    textBox2.Text = (result + double.Parse(textBox2.Text)).ToString();
                    break;
                case "-":
                    textBox2.Text = (result - double.Parse(textBox2.Text)).ToString();
                    break;
                case "/":
                    textBox2.Text = (result / double.Parse(textBox2.Text)).ToString();
                    break;
                case "X":
                    textBox2.Text = (result * double.Parse(textBox2.Text)).ToString();
                    break;
            }
        }
        private void Arithmetic_Operation(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            command = number.Text;
            result = Double.Parse(textBox2.Text);
            textBox2.Text = "";
            label6.Text = System.Convert.ToString(result) + " " + command;
        }


        private void PI_Click(object sender, EventArgs e)
        {
            textBox2.Text = "3.14";
        }

        private void button63_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(textBox2.Text);
            label6.Text = System.Convert.ToString("log" + "(" + (textBox2.Text) + ")");
            log = Math.Log10(log);
            textBox2.Text = System.Convert.ToString(log);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(textBox2.Text);
            label6.Text = System.Convert.ToString("Sqrt" + "(" + (textBox2.Text) + ")");
            sqrt = Math.Sqrt(sqrt);
            textBox2.Text = System.Convert.ToString(sqrt);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            double sinH = Double.Parse(textBox2.Text);
            label6.Text = System.Convert.ToString("SinH" + "(" + (textBox2.Text) + ")");
            sinH = Math.Sinh(sinH);
            textBox2.Text = System.Convert.ToString(sinH);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(textBox2.Text);
            label6.Text = System.Convert.ToString("Sin" + "(" + (textBox2.Text) + ")");
            sin = Math.Sin(sin);
            textBox2.Text = System.Convert.ToString(sin);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            double cosH = Double.Parse(textBox2.Text);
            label6.Text = System.Convert.ToString("CosH" + "(" + (textBox2.Text) + ")");
            cosH = Math.Cosh(cosH);
            textBox2.Text = System.Convert.ToString(cosH);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(textBox2.Text);
            label6.Text = System.Convert.ToString("Cos" + "(" + (textBox2.Text) + ")");
            cos = Math.Cos(cos);
            textBox2.Text = System.Convert.ToString(cos);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            double tanH = Double.Parse(textBox2.Text);
            label6.Text = System.Convert.ToString("TanH" + "(" + (textBox2.Text) + ")");
            tanH = Math.Tanh(tanH);
            textBox2.Text = System.Convert.ToString(tanH);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(textBox2.Text);
            label6.Text = System.Convert.ToString("Tan" + "(" + (textBox2.Text) + ")");
            tan = Math.Tan(tan);
            textBox2.Text = System.Convert.ToString(tan);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            textBox2.Text = System.Convert.ToString(a, 2);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            textBox2.Text = System.Convert.ToString(a, 8);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            textBox2.Text = System.Convert.ToString(a, 16);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            textBox2.Text = System.Convert.ToString(a);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox2.Text);

            textBox2.Text = System.Convert.ToString(Math.Pow(a, 2));
            label6.Text = System.Convert.ToString(a + "²");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox2.Text);

            textBox2.Text = System.Convert.ToString(Math.Pow(a, 3));
            label6.Text = System.Convert.ToString(a + "³");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(textBox2.Text);
            label6.Text = System.Convert.ToString("log" + "(" + (textBox2.Text) + ")");
            log = Math.Log(log);
            textBox2.Text = System.Convert.ToString(log);
        }


        private void button41_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox2.Text) / Convert.ToDouble(100);
            label6.Text = System.Convert.ToString(textBox2.Text + "%" + "100");
            textBox2.Text = System.Convert.ToString(a);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(1.0 / Convert.ToDouble(textBox2.Text));
            label6.Text = System.Convert.ToString("1" + "/" + textBox2.Text);
            textBox2.Text = System.Convert.ToString(a);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            double i = Double.Parse(textBox2.Text);
            double q;
            q = result;
            textBox2.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            
            textBox2.Text = (result % Double.Parse(textBox2.Text)).ToString();
        }


        private void CelToFah_CheckedChanged(object sender, EventArgs e)
        {
            commandT = 'C';
        }

        private void FahToCel_CheckedChanged(object sender, EventArgs e)
        {
            commandT = 'F';
        }


        private void Kel_CheckedChanged(object sender, EventArgs e)
        {
            commandT = 'K';
        }


        private void button62_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox3.Text = "";

            if (CelToFah.Checked == true)
            {
                CelToFah.Checked = false;
            }
            else if (FahToCel.Checked == true)
            {
                FahToCel.Checked = false;
            }
            else if (Kel.Checked == true)
            {
                Kel.Checked = false;
            }

        }


        private void button61_Click(object sender, EventArgs e)
        {
            switch (commandT)
            {
                case 'C':
                    Celsium = float.Parse(textBox3.Text);
                    label3.Text = (((Celsium * 9) / 5) + 32).ToString();
                    break;
                case 'F':
                    Farenheit = float.Parse(textBox3.Text);
                    label3.Text = (((Farenheit - 32) * 5) / 9).ToString();
                    break;
                case 'K':
                    Kelvin = float.Parse(textBox3.Text);
                    label3.Text = ((((Kelvin * 9) / 5) + 32) + 273.15).ToString();
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToInt32(TextMultiply.Text);

            for (int i = 1; i <= 20; i++)
            {
                LstMultiplication.Items.Add(i + "*" + a + " = " + a * i);
            }
        }
        private void Resetbtn_Click(object sender, EventArgs e)
        {
            LstMultiplication.Items.Clear();
            TextMultiply.Text = "";
        }
    }

}
