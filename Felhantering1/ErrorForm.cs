using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Felhantering1
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void btnTestCode_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtTal1.Text);
                int[] numbers = new int[1];

                if (txtTal2.Text == "")
                {
                    numbers[0] = num1;

                    //Kommer att generera ett runtime error
                    //indexoutofrange
                    numbers[1] = num1; 
                }
                else
                {
                    int num2 = int.Parse(txtTal2.Text);

                    //Är num2 = 0 blir det fel här
                    //Devidebyzero
                    int value = num1 / num2;

                }
            }
            catch (DivideByZeroException divideZero)
            {
                lblErrorCode.Text = "Du försök dela med 0 vilket inte går!" 
                                    + divideZero.Message + ":" + divideZero.Source
                                    + ":" + divideZero.TargetSite;
            }
            catch (IndexOutOfRangeException outOfRange)
            {
                lblErrorCode.Text = "Felaktig position i arrayen";
            }
            catch (Exception ex)
            {
                lblErrorCode.Text = "Något gick fel, försök igen!";
            }
        }

        private void lblTal2_Click(object sender, EventArgs e)
        {

        }
    }
}
