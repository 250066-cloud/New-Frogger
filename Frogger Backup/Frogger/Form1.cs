using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Frogger
{


    public partial class Form1 : Form
    {
        int playerPosX = 0;
        int playerPosY = 0;
        int maxXRowReached = 0;
        bool hasAdvanced = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void setScore()
        {

                score_label.Text = (maxXRowReached*10).ToString();


        }
        void setAimTarget(int direction)
        {
            
            Console.WriteLine("X: "+ playerPosX + "\nY: " + playerPosY + "\nMax: " + maxXRowReached + "\nadvanced: " + hasAdvanced + "\nscore: " + maxXRowReached*10);
            Image img = new Bitmap(Properties.Resources.New_Project__3__removebg_preview1);
            switch (direction)
            {
                case 0:
                    break;
                case 90:
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 180:
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 270:
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;

            }
            pictureBox1.Image = img;
        }
        private void onKeyPress(object sender, KeyEventArgs e)
        {

            if (playerPosY >= maxXRowReached)
            {
                maxXRowReached = playerPosY+1;
                hasAdvanced = true;
            }

            switch (e.KeyCode) {

                //move up
                case Keys.W:
                    setScore();
                    pictureBox1.Top -= 80;
                    playerPosY += 1;
                    setAimTarget(0);
                    break;

                case Keys.Up:
                    setScore();
                    pictureBox1.Top -= 80;
                    playerPosY += 1;
                    setAimTarget(0);
                    break;

                //move down
                case Keys.S:
                    pictureBox1.Top += 80;
                    playerPosY -= 1;
                    hasAdvanced = false;
                    setAimTarget(180);
                    break;

                case Keys.Down:
                    pictureBox1.Top += 80;
                    playerPosY -= 1;
                    hasAdvanced = false;
                    setAimTarget(180);
                    break;

                //move right
                case Keys.D:
                    pictureBox1.Left += 80;
                    playerPosX += 1;
                    setAimTarget(90);
                    break;

                case Keys.Right:
                    pictureBox1.Left += 80;
                    playerPosX += 1;
                    setAimTarget(90);
                    break;

                //move left
                case Keys.A:
                    pictureBox1.Left -= 80;
                    playerPosX -= 1;
                    setAimTarget(270);
                    break;

                case Keys.Left:
                    pictureBox1.Left -= 80;
                    playerPosX -= 1;
                    setAimTarget(270);
                    break;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
