using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    
    public partial class Pong : Form
    {
        
        //speed variables
        static int speedInitial = 5;
        int cpuSpeed = 7;
        int p1Speed = 7;
        int ballX = speedInitial;
        int ballY = speedInitial;
        
        int speedup = 2;
        //score
        int playerScore = 0;
        int cpuScore = 0;

        //size
        int bottomBoundry;
        int xMid;
        int yMid;

        //detection
        bool playerUp;
        bool playerDown;

        bool player2Up;
        bool player2Down;

        //misc
        int spaceClicked = 0;

       
        

        public Pong()
        {
            InitializeComponent();
            bottomBoundry = ClientRectangle.Size.Height - player1.Height;
            xMid = ClientSize.Width / 2;
            yMid = ClientSize.Height / 2;
        }

        
        private void score_p1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ball position
            ball.Top -= ballY;
            ball.Left -= ballX;

            //CPU player movement
            //player2.Top += cpuSpeed;

            //if(player2.Top <0 || player2.Top>bottomBoundry)
            //{
            //    cpuSpeed = -cpuSpeed;
            //}

            //check if ball exited screen
            if(ball.Left <0)
            {
                ball.Left = xMid;
                ball.Top = yMid;
                ballX = -speedInitial;
                if (ballY > 0)
                {
                    ballY = speedInitial;
                }
                else
                    ballY = -speedInitial;
                
                cpuScore++;
                score_p2_label.Text = cpuScore.ToString();
            }
            if(ball.Right>ClientSize.Width)
            {
                ball.Left = xMid;
                ball.Top = yMid;
                ballX= speedInitial;
                if (ballY > 0)
                {
                    ballY = speedInitial;
                }
                else
                    ballY = -speedInitial;

                playerScore++;
                score_p1_label.Text = playerScore.ToString();
            }
            if(ball.Top<0 || ball.Bottom>ClientSize.Height)
            {
                ballY = -ballY;
            }

            //ball hitting players

            if(ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {
                ballX= -ballX;
                if((ball.Top > player1.Bottom&& ball.Left>player1.Right) || ball.Top > player2.Bottom && ball.Right > player2.Left)
                {
                    ballY=-ballY;
                }
               
                
                    if (ballX > 0) { ballX += speedup; }
                    else { ballX -= speedup; }
                    if (ballY > 0) { ballY += speedup; }
                    else { ballY -= speedup; }
                
            }
           

            //player controlls
            if (playerUp == true && player1.Top > 0)
            {
                player1.Top -= p1Speed;
            }
            if (playerDown == true && player1.Top < bottomBoundry)
            {
                player1.Top += p1Speed;
            }

            if (player2Up == true && player2.Top > 0)
            {
                player2.Top -= cpuSpeed;
            }
            if (player2Down == true && player2.Top < bottomBoundry)
            {
                player2.Top += cpuSpeed;
            }

            //check for winner
            if (playerScore>=10 || cpuScore>=10)
            {
                timer1.Stop();
                Form ending = new EndingForm();
                ending.Owner = this;
                ending.Show();
                
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                playerUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                playerDown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                player2Up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                player2Down = false;
            }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                playerUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                playerDown = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                player2Up = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                player2Down = true;
            }

            if (e.KeyCode ==Keys.Space)
            {
                if (spaceClicked % 2 == 0)
                    timer1.Stop();
                else
                    timer1.Start();
                spaceClicked++;
            }
        }
    }
}
