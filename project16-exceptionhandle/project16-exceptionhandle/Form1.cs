using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project16_exceptionhandle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int result = Convert.ToInt32(txtBoxFirstNum.Text) / Convert.ToInt32(txtBoxSecondNum.Text);
            }
            catch (DivideByZeroException ex)
            {

                MessageBox.Show(ex.ToString());
            }

            catch (FormatException ex2)
            {
                MessageBox.Show(ex2.ToString());
            }

            finally
            {
                MessageBox.Show("Program was finished");
                this.Close();
            }
            
        }
    }
}
