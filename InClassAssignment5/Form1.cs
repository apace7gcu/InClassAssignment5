using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Amanda Pace
 * Bill Hughes - CST-117
 * 25 October 2020
 * This program calculates what value of pi you would get given x terms.
 * 
 * This program was done partially during class with code provided by professor/classmate, 
 * and then I finished the project on my own
 * */
namespace InClassAssignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button To Calculate PI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnCalculate_Click(object sender, EventArgs e)
        {
            //Declaring Variables

            //int enterTerms = Convert.ToInt32(txtEnterTerms.Text);

            int numLoops;
            double valuePi = 0;
            double denCount = 1;
            bool odd = false, even = false;
            // Get the number of loops from the textbox

            numLoops = Convert.ToInt32(txtEnterTerms.Text);

            //Create the for loop
            for (int x = 1; x <= numLoops; x++)
            {
                //Test if loop is odd or even
                if (x % 2 == 0)
                {
                    even = true;
                    odd = false;
                }
                else
                {
                    odd = true;
                    even = false;
                }

                //Is counter odd or even
                if (odd)
                {
                    valuePi += 4 / denCount;
                }
                else if (even)
                {
                    valuePi -= 4 / denCount;
                }

                denCount += 2;

            }
            //Displays EnterTerms variable in a label 
            lblTermDisplay.Text = "The aproximate value of pi after " + txtEnterTerms.Text + " terms.";

            //Displays the answer/value of pi in a label
            lblPiDisplay.Text = " = " + valuePi;

        }

    }
}
