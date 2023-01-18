using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fithing_game_demo
{
    public class Player2 : Player
    {
        public Player2() : base()
        {
            SetPictureBox();
        }
        public override void SetPictureBox()
        {
            PlayerPosition = new Point(Engine.form.Width / 2, (int)(Engine.form.Height * 2.3 / 4));
            playerImage = Image.FromFile("../../../images/player2normalstance.png");
        }
        public override void setAttackStance()
        {
            AttackRectangle = new PictureBox();
            AttackRectangle.Parent = Engine.form;
            AttackRectangle.Visible = false ;
            AttackRectangle.Size = new Size(100, 20);
            AttackRectangle.Location = new Point(getLocation().X - 20, getLocation().Y + 20);
            if (Engine.player2.isRight == true)
            {
                AttackRectangle.Location = new Point(getLocation().X - 20, getLocation().Y +20);
            }          
        }
        public override void setNormalStance()
        {
           playerImage = Image.FromFile("../../../images/player2normalstance.png");
           Engine.player2.FlipImage();
        }
        public override void setBlockStance()
        {
            playerImage = Image.FromFile("../../../images/player2blockstance.png");
            Engine.player2.FlipImage();
        }
        public override void PlayerHits()
        {
            if ((Engine.player1.isBlocking == false) && (Engine.player2.AttackRectangle.Bounds.IntersectsWith(new Rectangle(Engine.player1.PlayerPosition, new Size(PlayerWidth, PlayerHeight)))))
            {
                Engine.player1.playerdamagedimgnum = 0;
                Engine.player1.isHitted = true; 
                Engine.player1.health -= Engine.player2.damage;
                Engine.form.player1HPbar.Value -= Engine.player2.damage;
                Engine.player1.setGetHitted();
                if (Engine.player1.health <= 0)
                {
                    Engine.player1.isDead = true;
                }
            }
        }
        public override void setIdleAnimation()
        {
            if (Engine.player2.isBlocking == false)
            {
                Engine.player2.playerImage = Engine.form.player2stances.Images[playeridleimgnum];
                Engine.player2.FlipImage();
                if (playeridleimgnum == Engine.form.player2stances.Images.Count - 1)
                {
                    Engine.player2.playeridleimgnum = 0;
                }
                else
                {
                    Engine.player2.playeridleimgnum++;
                }
            }
        }
        public override void setMovingAnimation()
        {
            if (Engine.player2.isMoving == true)
            {
                Engine.player2.playerImage = Engine.form.player2movinglist.Images[playeridleimgnum];
                Engine.player2.FlipImage();
                if (playermovingimgnum == Engine.form.player2movinglist.Images.Count - 1)
                {
                    Engine.player2.playermovingimgnum = 0;
                }
                else
                {
                    Engine.player2.playermovingimgnum++;
                }
            }
        }
        public override void setGetHitted()
        {
            Engine.form.timerplayer2animations.Enabled = false;
            Engine.player2.playerImage = Engine.form.player2damagedstances.Images[Engine.player2.playerdamagedimgnum];
            Engine.player2.FlipImage();
            if (playerdamagedimgnum == Engine.form.player2damagedstances.Images.Count - 1)
            {
                playerdamagedimgnum = 0;
                Engine.form.p2damaged.Enabled = false;
                Engine.form.timerplayer2animations.Enabled = true;
            }
            else
            {
                playerdamagedimgnum++;
            }
        }
        public override void FlipImage()
        {
            if (Engine.player2.isLeft == true)
            {
                Engine.player2.playerImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
        }
        public override void SetVictorystance()
        {
            playerImage = Image.FromFile("../../../images/player2victorystance.png");

        }
        public override void CheckRoundWinner()
        {
            if (Engine.player1.health <= 0)
            {
                Engine.Player2RoundWon++;
                if (Engine.Player2RoundWon == 1)
                {
                    Engine.form.player2wins1.Image = Image.FromFile("../../../images/redcircle.png");

                }
                if (Engine.Player2RoundWon == 2)
                {
                    Engine.form.player2wins2.Image = Image.FromFile("../../../images/redcircle.png");

                }
                Engine.ResetGame();
            }
        }
        public override void SetAtackAnimation()
        {
            Engine.form.timerplayer2animations.Enabled = false;
            Engine.player2.playerImage = Engine.form.player2atackanimation.Images[Engine.player2.playeratackingnum];
            Engine.player2.FlipImage();
            if (playeratackingnum == Engine.form.player2atackanimation.Images.Count - 1)
            {
                playeratackingnum = 0;
                Engine.form.timerplayer2animations.Enabled = true;
            }
            else
            {
                playeratackingnum++;
            }
        }
    }
}
