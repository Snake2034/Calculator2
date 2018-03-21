using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calc
{
    /*
     Author Bradley Ghannoum
     Creation Date 21/3/2018
     Version Control = Version 2.0
         */
    public partial class Form1 : Form
    {
        //Tunes and variables
        MathLibrary.MathStuff math2 = new MathLibrary.MathStuff();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        double number = 0, number2 = 0; 
        double answer = 0;
        int numberCounter = 0;

        public Form1()
        {
            //initialize tunes
            player.SoundLocation = "TheDragonbornComes.wav";
            player.PlayLooping();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text.Text = text.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text.Text = text.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text.Text = text.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text.Text = text.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text.Text = text.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text.Text = text.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text.Text = text.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            text.Text = text.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text.Text = text.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            text.Text = text.Text += 0;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            text.Text = text.Text += ".";
        }

        //Equals Button Click
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                //Gets the symbol at the end of a string so i can decide what maths to do
            string output = tbMaths.Text.Substring(tbMaths.TextLength - 2, 1);
            
                //Do maths based on output
                if (output == "+")
                {
                    //parses currect answer and text.Text to math library
                    answer = math2.add(answer, double.Parse(text.Text));
                    tbMaths.Text = answer.ToString();
                    text.Clear();
                }
                else if (output == "-")
                {

                    //parses currect answer and text.Text to math library
                    answer = math2.subtract(answer, double.Parse(text.Text));
                    tbMaths.Text = answer.ToString();
                }
                else if (output == "/")
                {

                    //parses currect answer and text.Text to math library
                    answer = math2.divide(answer, double.Parse(text.Text));
                    tbMaths.Text = answer.ToString();
                }
                else if (output == "*")
                {

                    //parses currect answer and text.Text to math library
                    answer = math2.multiply(answer, double.Parse(text.Text));
                    tbMaths.Text = answer.ToString();
                }
            }
            catch(Exception ex)
            {

            }
            text.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear button pressed calls clear method
            clear();
        }
        public void clear()
        {
            //Clear method resets all variables and makes all text fields empty
            number = 0;
            number2 = 0;
            answer = 0;
            tbMaths.Clear();
            text.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks if there is already maths going on
                //if not do this
                if (number == 0 && tbMaths.Text == "")
                {
                    number = double.Parse(text.Text);
                    answer = number;
                    tbMaths.Text = number.ToString() + " - ";
                    text.Clear();
                }
                //else do this
                else if (text.Text != "")
                {
                    tbMaths.Text += " - ";
                    number2 = double.Parse(text.Text);
                    answer = math2.subtract(number, number2);
                    number = answer;
                    tbMaths.Text = answer.ToString();
                    text.Clear();
                }
                //if textbox is empty add a - to tbMaths.
                else if (text.Text == "")
                {
                    string[] bluh = tbMaths.Text.Split(' ');
                    tbMaths.Text = bluh[0];
                    tbMaths.Text += " - ";
                }
            }
            catch (Exception ex)
            {
                text.Text = "Please enter data in here first";
            }
            
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks if there is already maths going on
                //if not do this
                if (number == 0 && tbMaths.Text == "")
                {
                    number = double.Parse(text.Text);
                    answer = number;
                    tbMaths.Text = number.ToString() + " + ";
                    text.Clear();
                }
                //else if textbox contains numbers do this
                else if (text.Text != "")
                {
                    tbMaths.Text += " + ";
                    number2 = double.Parse(text.Text);
                    answer = math2.add(number, number2);
                    number = answer;
                    tbMaths.Text = answer.ToString();
                    tbMaths.Text += " + ";
                    text.Clear();
                }
                //if its empty add + to tbMaths
                else if (text.Text == "")
                {
                    string[] bluh = tbMaths.Text.Split(' ');
                    tbMaths.Text = bluh[0];
                    tbMaths.Text += " + ";
                }
            }
            catch (Exception ex)
            {
                text.Text = "Please enter data in here first";
            }
            
        }
        

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks if there is already maths going on
                //if not do this
                if (number == 0 && tbMaths.Text == "")
                {
                    number = double.Parse(text.Text);
                    answer = number;
                    tbMaths.Text = number.ToString() + " / ";
                    text.Clear();
                }
                //else if textbox contains numbers do this
                else if (text.Text != "")
                {
                    tbMaths.Text += " / ";
                    number2 = double.Parse(text.Text);
                    answer = math2.divide(number, number2);
                    number = answer;
                    tbMaths.Text = answer.ToString();
                    tbMaths.Text += " / ";
                    text.Clear();
                }
                //if its empty add + to tbMaths
                else if (text.Text == "")
                {
                    string[] bluh = tbMaths.Text.Split(' ');
                    tbMaths.Text = bluh[0];
                    tbMaths.Text += " / ";
                }
            }
            catch (Exception ex)
            {
                text.Text = "Please enter data in here first";
            }
            
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks if there is already maths going on
                //if not do this
                
                if (number == 0 && tbMaths.Text == "")
                {
                    number = double.Parse(text.Text);
                    answer = number;
                    tbMaths.Text = number.ToString() + " * ";
                    text.Clear();
                }
                //else if textbox contains numbers do this
                else if (text.Text != "")
                {
                    tbMaths.Text += " * ";
                    number2 = double.Parse(text.Text);
                    answer = math2.multiply(number, number2);
                    number = answer;
                    tbMaths.Text = answer.ToString();
                    tbMaths.Text += " * ";
                    text.Clear();
                }
                //if its empty add + to tbMaths
                else if (text.Text == "")
                {
                    string[] bluh = tbMaths.Text.Split(' ');
                    tbMaths.Text = bluh[0];
                    tbMaths.Text += " * ";
                }
            }
            catch(Exception ex)
            {
                text.Text = "Please enter data in here first";
            }
            
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            try
            {
                //get input
                double input = double.Parse(text.Text);
                //make sure its not 90
                if (input == 90)
                {
                    text.Text = "Invalid Input";
                }
                //do math
                else
                {
                    text.Text = "tan(" + input + ")";
                    //send to math library to do Tan math
                    double answer = math2.Tan(input);
                    tbMaths.Text = answer.ToString();
                }
            }
            catch(Exception ex)
            {
                text.Text = "Please enter data in here first";
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            try
            {
                //gets input then sends input to Sin maths library
                double input = double.Parse(text.Text);
                text.Text = "Sin(" + input + ")";
                double answer = math2.Sin(input);
                tbMaths.Text = answer.ToString();

            }
            catch (Exception ex)
            {
                text.Text = "Please enter data in here first";
            }
            
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            try
            {
                //gets input then sends input to Cos maths library
                double input = double.Parse(text.Text);

                text.Text = "Cos(" + input + ")";
                double answer = math2.Cos(input);
                tbMaths.Text = answer.ToString();
            }
            catch(Exception ex)
            {
                text.Text = "Please enter data in here first";
            }
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            try
            {
                //gets input then sends input to SQRT maths library
                double input = double.Parse(text.Text);
                double answer = math2.Square(input);
                tbMaths.Text = answer.ToString();
            }
            catch(Exception ex)
            {
                text.Text = "Please enter data in here first";
            }
        }

        private void cubeRoot_Click(object sender, EventArgs e)
        {
            try
            {
                //gets input then sends input to cubeRT maths library
                double input = double.Parse(text.Text);
                double answer = math2.Cube(input);
                tbMaths.Text = answer.ToString();
            }
            catch(Exception ex)
            {
                text.Text = "Please enter data in here first";
            }
            
        }

        private void inverse_Click(object sender, EventArgs e)
        {
            try
            {
                //gets input then sends input to Inv maths library
                double input = double.Parse(text.Text);
                double answer = math2.Inv(input);
                tbMaths.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                text.Text = "Please enter data in here first";
            }
            
        }
    }
}
