using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentWeek7
{
    public partial class FormQuizPanda : Form
    {
        public string[] ArrayHuruf = new string[30];


        public FormQuizPanda()
        {
            InitializeComponent();
        }

        private void lblHasilOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            lblHasilOutput.Text = ConvertToUpperCase(txtBxMasukkanKalimat.Text);

            //i'm giving up i'm so sorry, this is actually the value of the alphabet, but still can't 
            if (txtBxMenjadi.Text == "A")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[0];
            }
            else if (txtBxMenjadi.Text == "B")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[1];
            }
            else if (txtBxMenjadi.Text == "C")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[2];
            }
            else if (txtBxMenjadi.Text == "D")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[3];
            }
            else if (txtBxMenjadi.Text == "E")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[4];
            }
            else if (txtBxMenjadi.Text == "F")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[5];
            }
            else if (txtBxMenjadi.Text == "G")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[6];
            }
            else if (txtBxMenjadi.Text == "H")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[7];
            }
            else if (txtBxMenjadi.Text == "I")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[8];
            }
            else if (txtBxMenjadi.Text == "J")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[9];
            }
            else if (txtBxMenjadi.Text == "K")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[10];
            }
            else if (txtBxMenjadi.Text == "L")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[11];
            }
            else if (txtBxMenjadi.Text == "M")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[12];
            }
            else if (txtBxMenjadi.Text == "N")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[13];
            }
            else if (txtBxMenjadi.Text == "O")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[14];
            }
            else if (txtBxMenjadi.Text == "P")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[15];
            }
            else if (txtBxMenjadi.Text == "Q")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[16];
            }
            else if (txtBxMenjadi.Text == "R")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[17];
            }
            else if (txtBxMenjadi.Text == "S")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[18];
            }
            else if (txtBxMenjadi.Text == "T")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[19];
            }
            else if (txtBxMenjadi.Text == "U")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[20];
            }
            else if (txtBxMenjadi.Text == "V")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[21];
            }
            else if (txtBxMenjadi.Text == "W")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[22];
            }
            else if (txtBxMenjadi.Text == "X")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[23];
            }
            else if (txtBxMenjadi.Text == "Y")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[24];
            }
            else if (txtBxMenjadi.Text == "Z")
            {
                txtBxMasukkanHuruf.Text = ArrayHuruf[25];
            }

        }

        public static string ConvertToUpperCase(string input)
        {
            //for converting the word to be a capital latter 
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    output += (char)(input[i] - 'a' + 'A');
                }
                else
                {
                    output += input[i];
                }
            }
            return output;
        }

        private void FormQuizPanda_Load(object sender, EventArgs e)
        {
            //i'm giving up i'm so sorry, this is actually the value of the alphabet, but still can't 
            ArrayHuruf[0] = "A";
            ArrayHuruf[1] = "B";
            ArrayHuruf[2] = "C";
            ArrayHuruf[3] = "D";
            ArrayHuruf[4] = "E";
            ArrayHuruf[5] = "F";
            ArrayHuruf[6] = "G";
            ArrayHuruf[7] = "H";
            ArrayHuruf[8] = "I";
            ArrayHuruf[9] = "J";
            ArrayHuruf[10] = "K";
            ArrayHuruf[11] = "L";
            ArrayHuruf[12] = "M";
            ArrayHuruf[13] = "N";
            ArrayHuruf[14] = "O";
            ArrayHuruf[15] = "P";
            ArrayHuruf[16] = "Q";
            ArrayHuruf[17] = "R";
            ArrayHuruf[18] = "S";
            ArrayHuruf[19] = "T";
            ArrayHuruf[20] = "U";
            ArrayHuruf[21] = "V";
            ArrayHuruf[22] = "W";
            ArrayHuruf[23] = "X";
            ArrayHuruf[24] = "Y";
            ArrayHuruf[25] = "Z";


        }
    }
}
