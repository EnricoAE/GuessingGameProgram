using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GuessingGameProgram
{
    public partial class frGuessingGame : Form
    {
        public frGuessingGame()
        {
            InitializeComponent();
        }

        private void frGuessingGame_Load(object sender, EventArgs e)
        {
            StringBuilder GuessComp = new StringBuilder("c??????r");
            lblGuess.Text = GuessComp.ToString();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            ArrayList ans = new ArrayList();
            ans.Add("computer"); 

            string attempt = txtAnswer.Text;

            if(ans.Contains(attempt) && attempt.Equals("computer"))
            {
                lblGuess.Text = attempt.ToString();
                txtAnswer.Text = "";
                MessageBox.Show("Correct Guess!");
            }
            else
            {
                MessageBox.Show("Wrong guess! \nTry again");
                listBox1.Items.Add(txtAnswer.Text);
                txtAnswer.Text = "";
            }
        }
    }
}
