using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frogger
{
    public partial class Form3 : Form
    {
        private string next="Leave";
        public Form3()
        {
            InitializeComponent();

            butPlayAgain.FlatStyle = FlatStyle.Flat;
            butPlayAgain.FlatAppearance.BorderSize = 0;
            butPlayAgain.BackColor = Color.Transparent;
            butPlayAgain.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butPlayAgain.FlatAppearance.MouseDownBackColor = Color.Transparent;

            butExit.FlatStyle = FlatStyle.Flat;
            butExit.FlatAppearance.BorderSize = 0;
            butExit.BackColor = Color.Transparent;
            butExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        public string getNext()
        {
            return next;
        }

        private void butPlayAgain_Click(object sender, EventArgs e)
        {
            next = "Game";
            Close();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            next = "Leave";
            Close();
        }
    }
}
