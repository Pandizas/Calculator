using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void calculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                double c = double.Parse(chislo1.Text);
                double d = double.Parse(chislo2.Text);


            }
            catch (FormatException )
            {
                MessageBox.Show("Input must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chislo1.Text = "0";
                chislo2.Text = "0";

            }
           
            
                double a = double.Parse(chislo1.Text);
                double b = double.Parse(chislo2.Text);
                double result;


                try
                {








                    switch (comboBox1.Text)
                    {

                        case "Събиране": result = a + b; resultat.Text = result.ToString(); break;
                        case "Изваждане": result = a - b; resultat.Text = result.ToString(); break;
                        case "Умножение": result = a * b; resultat.Text = result.ToString(); break;
                        case "Деление":
                            result = a / b; if (b == 0)
                            {
                                throw new System.DivideByZeroException();
                            }
                            resultat.Text = result.ToString(); break;
                        case "Корен Квадратен":
                            if (a <= 0)
                            {
                                throw new System.FormatException();
                            }
                            result = Math.Sqrt(a); resultat.Text = result.ToString(); break;
                        case "Реципрочно": result = 1 / a; resultat.Text = result.ToString(); break;

                        default:

                            break;
                    }
                }


                catch (DivideByZeroException )
                {
                    MessageBox.Show("Can't divide by 0", "ERROR",
        MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                catch (FormatException )
                {
                    MessageBox.Show("Square root must be a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        

        private void clear_Click(object sender, EventArgs e)
        {
            chislo1.Text = "0";
            chislo2.Text = "0";
            comboBox1.Text = " ";
            
            resultat.Text = "0";
        }

        private void Prisvoi_Click(object sender, EventArgs e)
        {
            chislo1.Text = resultat.Text;
            
        }

     
    }
}
