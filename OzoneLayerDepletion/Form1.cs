using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzoneLayerDepletion
{
    public partial class ozoneDepletionForm : Form
    {
        public ozoneDepletionForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Constants
            const double RATE = 0.04;
            const int DECADE = 10;
            const int START_YEAR = 2018;
            const int END_YEAR = 2118;

            // Variables
            double du = 300;
            double shrink;
            int year;

            // Display table of DU depletion
            for (year = START_YEAR; year <= END_YEAR; year += DECADE)
            {
                // Calculate the amount it shrinks by
                shrink = du * RATE;

                // Calculate the new value
                du -= shrink;

                // Display the output
                outputListBox.Items.Add("From " + year + " the ozone layer shrinks by " + shrink.ToString("f") + ".");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
