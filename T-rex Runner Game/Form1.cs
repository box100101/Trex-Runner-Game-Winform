using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace T_rex_Runner_Game
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        // Declare variables
        int cloudSpeed = 1;
        int cactusSpeed = 5;
        int birdSpeed = 6;
        int meteoriteSpeed = 8;
        int gravity = 3;
        int _score = 0;
        int score_temp = 0;
        int _highestScore = 0;
        bool isGameOver = false, isFirst = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dinosaur.Parent = ground1;
            //dinosaur.Location = new Point(dinosaur.Location.X - ground1.Location.X, dinosaur.Location.Y - ground1.Location.Y);

            gameTimer.Stop();
            dinosaur.Visible = false;

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            banner.Visible = false;
            dinosaur.Visible = true;

            score_temp++;
            if(score_temp % 5 == 0) {
                _score++;
                showScore(_score.ToString().Length, score);
            }

            if (_highestScore <= _score)
            {
                showScore(_score.ToString().Length, highestScore);
                _highestScore = _score;
            }

            // Dinosaur
            dinosaur.Top += gravity;     
            if(dinosaur.Top >= 195)
            {
                dinosaur.Top = 195;
            }


            // Cactuses
            cactus1.Left -= cactusSpeed;
            cactus2.Left -= cactusSpeed;
            cactus3.Left -= cactusSpeed;
            if (cactus1.Left <= -700)
            {
                cactus1.Left = 1090;
            }
            if (cactus2.Left <= -700)
            {
                cactus2.Left = 1090;
            }
            if (cactus3.Left <= -700)
            {
                cactus3.Left = 1090;
            }


            // Clouds
            cloud1.Left -= cloudSpeed;
            cloud2.Left -= cloudSpeed;
            if(cloud1.Left < -1090)
            {
                cloud1.Left = 1090;
            }
            if(cloud2.Left < -1090)
            {
                cloud2.Left = 1090;
            }


            // Meteorites
            if (meteorite1.Visible)
            {
                meteorite1.Left -= meteoriteSpeed;
                meteorite1.Top += meteoriteSpeed - 4;
                if (meteorite1.Left < -900 && meteorite1.Top > 200)
                {
                    meteorite1.Left = 1200;
                    meteorite1.Top = 0;
                }
            }

            if (meteorite2.Visible)
            {
                meteorite2.Left -= (meteoriteSpeed + 3);
                meteorite2.Top += (meteoriteSpeed - 5);
                if (meteorite2.Left < -700)
                {
                    meteorite2.Left = 1090;
                    meteorite2.Top = 30 ;
                }
            }
            

            // Bird
            if (bird1.Visible)
            {
                bird1.Left -= birdSpeed;

                if (bird1.Left < -700)
                {
                    bird1.Left = 1090;
                }
            }

            // Handle level
            if (_score >= 100 && _score < 200)
            {
                bird1.Visible = true;
                cactusSpeed = 6;
                cloudSpeed = 2;
                gravity = 4;
                showUpLevel(100, 120);
            }
            else if(_score >= 200 && _score < 300)
            {
                cactusSpeed = 7;
                cloudSpeed = 3;
                gravity = 4;
                birdSpeed = 7;
                showUpLevel(200, 220);

                ground1.BackColor = Color.Black;
                cloud1.BackColor = Color.Black;
                cloud2.BackColor = Color.Black;
            }
            else if (_score >= 300 && _score < 400)
            {
                meteorite1.Visible = true;
                meteorite2.Visible = true; 
                cactusSpeed = 8;
                cloudSpeed = 4;
                gravity = 5;
                birdSpeed = 8;
                showUpLevel(300, 320);
            }
            else if (_score >= 400 && _score < 500)
            {
                cactusSpeed = 9;
                cloudSpeed = 5;
                gravity = 6;
                birdSpeed = 9;
                showUpLevel(400, 420);

            }

            // Check game over
            if (dinosaur.Bounds.IntersectsWith(cactus1.Bounds) || 
                dinosaur.Bounds.IntersectsWith(cactus2.Bounds) ||
                dinosaur.Bounds.IntersectsWith(cactus3.Bounds) ||
                dinosaur.Bounds.IntersectsWith(bird1.Bounds) ||
                dinosaur.Bounds.IntersectsWith(meteorite2.Bounds))
            {
                isGameOver = endGame();
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {

                if (isGameOver)
                {
                    btnReplay_Click(sender, e);
                    isGameOver = false;
                }
                else
                {
                    if (isFirst)
                    {
                        dinosaur.Top = 195;
                    }
                    else
                    {
                        if(dinosaur.Top == 195)
                        {
                            dinosaur.Top = -10;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                if (isFirst)
                {
                    isFirst = false;
                    gameTimer.Start();
                }
            }            
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                dinosaur.Top += -2;
            }
        }

        private bool endGame()
        {
            gameTimer.Stop();
            gameOver.Visible = true;
            btnReplay.Visible = true;
            return true;
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            gameOver.Visible = false;
            btnReplay.Visible = false;
            bird1.Visible = false;
            meteorite1.Visible = false;
            meteorite2.Visible = false;

            gravity = 3;
            cactusSpeed = 5;
            birdSpeed = 6;
            cloudSpeed = 1;
            score_temp = 0;
            dinosaur.Top = 195;

            cactus1.Left = 1100;
            cactus2.Left = 1600;
            cactus3.Left = 2100;

            meteorite1.Left = 1200;
            meteorite1.Top = 8;
            meteorite2.Left = 1300;
            meteorite2.Top = 0;

            bird1.Left = 1700;

            _score = 0;

            ground1.BackColor = Color.White;
            cloud1.BackColor = Color.White;
            cloud2.BackColor = Color.White;


            cloud1.Left = 0;
            cloud2.Left = 1090;

            gameTimer.Start();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
        }

        private void showScore(int length, Label label)
        {
            switch (length)
            {
                case 1:
                    label.Text = "0000" + _score.ToString();
                    break;
                case 2:
                    label.Text = "000" + _score.ToString();
                    break;
                case 3:
                    label.Text = "00" + _score.ToString();
                    break;
                case 4:
                    label.Text = "0" + _score.ToString();
                    break;
                case 5:
                    label.Text = _score.ToString();
                    break;
            }
        }

        private void showUpLevel(int startShow, int endShow)
        {
            if (_score == startShow)
            {
                upLevel.Visible = true;
            }
            if (_score > endShow)
            {
                upLevel.Visible = false;
            }
        }
    }
}
