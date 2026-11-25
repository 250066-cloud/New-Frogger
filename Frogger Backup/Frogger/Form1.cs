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
        //player 
        string next = "Leave";
        int playerPosX = 0;
        int playerPosY = 0;
        int maxXRowReached = 0;
        bool hasAdvanced = false;
        int lives = 3;
        //ROW 1
        //vehicle 1
        int vehicle1Row1PosX = 0;
        //vehicle 2
        int vehicle2Row1PosX = 0;
        //vehicle 3
        int vehicle3Row1PosX = 0;
        //vehicle 4
        int vehicle4Row1PosX = 0;
        int vehicle2PosX = 0;
        //vehicle 3
        int vehicle3PosX = 0;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();



        public Form1()
        {
            InitializeComponent();
            t.Tick += (s, e) =>
            {
                moveCar();
                isTouching();
                Thread.Sleep(1);
            };
            t.Start();

            
            
        }

        private void moveCar()
        {;

            //ROW 1

            //car 1
            //if (vehicle1Row1PosX >= -120)
            {
                picVehicle1Row1.Left -= 5;
                vehicle1Row1PosX -= 1;
                Console.WriteLine("Vehicle1 X Pos: " + vehicle1Row1PosX);
            }
             if (vehicle1Row1PosX <= -120)
            {
                picVehicle1Row1.Left = 1136;
                vehicle1Row1PosX = 120;
            }
            //car 2

            //if (vehicle2Row1PosX >= -120)
            {
                picVehicle2Row1.Left -= 5;
                vehicle2Row1PosX -= 1;
                Console.WriteLine("Vehicle2 X Pos: " + vehicle2Row1PosX);
            }
            if (vehicle2Row1PosX <= -120)
            {
                picVehicle2Row1.Left = 781;
                vehicle2Row1PosX = 120;
            }

            //car 3

            //if (vehicle3Row1PosX >= -120)
            {
                picVehicle3Row1.Left -= 5;
                vehicle3Row1PosX -= 1;
                Console.WriteLine("Vehicle3 X Pos: " + vehicle3Row1PosX);
            }
            if (vehicle3Row1PosX <= -120)
            {
                picVehicle3Row1.Left = 961;
                vehicle3Row1PosX = 120;
            }

            //car 4

            //if (vehicle4Row1PosX >= -120)
            {
                picVehicle4Row1.Left -= 5;
                vehicle4Row1PosX -= 1;
                Console.WriteLine("Vehicle3 X Pos: " + vehicle4Row1PosX);
            }
            if (vehicle4Row1PosX <= -120)
            {
                picVehicle4Row1.Left = 600;
                vehicle4Row1PosX = 120;
            }

            //car 2

            if (vehicle2PosX <= 120)
            {
                picVehicle2.Left += 5;
                vehicle2PosX += 1;
                //Console.WriteLine("Vehicle X Pos: " + vehicle2PosX);
            }
            if (vehicle2PosX >= 120)
            {
                picVehicle2.Left = 0;
                vehicle2PosX = 0;
            }

            //car 3
            if (vehicle3PosX >= -120)
            {
                picVehicle3.Left -= 5;
                vehicle3PosX -= 1;
                //Console.WriteLine("Vehicle X Pos: " + vehicle1PosX);
            }
            if (vehicle3PosX <= -120)
            {
                picVehicle3.Left = 600;
                vehicle3PosX = 0;
            }
        }

        void gameover()
        {
            labLives.Text = "GAMEOVER";
            next = "MainMenu";
            Close();
        }

        public string getNext()
        {
            return next;
        }

        void updateLives()
        {
            if (lives>1)
            {

                //reset player's position
                lives -= 1;
                labLives.Text = "LIVES "+ lives;
                picFrog.Left = 267;
                picFrog.Top = 603;
                playerPosX = 0;
                playerPosY= 0;
                setAimTarget(0);

                //reset row 1 vehicle's position
                picVehicle1Row1.Left = 535;
                vehicle1Row1PosX = 0;

                picVehicle2Row1.Left = 354;
                vehicle2Row1PosX = 0;

                picVehicle3Row1.Left = 174;
                vehicle3Row1PosX = 0;

                picVehicle4Row1.Left = 12;
                vehicle4Row1PosX = 0;


                Console.Beep();
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
                picFrog.Left = 267;
                picFrog.Top = 603;
                playerPosX = 0;
                playerPosY = 0;
                setAimTarget(0);
                gameover();

            }
            
        }
        void isTouching()
        {
            if (picFrog.Bounds.IntersectsWith(picVehicle1Row1.Bounds)|| picFrog.Bounds.IntersectsWith(picVehicle2Row1.Bounds) || picFrog.Bounds.IntersectsWith(picVehicle3Row1.Bounds) || picFrog.Bounds.IntersectsWith(picVehicle4Row1.Bounds) || picFrog.Bounds.IntersectsWith(picVehicle2.Bounds) || picFrog.Bounds.IntersectsWith(picVehicle3.Bounds))
            {
                updateLives();
                
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
                    picFrog.Top -= picFrog.Width; 
                    playerPosY += 1;
                    setAimTarget(0);
                    break;

                case Keys.Up:
                    picFrog.Top -= picFrog.Width;
                    playerPosY += 1;
                    setAimTarget(0);
                    break;

                //move down
                case Keys.S:
                    if (playerPosY >0){
                        picFrog.Top += picFrog.Width;
                        playerPosY -= 1;
                        hasAdvanced = false;
                        setAimTarget(180);
                    }
                    break;

                case Keys.Down:
                    if (playerPosY > 0)
                    {
                        picFrog.Top += picFrog.Width;
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
            //Console.WriteLine("X: " + playerPosX + "\nY: " + playerPosY + "\nMax: " + maxXRowReached + "\nadvanced: " + hasAdvanced + "\nscore: " + maxXRowReached * 10);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}