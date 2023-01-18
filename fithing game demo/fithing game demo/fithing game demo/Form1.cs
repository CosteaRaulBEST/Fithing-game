using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fithing_game_demo
{
    public partial class Form1 : Form
    {
        public Image background = Image.FromFile("../../../images/background.png");
        public Image blurredBackground = Image.FromFile(("../../../images/backgroundblured.png"));
        public bool isBlurred = true;
        SoundPlayer backgroundmuzic = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.Init(this);
            Engine.form.MenuScreen.Width = Engine.form.Width;
            Engine.form.MenuScreen.Height = Engine.form.Height;
            Engine.player1 = new Player1();
            Engine.player2 = new Player2();
            Engine.player2.FlipImage();
            Engine.form.DoubleBuffered = true;
            Engine.form.player1HPbar.ForeColor = Color.Red;
            Engine.form.player2HPbar.ForeColor = Color.Red;
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Engine.player1.Move();
            Engine.player2.Move();

        }
        private async void ExitGame(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (Engine.form.MenuScreen.Visible == false && Engine.form.CounterImage.Visible == false)
                {
                    Engine.PauseGame();
                    Engine.form.Resume.BringToFront();
                    Engine.form.pauseImage.Visible = true;
                    Engine.form.Restart.BringToFront();
                    Engine.form.Exit.BringToFront();
                    Engine.form.PauseGameImage.Visible = true;
                    Engine.form.Restart.Visible = true;
                    Engine.form.Resume.Visible = true;
                    Engine.form.Exit.Visible = true;
                    Engine.form.Exit.Enabled = true;
                    Engine.form.Restart.Enabled = true;
                    Engine.form.Resume.Enabled = true;
                }
            }
            if (e.KeyCode == Keys.A)
            {
                Engine.player1.isMovingLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                Engine.player1.isMovingRight = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                Engine.player2.isMovingLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                Engine.player2.isMovingRight = true;
            }
            if (e.KeyCode == Keys.R)
            {
                Engine.player1.attacksound.Play();
                if (Engine.player1.isAttacking == false)
                {
                    Engine.player1.playeratackingnum = 0;
                    Engine.player1.setAttackStance();
                    Engine.player1.isAttacking = true;
                    atackanimationp1.Enabled = true;
                    await Task.Delay(500);
                    Engine.player1.isAttacking = false;

                    Engine.player1.PlayerHits();
                }
                Engine.form.timerplayer1animations.Enabled = true;

            }
            if (e.KeyCode == Keys.L)
            {
                Engine.player2.attacksound.Play();  
                if (Engine.player2.isAttacking == false)
                {
                    Engine.player2.playeratackingnum = 0;
                    Engine.player2.setAttackStance();
                    Engine.player2.isAttacking = true;
                    atackanimationp2.Enabled = true;
                    await Task.Delay(500);
                    Engine.player2.isAttacking = false;
                    Engine.player2.PlayerHits();
                }
                Engine.form.timerplayer2animations.Enabled = true;
            }
            if (e.KeyCode == Keys.S)
            {
                Engine.player1.setBlockStance();
                Engine.player1.isBlocking = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                Engine.player2.setBlockStance();
                Engine.player2.isBlocking = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Engine.player1.isMovingLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                Engine.player1.isMovingRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                Engine.player2.isMovingLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                Engine.player2.isMovingRight = false;
            }
            if (e.KeyCode == Keys.R)
            {
                Engine.player1.setNormalStance();
            }
            if (e.KeyCode == Keys.L)
            {
                Engine.player2.setNormalStance();
            }
            if (e.KeyCode == Keys.S)
            {
                Engine.player1.setNormalStance();
                Engine.player1.isBlocking = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                Engine.player2.setNormalStance();
                Engine.player2.isBlocking = false;
            }
        }
        private void timerplayer1animations_Tick(object sender, EventArgs e)
        {
            Engine.player1.setIdleAnimation();
            Engine.player1.setMovingAnimation();
        }
        private void timerplayer2animations_Tick_1(object sender, EventArgs e)
        {
            Engine.player2.setIdleAnimation();
            Engine.player2.setMovingAnimation();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Engine.form.StartButton.Enabled == true)
            {
                Engine.form.StartButton.Enabled = false;
                Engine.form.ExitButton.Enabled = false;
                Engine.form.PauseTimer.Enabled = true;
                Engine.form.MenuScreen.Enabled = false;
                Engine.form.MenuScreen.Visible = false;
                Engine.form.StartButton.Visible = false;
                Engine.form.ExitButton.Visible = false;
                Engine.form.player2wins2.Visible = true;
                Engine.form.player2wins1.Visible = true;
                Engine.form.player1wins2.Visible = true;
                Engine.form.player1wins1.Visible = true;
                Engine.form.timer1.Enabled = true;
                Engine.form.countdown.Enabled = true;
                Engine.form.textcountdowner.Visible = true;
                Engine.form.textcountdowner.Enabled = false;
                Engine.form.player1poze.Visible = true;
                Engine.form.player2poze.Visible = true;
                Engine.form.timerplayer1animations.Enabled = true;
                Engine.form.timerplayer2animations.Enabled = true;
                Engine.form.player1name.Visible = true;
                Engine.form.player2name.Visible = true;
                
            }

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if(Engine.form.ExitButton.Enabled == true)
            Engine.form.Close();
        }
        private void PauseTimer_Tick(object sender, EventArgs e)
        {
           
            Engine.form.CounterImage.Visible = true;
            Engine.StartCounterImages();
            Engine.PauseGame();
            Engine.PauseTimerCount++;
            if (Engine.PauseTimerCount == 5)
            {
                PauseTimer.Stop();
                PauseTimer.Enabled = false;
                Engine.PauseTimerCount = 0;
                Engine.form.CounterImage.Visible = false;
                Engine.ResumeGame();
            }

        }
        private void CheckThings_Tick(object sender, EventArgs e)
        {
            
            Engine.form.DoubleBuffered = true;
            Engine.form.Refresh();
            Engine.CheckPLayerLocation();
            Engine.EndRound();
            Engine.EndGame();
            Engine.Paint();
            if (Engine.form.PauseTimer.Enabled == true)
            {
                Engine.form.timerplayer1animations.Enabled = true;
                Engine.form.timerplayer2animations.Enabled = true;
            }
            if (Engine.player1.isHitted == true)
            {
                p1damaged.Enabled = true;
            }
            Engine.player1.isHitted = false;

            if (Engine.player2.isHitted == true)
            {
                p2damaged.Enabled = true;
            }
        }
        private void Resume_Click(object sender, EventArgs e)
        {
            if (Engine.form.Resume.Enabled == true)
            {
                Engine.DeletePauseImage();
                Engine.ResumeGame();
            }

        }
        private void Restart_Click(object sender, EventArgs e)
        {
            if (Engine.form.Restart.Enabled == true)
            {
                Engine.DeletePauseImage();
                Engine.Player1RoundWon = 0;
                Engine.Player2RoundWon = 0;
                Engine.form.player1wins1.Image = Image.FromFile("../../../images/greencircle.png");
                Engine.form.player1wins2.Image = Image.FromFile("../../../images/greencircle.png");
                Engine.form.player2wins1.Image = Image.FromFile("../../../images/greencircle.png");
                Engine.form.player2wins1.Image = Image.FromFile("../../../images/greencircle.png");
                Engine.ResetGame();
                Engine.ResumeGame();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if(Engine.form.Exit.Enabled == true)
            Engine.form.Close();
        }
        private void atackanimation_Tick(object sender, EventArgs e)
        {
            Engine.player1.SetAtackAnimation();
            if (Engine.player1.playeratackingnum == Engine.form.player1atackanimation.Images.Count - 1)
            {
                atackanimationp1.Enabled = false;
                Engine.form.timerplayer1animations.Enabled = true;
            }
        }
        private void atackanimationp2_Tick(object sender, EventArgs e)
        {
            Engine.player2.SetAtackAnimation();
            if (Engine.player2.playeratackingnum == Engine.form.player2atackanimation.Images.Count - 1)
            {
                atackanimationp2.Enabled = false;
                Engine.form.timerplayer2animations.Enabled = true;
            }
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            Engine.CheckSong = true;
            Engine.TimeRemaining--;
            Engine.form.textcountdowner.Text = Engine.TimeRemaining.ToString();
            if (Engine.TimeRemaining == 0)
            {
                Engine.form.Close();
            }
        }
        private void p1damaged_Tick(object sender, EventArgs e)
        {
             Engine.player1.setGetHitted();
            if(Engine.player1.playerdamagedimgnum == Engine.form.player1damagedstances.Images.Count - 1)
            {
                p1damaged.Enabled = false;
               
                Engine.form.timerplayer1animations.Enabled = true;              
            }
        }
        private void p2damaged_Tick(object sender, EventArgs e)
        {
            Engine.player2.setGetHitted();
            if(Engine.player2.playeratackingnum == Engine.form.player2damagedstances.Images.Count-1)
            {
                p2damaged.Enabled = false;
                Engine.form.timerplayer2animations.Enabled = true;
            }
        }
    }
}