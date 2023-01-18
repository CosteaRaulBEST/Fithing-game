using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fithing_game_demo
{
    public class Player1 : Player
    {
        public Player1() : base()
        {
            SetPictureBox();
        }
        
        public override void SetPictureBox()
        {
            PlayerPosition = new Point(Engine.form.Width / 7, (int)(Engine.form.Height * 2.3 / 4));
            playerImage = Image.FromFile("../../../images/player1normalstance.png");
        }
        public override void setAttackStance()
        {
            AttackRectangle = new PictureBox();
            AttackRectangle.Parent = Engine.form;
            AttackRectangle.Visible = false;
            AttackRectangle.Size = new Size(100, 20);
            AttackRectangle.Location = new Point(getLocation().X + 20, getLocation().Y +20);       
            Engine.player1.FlipImage();
            if (Engine.player1.isLeft == true)
            {
                playerImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                AttackRectangle.Location = new Point(getLocation().X - 250, getLocation().Y + 20);
            }       
        }
        public override void setNormalStance()
        {
            playerImage = Image.FromFile("../../../images/player1normalstance.png");
            Engine.player1.FlipImage();
        }
        public override void setBlockStance()
        {
            playerImage = Image.FromFile("../../../images/player1blockstance.png");
            Engine.player1.FlipImage();
        }
        public override void PlayerHits()
        {
            if ((Engine.player2.isBlocking == false) && (Engine.player1.AttackRectangle.Bounds.IntersectsWith(new Rectangle(Engine.player2.PlayerPosition , new Size(PlayerWidth , PlayerHeight)))))
            {
                Engine.player2.playeratackingnum = 0;
                Engine.player2.isHitted = true;
                Engine.form.player2HPbar.Value -= Engine.player1.damage;
                Engine.player2.health -= Engine.player1.damage;
                Engine.player2.setGetHitted();
                if (Engine.player2.health <= 0)
                {
                    Engine.player2.isDead = true;
                }
            }
        }
        public override void setIdleAnimation()
        {
            if (Engine.player1.isBlocking == false)
            {
                Engine.player1.playerImage = Engine.form.player1stances.Images[playeridleimgnum];
                Engine.player1.FlipImage();
                if (playeridleimgnum == Engine.form.player1stances.Images.Count - 1)
                {
                    Engine.player1.playeridleimgnum = 0;
                }
                else
                {
                    Engine.player1.playeridleimgnum++;
                }
            }
        }
        public override void setMovingAnimation()
        {
            if (Engine.player1.isMoving == true)
            {
                Engine.player1.playerImage = Engine.form.player1movinglist.Images[playeridleimgnum];
                Engine.player1.FlipImage();
                if (playermovingimgnum == Engine.form.player1movinglist.Images.Count - 1)
                {
                    playermovingimgnum = 0;
                }
                else
                {
                    playermovingimgnum++;
                }
            }
        }
        public override void setGetHitted()
        {
            Engine.form.timerplayer1animations.Enabled = false;
            Engine.player1.playerImage = Engine.form.player1damagedstances.Images[Engine.player1.playerdamagedimgnum];
            Engine.player1.FlipImage();
            if (playerdamagedimgnum == Engine.form.player1atackanimation.Images.Count - 1)
            {
                playerdamagedimgnum = 0;
                Engine.form.p1damaged.Enabled = false;
            }
            else
            {
                playerdamagedimgnum++;
            }
        }
        public override void FlipImage()
        {
            if (Engine.player1.isLeft == true)
            {
                playerImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }         
        }
        public override void SetVictorystance()
        {
            playerImage = Image.FromFile("../../../images/player1victorystance.png");          
        }
        public override void CheckRoundWinner()
        {
            if (Engine.player2.health <= 0)
            {
                Engine.Player1RoundWon++;
                if (Engine.Player1RoundWon == 1)
                {
                    Engine.form.player1wins1.Image = Image.FromFile("../../../images/redcircle.png");
                }
                if (Engine.Player1RoundWon == 2)
                {
                    Engine.form.player1wins2.Image = Image.FromFile("../../../images/redcircle.png");
                }
                Engine.ResetGame();
            }
        }
        public override void SetAtackAnimation()
        {
                Engine.form.timerplayer1animations.Enabled = false;
                Engine.player1.playerImage = Engine.form.player1atackanimation.Images[Engine.player1.playeratackingnum];
                Engine.player1.FlipImage();
                if (playeratackingnum == Engine.form.player1atackanimation.Images.Count -1)
                {
                    playeratackingnum = 0;
                    Engine.form.timerplayer1animations.Enabled = true;
                    
                   
                }
                else
                {
                    playeratackingnum++; 
                }
            }
        }
 }
