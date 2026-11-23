using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Transactions;
using System.Windows.Forms;

namespace Frogger
{


    public partial class Form1 : Form
    {
        int playerPosX = 0;
        int playerPosY = 0;
        int vehiclePosX = 0;
        int vehiclePosY = 0;
        int maxXRowReached = 0;
        bool hasAdvanced = false;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();



        public Form1()
        {

            InitializeComponent();
            t.Tick += (s, e) =>
            {
                moveCar();
                Thread.Sleep(1);
            };
            t.Start();

            
        }

        private void moveCar()
        {
            if (vehiclePosX >= -20)
            {

                picVehicle.Left -= 30;
                vehiclePosX -= 1;
                Console.WriteLine("Vehicle X Pos: " + vehiclePosX);
            }


        }
        
        void setScore()
        {
            if (hasAdvanced)
            {
                score_label.Text = (maxXRowReached * 10).ToString();

            }
        }

        void setAimTarget(int direction)
        {

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
            picFrog.Image = img;
        }
        private void onKeyPress(object sender, KeyEventArgs e)
        {


            //player movement

            switch (e.KeyCode)
            {

                //move up
                case Keys.W:
                    picFrog.Top -= 50; 
                    playerPosY += 1;
                    setAimTarget(0);
                    break;

                case Keys.Up:
                    picFrog.Top -= 50;
                    playerPosY += 1;
                    setAimTarget(0);
                    break;

                //move down
                case Keys.S:
                    if (playerPosY >0){
                        picFrog.Top += 80;
                        playerPosY -= 1;
                        hasAdvanced = false;
                        setAimTarget(180);
                    }
                    break;

                case Keys.Down:
                    if (playerPosY > 0)
                    {
                        picFrog.Top += 50;
                        playerPosY -= 1;
                        hasAdvanced = false;
                        setAimTarget(180);
                    }
                    break;

                //move right
                case Keys.D:
                    if (playerPosX <6)
                    {
                        picFrog.Left += 50;
                        playerPosX += 1;
                        setAimTarget(90);   
                    }
                    break;


                case Keys.Right:
                    if (playerPosX < 6)
                    {
                        picFrog.Left += 50;
                        playerPosX += 1;
                        setAimTarget(90);
                    }
                    break;

                //move left
                case Keys.A:
                    if (playerPosX > -5)
                    {
                        picFrog.Left -= 50;
                        playerPosX -= 1;
                        setAimTarget(270);
                    }
                    break;

                case Keys.Left:
                    if (playerPosX > -5)
                    {
                        picFrog.Left -= 50;
                        playerPosX -= 1;
                        setAimTarget(270);
                    }
                    break; 
            }

            //setting the  max row reached

            if (playerPosY > maxXRowReached)
            {
                hasAdvanced = true;
                maxXRowReached = playerPosY;
            }
            //setting the score

            setScore();
            Console.WriteLine("X: " + playerPosX + "\nY: " + playerPosY + "\nMax: " + maxXRowReached + "\nadvanced: " + hasAdvanced + "\nscore: " + maxXRowReached * 10);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}