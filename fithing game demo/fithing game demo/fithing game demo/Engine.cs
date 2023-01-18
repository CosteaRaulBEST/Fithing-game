using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace fithing_game_demo
{
    public class Engine
    {
        public static Form1 form;
        public static Player1 player1;
        public static Player2 player2;
        public static int Player1RoundWon = 0;
        public static int Player2RoundWon = 0;
        public static int PauseTimerCount = 0;
        public static int StartCounterImageNumb = 0;
        public static Graphics graphics;
        public static Bitmap bitmap;
        public static int TimeRemaining = 91;
        public static SoundPlayer begin = new SoundPlayer();
        public static bool counterimages;
        public static bool CheckSong;
        public static void Init(Form1 f1)
        {
            form = f1;
            bitmap = new Bitmap(form.Width, form.Height);
            graphics = Graphics.FromImage(bitmap);
        }
        

        public static async void StartCounterImages()
        {
            counterimages = true;
            form.CounterImage.Image = form.StartCountList.Images[PauseTimerCount];
            if(PauseTimerCount == 0 )
            {
                begin.SoundLocation = ("../../../sounds/mergi3.wav");
                begin.Play();
            }
            else if ( PauseTimerCount == 1 )
            {
                begin.SoundLocation = ("../../../sounds/mergi2.wav");
                begin.Play();
            }
            else if (PauseTimerCount == 2)
            {
                begin.SoundLocation = ("../../../sounds/mergi1.wav");
                begin.Play();
            }
            else if  (PauseTimerCount == 3)
            {
                begin.SoundLocation = ("../../../sounds/mergifight.wav");
                begin.Play();
            }
            StartCounterImageNumb++;
            if (StartCounterImageNumb == form.StartCountList.Images.Count - 1)
            {
                StartCounterImageNumb = 0;
            }
            else
            {
                StartCounterImageNumb++;
                await Task.Delay(500);
            }
        }
        public static void ResetGame()
        {
            form.PauseTimer.Enabled = true;           
            form.player1HPbar.Value = 100;
            form.player2HPbar.Value = 100;
            player2 = new Player2();
            player1 = new Player1();
            TimeRemaining = 90;
        }
        public static void PauseGame()
        {
            form.timer1.Enabled = false;
            form.timerplayer1animations.Enabled = false;
            form.timerplayer2animations.Enabled = false;
            form.countdown.Enabled = false;
            form.isBlurred = true;
        }
        public static void ResumeGame()
        {
            form.timer1.Enabled = true;
            form.timerplayer1animations.Enabled = true;
            form.timerplayer2animations.Enabled = true;
            form.countdown.Enabled=true;
            form.isBlurred = false;
        }
        public static void DeletePauseImage()
        {
            form.PauseGameImage.Visible = false;
            form.Resume.Enabled = false;
            form.Exit.Enabled = false;
            form.Restart.Enabled = false;
            form.Resume.Visible = false;
            form.Exit.Visible = false;
            form.Restart.Visible = false;
            form.pauseImage.Visible = false;
        }
        public static void EndRound()
        {
            player1.CheckRoundWinner();
            player2.CheckRoundWinner();
        }
        public static void EndGame()
        {
            if (Player1RoundWon == 3)
            {
                form.Close();
            }
            else if (Player2RoundWon == 3)
            {
                form.Close();
            }
        }
        public static void CheckPLayerLocation()
        {
            if (player1.getLocation().X >= player2.getLocation().X)
            {
                player1.isRight = false;
                player2.isRight = true;
                player1.isLeft = true;
                player2.isLeft = false;

            }
            else if (player1.getLocation().X <= player2.getLocation().X)
            {
                player1.isRight = true;
                player2.isRight = false;
                player1.isLeft = false;
                player2.isLeft = true;
            }
        }
        public static void Paint()
        {
            Image image = form.background;
            if(form.isBlurred == true)
            {
                image = form.blurredBackground;
                form.Refresh();
            }
            graphics.DrawImage(image, 0, 0, form.Width, form.Height);
            graphics.DrawImage(player1.playerImage, player1.getLocation());
            graphics.DrawImage(player2.playerImage, player2.getLocation());
         
            form.BackgroundImage = bitmap;
        }
    }
}
