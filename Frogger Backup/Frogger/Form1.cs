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

        //vehicles

        //ROW 1
        //vehicle 1
        int vehicle1Row1PosX = 0;
        //vehicle 2
        int vehicle2Row1PosX = 0;
        //vehicle 3
        int vehicle3Row1PosX = 0;
        //vehicle 4
        int vehicle4Row1PosX = 0;

        //ROW 2
        //vehicle 1
        int vehicle1Row2PosX = 0;
        //vehicle 2
        int vehicle2Row2PosX = 0;
        //vehicle 3
        int vehicle3Row2PosX = 0;
        //vehicle 4
        int vehicle4Row2PosX = 0;

        //ROW 3
        //vehicle 1
        int vehicle1Row3PosX = 0;
        //vehicle 2
        int vehicle2Row3PosX = 0;
        //vehicle 3
        int vehicle3Row3PosX = 0;
        //vehicle 4
        int vehicle4Row3PosX = 0;
        //ROW 4
        //vehicle 1
        int vehicle1Row4PosX = 0;
        //vehicle 2
        int vehicle2Row4PosX = 0;
        //vehicle 3
        int vehicle3Row4PosX = 0;
        //vehicle 4
        int vehicle4Row4PosX = 0;

        //ROW 5
        //vehicle 1
        int vehicle1Row5PosX = 0;
        //vehicle 2
        int vehicle2Row5PosX = 0;
        //vehicle 3
        int vehicle3Row5PosX = 0;
        //vehicle 4
        int vehicle4Row5PosX = 0;

        //Turtles

        //ROW1
        //turtle 1
        int turtle1Row1PosX = 0;
        //turtle 2
        int turtle2Row1PosX = 0;
        //turtle 3
        int turtle3Row1PosX = 0;
        //turtle 4
        int turtle4Row1PosX = 0;
        //turtle 5
        int turtle5Row1PosX = 0;
        //turtle 6
        int turtle6Row1PosX = 0;
        //turtle 7
        int turtle7Row1PosX = 0;
        //turtle 8
        int turtle8Row1PosX = 0;
        //turtle 9
        int turtle9Row1PosX = 0;

        //Logs
        //Log 1
        int log1Row1PosX = 0;

        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();


        
        public Form1()
        {
            InitializeComponent();

            //hide lives cover up

            picLife1.Hide();
            picLife2.Hide();
            picLife3.Hide();

            //game tick controlling looping events

            t.Tick += (s, e) =>
            {
                moveCar();
                moveTurtle();
                moveLog();
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
            }
            if (vehicle4Row1PosX <= -120)
            {
                picVehicle4Row1.Left = 600;
                vehicle4Row1PosX = 120;
            }


            //ROW 2

            //car 1

            //if (vehicle1Row2PosX <= 120)
            {
                picVehicle1Row2.Left += 5;
                vehicle1Row2PosX += 1;
                //Console.WriteLine("Vehicle X Pos: " + vehicle2PosX);
            }
            if (vehicle1Row2PosX >= 120)
            {
                picVehicle1Row2.Left = -513;
                vehicle1Row2PosX = -120;
            }

            //car 2

            //if (vehicle2Row2PosX <= 120)
            {
                picVehicle2Row2.Left += 5;
                vehicle2Row2PosX += 1;
                //Console.WriteLine("Vehicle X Pos: " + vehicle2PosX);
            }
            if (vehicle2Row2PosX >= 120)
            {
                picVehicle2Row2.Left = -361;
                vehicle2Row2PosX = -120;
            }

            //car 3

            //if (vehicle3Row2PosX <= 120)
            {
                picVehicle3Row2.Left += 5;
                vehicle3Row2PosX += 1;
                //Console.WriteLine("Vehicle X Pos: " + vehicle2PosX);
            }
            if (vehicle3Row2PosX >= 120)
            {
                picVehicle3Row2.Left = -181;
                vehicle3Row2PosX = -120;
            }

            //car 4

            //if (vehicle4Row2PosX <= 120)
            {
                picVehicle4Row2.Left += 5;
                vehicle4Row2PosX += 1;
                //Console.WriteLine("Vehicle X Pos: " + vehicle2PosX);
            }
            if (vehicle4Row2PosX >= 120)
            {
                picVehicle4Row2.Left = 0;
                vehicle4Row2PosX = -120;
            }

            //ROW 3

            //car 1
            //if (vehicle1Row3PosX >= -120)
            {
                picVehicle1Row3.Left -= 5;
                vehicle1Row3PosX -= 1;
                
            }
            if (vehicle1Row3PosX <= -120)
            {
                picVehicle1Row3.Left = 1136;
                vehicle1Row3PosX = 120;
            }
            //car 2

            //if (vehicle2Row1PosX >= -120)
            {
                picVehicle2Row3.Left -= 5;
                vehicle2Row3PosX -= 1;
            }
            if (vehicle2Row3PosX <= -120)
            {
                picVehicle2Row3.Left = 781;
                vehicle2Row3PosX = 120;
            }

            //car 3

            //if (vehicle3Row1PosX >= -120)
            {
                picVehicle3Row3.Left -= 5;
                vehicle3Row3PosX -= 1;;
            }
            if (vehicle3Row3PosX <= -120)
            {
                picVehicle3Row3.Left = 961;
                vehicle3Row3PosX = 120;
            }

            //car 4

            //if (vehicle4Row1PosX >= -120)
            {
                picVehicle4Row3.Left -= 5;
                vehicle4Row3PosX -= 1;
            }
            if (vehicle4Row3PosX <= -120)
            {
                picVehicle4Row3.Left = 600;
                vehicle4Row3PosX = 120;
            }

            //ROW 4

            //car 1

            //if (vehicle1Row4PosX <= 120)
            {
                picVehicle1Row4.Left += 5;
                vehicle1Row4PosX += 1;
                //Console.WriteLine("Vehicle X Pos: " + vehicle2PosX);
            }
            if (vehicle1Row4PosX >= 120)
            {
                picVehicle1Row4.Left = -513;
                vehicle1Row4PosX = -120;
            }

            //car 2

            //if (vehicle2Row4PosX <= 120)
            {
                picVehicle2Row4.Left += 5;
                vehicle2Row4PosX += 1;
                //Console.WriteLine("Vehicle X Pos: " + vehicle2PosX);
            }
            if (vehicle2Row4PosX >= 120)
            {
                picVehicle2Row4.Left = -361;
                vehicle2Row4PosX = -120;
            }

            //car 3

            //if (vehicle3Row4PosX <= 120)
            {
                picVehicle3Row4.Left += 5;
                vehicle3Row4PosX += 1;
                //Console.WriteLine("Vehicle X Pos: " + vehicle2PosX);
            }
            if (vehicle3Row4PosX >= 120)
            {
                picVehicle3Row4.Left = -181;
                vehicle3Row4PosX = -120;
            }

            //car 4

            //if (vehicle4Row4PosX <= 120)
            {
                picVehicle4Row4.Left += 5;
                vehicle4Row4PosX += 1;
                //Console.WriteLine("Vehicle X Pos: " + vehicle2PosX);
            }
            if (vehicle4Row4PosX >= 120)
            {
                picVehicle4Row4.Left = 0;
                vehicle4Row4PosX = -120;
            }

            //ROW 5

            //car 1
            //if (vehicle1Row5PosX >= -120)
            {
                picVehicle1Row5.Left -= 5;
                vehicle1Row5PosX -= 1;
                
            }
            if (vehicle1Row5PosX <= -120)
            {
                picVehicle1Row5.Left = 1136;
                vehicle1Row5PosX = 120;
            }
            //car 2

            //if (vehicle2Row5PosX >= -120)
            {
                picVehicle2Row5.Left -= 5;
                vehicle2Row5PosX -= 1;
            }
            if (vehicle2Row5PosX <= -120)
            {
                picVehicle2Row5.Left = 781;
                vehicle2Row5PosX = 120;
            }

            //car 3

            //if (vehicle3Row5PosX >= -120)
            {
                picVehicle3Row5.Left -= 5;
                vehicle3Row5PosX -= 1;
            }
            if (vehicle3Row5PosX <= -120)
            {
                picVehicle3Row5.Left = 961;
                vehicle3Row5PosX = 120;
            }

            //car 4

            //if (vehicle4Row1PosX >= -120)
            {
                picVehicle4Row5.Left -= 5;
                vehicle4Row5PosX -= 1;
            }
            if (vehicle4Row5PosX <= -120)
            {
                picVehicle4Row5.Left = 600;
                vehicle4Row5PosX = 120;
            }
        }

        private void moveTurtle()
        {
            //ROW 1
            //Turle 1

            //if (turtle1Row1PosX >= -120)
            {
                picTurtle1Row1.Left -= 10;
                turtle1Row1PosX -= 2;
            }
            if (turtle1Row1PosX <= -120)
            {
                picTurtle1Row1.Left = 1136;
                turtle1Row1PosX = 120;
            }

            //Turle 2

            //if (turtle2Row1PosX >= -120)
            {
                picTurtle2Row1.Left -= 10;
                turtle2Row1PosX -= 2;
            }
            if (turtle2Row1PosX <= -120)
            {
                picTurtle2Row1.Left = 1086;
                turtle2Row1PosX = 120;
            }

            //Turle 3

            //if (turtle3Row1PosX >= -120)
            {
                picTurtle3Row1.Left -= 10;
                turtle3Row1PosX -= 2;
            }
            if (turtle3Row1PosX <= -120)
            {
                picTurtle3Row1.Left = 1036;
                turtle3Row1PosX = 120;
            }

            //Turle 4

            //if (turtle4Row1PosX >= -120)
            {
                picTurtle4Row1Water.Left -= 10;
                turtle4Row1PosX -= 2;

                //go underwater
                if (turtle4Row1PosX == -10 || turtle4Row1PosX == 50)
                {
                    Image img = new Bitmap(Properties.Resources.Screenshot_2026_11_27_223232_removebg_preview__1__removebg_preview);
                    picTurtle4Row1Water.Image = img;
                }
                if (turtle4Row1PosX == -14 || turtle4Row1PosX == 48)
                {
                    Image img = new Bitmap(Properties.Resources.Screenshot_2026_11_27_225809121_removebg_preview__1__removebg_preview);
                    picTurtle4Row1Water.Image = img;
                }
                if (turtle4Row1PosX == -16 || turtle4Row1PosX == 46)
                {
                    picTurtle4Row1Water.Visible = false;
                }
                if (turtle4Row1PosX == -18 || turtle4Row1PosX == 44)
                {
                    picTurtle4Row1Water.Visible = true;
                }
                if (turtle4Row1PosX == -20 || turtle4Row1PosX == 42)
                {
                    Image img = new Bitmap(Properties.Resources.Screenshot_2026_11_27_223232_removebg_preview__1__removebg_preview);
                    picTurtle4Row1Water.Image = img;
                }
                if (turtle4Row1PosX == -22 || turtle4Row1PosX == 40)
                {
                    Image img = new Bitmap(Properties.Resources.Turtle___Frogger_29___10_removebg_preview);
                    picTurtle4Row1Water.Image = img;
                }
            }
            if (turtle4Row1PosX <= -120)
            {
                picTurtle4Row1Water.Left = 936;
                turtle4Row1PosX = 120;
            }

            //Turle 5

            //if (turtle5Row1PosX >= -120)
            {
                picTurtle5Row1Water.Left -= 10;
                turtle5Row1PosX -= 2;
                
                //go underwater
                if (turtle5Row1PosX == -10 || turtle5Row1PosX == 50)
                {
                    Image img = new Bitmap(Properties.Resources.Screenshot_2026_11_27_223232_removebg_preview__1__removebg_preview);
                    picTurtle5Row1Water.Image = img;
                }
                if (turtle5Row1PosX == -14 || turtle5Row1PosX == 48)
                {
                    Image img = new Bitmap(Properties.Resources.Screenshot_2026_11_27_225809121_removebg_preview__1__removebg_preview);
                    picTurtle5Row1Water.Image = img;
                }
                 if (turtle5Row1PosX == -16 || turtle5Row1PosX == 46)
                {
                    picTurtle5Row1Water.Visible = false;
                }
                if (turtle5Row1PosX == -18 || turtle5Row1PosX == 44)
                {
                    picTurtle5Row1Water.Visible = true;
                }
                if (turtle5Row1PosX == -20 || turtle5Row1PosX == 42)
                {
                    Image img = new Bitmap(Properties.Resources.Screenshot_2026_11_27_223232_removebg_preview__1__removebg_preview);
                    picTurtle5Row1Water.Image = img;
                }
                if (turtle5Row1PosX == -22 || turtle5Row1PosX == 40)
                {
                    Image img = new Bitmap(Properties.Resources.Turtle___Frogger_29___10_removebg_preview);
                    picTurtle5Row1Water.Image = img;
                }
            }
            if (turtle5Row1PosX <= -120)
            {
                picTurtle5Row1Water.Left = 886;
                turtle5Row1PosX = 120;
            }

            //Turle 6

            //if (turtle6Row1PosX >= -120)
            {
                picTurtle6Row1Water.Left -= 10;
                turtle6Row1PosX -= 2;

                //go underwater
                if (turtle6Row1PosX == -10 || turtle6Row1PosX == 50)
                {
                    Image img = new Bitmap(Properties.Resources.Screenshot_2026_11_27_223232_removebg_preview__1__removebg_preview);
                    picTurtle6Row1Water.Image = img;
                }
                if (turtle6Row1PosX == -14 || turtle6Row1PosX == 48)
                {
                    Image img = new Bitmap(Properties.Resources.Screenshot_2026_11_27_225809121_removebg_preview__1__removebg_preview);
                    picTurtle6Row1Water.Image = img;
                }
                if (turtle6Row1PosX == -16 || turtle6Row1PosX == 46)
                {
                    picTurtle6Row1Water.Visible = false;
                }
                if (turtle6Row1PosX == -18 || turtle6Row1PosX == 44)
                {
                    picTurtle6Row1Water.Visible = true;
                }
                if (turtle6Row1PosX == -20 || turtle6Row1PosX == 42)
                {
                    Image img = new Bitmap(Properties.Resources.Screenshot_2026_11_27_223232_removebg_preview__1__removebg_preview);
                    picTurtle6Row1Water.Image = img;
                }
                if (turtle6Row1PosX == -22 || turtle6Row1PosX == 40)
                {
                    Image img = new Bitmap(Properties.Resources.Turtle___Frogger_29___10_removebg_preview);
                    picTurtle6Row1Water.Image = img;
                }
            }
            if (turtle6Row1PosX <= -120)
            {
                picTurtle6Row1Water.Left = 836;
                turtle6Row1PosX = 120;
            }

            //Turle 7

            //if (turtle7Row1PosX >= -120)
            {
                picTurtle7Row1.Left -= 10;
                turtle7Row1PosX -= 2;
            }
            if (turtle7Row1PosX <= -120)
            {
                picTurtle7Row1.Left = 736;
                turtle7Row1PosX = 120;
            }

            //Turle 8

            //if (turtle8Row1PosX >= -120)
            {
                picTurtle8Row1.Left -= 10;
                turtle8Row1PosX -= 2;
            }
            if (turtle8Row1PosX <= -120)
            {
                picTurtle8Row1.Left = 686;
                turtle8Row1PosX = 120;
            }

            //Turle 9

            //if (turtle8Row1PosX >= -120)
            {
                picTurtle9Row1.Left -= 10;
                turtle9Row1PosX -= 2;
            }
            if (turtle9Row1PosX <= -120)
            {
                picTurtle9Row1.Left = 636;
                turtle9Row1PosX = 120;
            }
        }

        private void moveLog()
        {
            //ROW 1

            //Log 1

            //if (log1Row1PosX >= -120)
            {
                picLog1Row1.Left += 10;
                log1Row1PosX += 2;
            }
            if (log1Row1PosX >= 120)
            {
                picLog1Row1.Left = 0;
                log1Row1PosX = -120;
            }
        }

        void gameover()
        {
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
                picFrog.Left = 309;
                picFrog.Top = 581;
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

                //reset row 2 vehicle's position
                picVehicle1Row2.Left = 12;
                vehicle1Row2PosX = 0;

                picVehicle2Row2.Left = 174;
                vehicle2Row2PosX = 0;

                picVehicle3Row2.Left = 354;
                vehicle3Row2PosX = 0;

                picVehicle4Row2.Left = 535;
                vehicle4Row2PosX = 0;

                //reset row 3 vehicle's position
                picVehicle1Row3.Left = 535;
                vehicle1Row3PosX = 0;

                picVehicle2Row3.Left = 354;
                vehicle2Row3PosX = 0;

                picVehicle3Row3.Left = 174;
                vehicle3Row3PosX = 0;

                picVehicle4Row3.Left = 12;
                vehicle4Row3PosX = 0;

                //reset row 4 vehicle's position
                picVehicle1Row4.Left = 12;
                vehicle1Row4PosX = 0;

                picVehicle2Row4.Left = 174;
                vehicle2Row4PosX = 0;

                picVehicle3Row4.Left = 354;
                vehicle3Row4PosX = 0;

                picVehicle4Row4.Left = 535;
                vehicle4Row4PosX = 0;

                //reset row 5 vehicle's position
                picVehicle1Row5.Left = 535;
                vehicle1Row5PosX = 0;

                picVehicle2Row5.Left = 354;
                vehicle2Row5PosX = 0;

                picVehicle3Row5.Left = 174;
                vehicle3Row5PosX = 0;

                picVehicle4Row5.Left = 12;
                vehicle4Row5PosX = 0;

                Console.Beep();

                if (lives == 2)
                {
                    picLife3.Visible = true;
                }
                else if (lives == 1)
                {
                    picLife2.Visible = true;
                    picLife3.Visible = true;
                }
            }

            else
            {
                Console.Beep();
                picLife1.Visible = true;
                picLife2.Visible = true;
                picLife3.Visible = true;

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

            // row 1
            if (picFrog.Bounds.IntersectsWith(picVehicle1Row1.Bounds))
            {
                updateLives();
                
            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle2Row1.Bounds)){
                updateLives();
            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle3Row1.Bounds))
            {
                updateLives();
            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle4Row1.Bounds))
            {
                updateLives();
            }

            //row 2

            else if (picFrog.Bounds.IntersectsWith(picVehicle1Row2.Bounds))
            {
                updateLives();

            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle2Row2.Bounds))
            {
                updateLives();
            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle3Row2.Bounds))
            {
                updateLives();
            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle4Row2.Bounds))
            {
                updateLives();
            }

            //row 3

            else if (picFrog.Bounds.IntersectsWith(picVehicle1Row3.Bounds))
            {
                updateLives();

            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle2Row3.Bounds))
            {
                updateLives();
            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle3Row3.Bounds))
            {
                updateLives();
            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle4Row3.Bounds))
            {
                updateLives();
            }

            //row 4

            else if (picFrog.Bounds.IntersectsWith(picVehicle1Row4.Bounds))
            {
                updateLives();

            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle2Row4.Bounds))
            {
                updateLives();
            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle3Row4.Bounds))
            {
                updateLives();
            }
            else if (picFrog.Bounds.IntersectsWith(picVehicle4Row4.Bounds))
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

            Image img = new Bitmap(Properties.Resources.New_Project__3__removebg_preview13);
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
                    picFrog.Top -= 37; 
                    playerPosY += 1;
                    setAimTarget(0);
                    break;

                case Keys.Up:
                    picFrog.Top -= 37;
                    playerPosY += 1;
                    setAimTarget(0);
                    break;

                //move down
                case Keys.S:
                    if (playerPosY >0){
                        picFrog.Top += 37;
                        playerPosY -= 1;
                        hasAdvanced = false;
                        setAimTarget(180);
                    }
                    break;

                case Keys.Down:
                    if (playerPosY > 0)
                    {
                        picFrog.Top += 37;
                        playerPosY -= 1;
                        hasAdvanced = false;
                        setAimTarget(180);
                    }
                    break;

                //move right
                case Keys.D:
                    if (playerPosX <11)
                    {
                        picFrog.Left += picFrog.Width;
                        playerPosX += 1;
                        setAimTarget(90);   
                    }
                    break;


                case Keys.Right:
                    if (playerPosX < 11)
                    {
                        picFrog.Left += picFrog.Width;
                        playerPosX += 1;
                        setAimTarget(90);
                    }
                    break;

                //move left
                case Keys.A:
                    if (playerPosX > -13)
                    {
                        picFrog.Left -= picFrog.Width;
                        playerPosX -= 1;
                        setAimTarget(270);
                    }
                    break;

                case Keys.Left:
                    if (playerPosX > -13)
                    {
                        picFrog.Left -= picFrog.Width;
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

        private void picFrog_Click(object sender, EventArgs e)
        {

        }
    }
}