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
    public abstract class Player
    {
        public int health = 100;
        public int damage = 5;
        public Image playerImage;
        public PictureBox AttackRectangle;
        public Point PlayerPosition;
        public int PlayerWidth;
        public int PlayerHeight;
        public int speed = 7;
        public bool isMovingLeft;
        public bool isMovingRight;
        public bool isBlocking;
        public bool isDead;
        public bool isMoving;
        public bool isLeft;
        public bool isRight;
        public bool isAttacking;
        public bool isHitted;
        public int playeridleimgnum;
        public int playermovingimgnum;
        public int playeratackingnum;
        public int playerdamagedimgnum;
        public SoundPlayer attacksound;
        public Player()
        {
            PlayerWidth = 250;
            PlayerHeight = 100;
            attacksound = new SoundPlayer();
            attacksound.SoundLocation = ("../../../sounds/attacksound.wav");
        }
        //setare la locatie si imagine
        public abstract void SetPictureBox();

        public void Move()
        {
            isMoving = false;
            if (isMovingLeft)
            {
                isMoving = true;
                PlayerPosition.X -= speed;
            }
            else if (isMovingRight)
            {
                PlayerPosition.X += speed;
                isMoving = true;
            }
        }
        public Point getLocation()
        {
            return PlayerPosition;
        }
        public void removeAttackBox()
        {
            AttackRectangle.Size = new Size(0, 0);
        }
        public abstract void setAttackStance();
        public abstract void setNormalStance();
        public abstract void setBlockStance();
        public abstract void setIdleAnimation();
        public abstract void PlayerHits();
        public abstract void setMovingAnimation();
        public abstract void setGetHitted();
        public abstract void FlipImage();
        public abstract void SetVictorystance();
        public abstract void CheckRoundWinner();
        public abstract void SetAtackAnimation();
           
    }
}