namespace fithing_game_demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerplayer1animations = new System.Windows.Forms.Timer(this.components);
            this.player1stances = new System.Windows.Forms.ImageList(this.components);
            this.player2stances = new System.Windows.Forms.ImageList(this.components);
            this.player1HPbar = new System.Windows.Forms.ProgressBar();
            this.player2HPbar = new System.Windows.Forms.ProgressBar();
            this.player1movinglist = new System.Windows.Forms.ImageList(this.components);
            this.player2movinglist = new System.Windows.Forms.ImageList(this.components);
            this.MenuScreen = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PauseTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckThings = new System.Windows.Forms.Timer(this.components);
            this.StartCountList = new System.Windows.Forms.ImageList(this.components);
            this.CounterImage = new System.Windows.Forms.PictureBox();
            this.player2wins2 = new System.Windows.Forms.PictureBox();
            this.player2wins1 = new System.Windows.Forms.PictureBox();
            this.player1wins1 = new System.Windows.Forms.PictureBox();
            this.player1wins2 = new System.Windows.Forms.PictureBox();
            this.PauseGameImage = new System.Windows.Forms.PictureBox();
            this.Resume = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.player1atackanimation = new System.Windows.Forms.ImageList(this.components);
            this.player2atackanimation = new System.Windows.Forms.ImageList(this.components);
            this.atackanimationp1 = new System.Windows.Forms.Timer(this.components);
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.textcountdowner = new System.Windows.Forms.TextBox();
            this.atackanimationp2 = new System.Windows.Forms.Timer(this.components);
            this.timerplayer2animations = new System.Windows.Forms.Timer(this.components);
            this.player1damagedstances = new System.Windows.Forms.ImageList(this.components);
            this.p1damaged = new System.Windows.Forms.Timer(this.components);
            this.player2damagedstances = new System.Windows.Forms.ImageList(this.components);
            this.p2damaged = new System.Windows.Forms.Timer(this.components);
            this.player1poze = new System.Windows.Forms.PictureBox();
            this.player2poze = new System.Windows.Forms.PictureBox();
            this.player1name = new System.Windows.Forms.PictureBox();
            this.player2name = new System.Windows.Forms.PictureBox();
            this.pauseImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MenuScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2wins2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2wins1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1wins1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1wins2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseGameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1poze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2poze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerplayer1animations
            // 
            this.timerplayer1animations.Interval = 250;
            this.timerplayer1animations.Tick += new System.EventHandler(this.timerplayer1animations_Tick);
            // 
            // player1stances
            // 
            this.player1stances.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player1stances.ImageStream")));
            this.player1stances.TransparentColor = System.Drawing.Color.Transparent;
            this.player1stances.Images.SetKeyName(0, "player1idlestance1.png");
            this.player1stances.Images.SetKeyName(1, "player1idlestance2.png");
            this.player1stances.Images.SetKeyName(2, "player1idlestance3.png");
            this.player1stances.Images.SetKeyName(3, "player1idlestance4.png");
            // 
            // player2stances
            // 
            this.player2stances.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player2stances.ImageStream")));
            this.player2stances.TransparentColor = System.Drawing.Color.Transparent;
            this.player2stances.Images.SetKeyName(0, "player2idlestance1.png");
            this.player2stances.Images.SetKeyName(1, "player2idlestance2.png");
            this.player2stances.Images.SetKeyName(2, "player2idlestance3.png");
            this.player2stances.Images.SetKeyName(3, "player2idlestance4.png");
            // 
            // player1HPbar
            // 
            this.player1HPbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1HPbar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.player1HPbar.ForeColor = System.Drawing.Color.Red;
            this.player1HPbar.Location = new System.Drawing.Point(-127, -225);
            this.player1HPbar.MarqueeAnimationSpeed = 20;
            this.player1HPbar.Name = "player1HPbar";
            this.player1HPbar.Size = new System.Drawing.Size(575, 23);
            this.player1HPbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.player1HPbar.TabIndex = 0;
            this.player1HPbar.Value = 100;
            // 
            // player2HPbar
            // 
            this.player2HPbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player2HPbar.Location = new System.Drawing.Point(778, -225);
            this.player2HPbar.MarqueeAnimationSpeed = 20;
            this.player2HPbar.Name = "player2HPbar";
            this.player2HPbar.Size = new System.Drawing.Size(575, 23);
            this.player2HPbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.player2HPbar.TabIndex = 1;
            this.player2HPbar.Value = 100;
            // 
            // player1movinglist
            // 
            this.player1movinglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player1movinglist.ImageStream")));
            this.player1movinglist.TransparentColor = System.Drawing.Color.Transparent;
            this.player1movinglist.Images.SetKeyName(0, "player1movingstance1.png");
            this.player1movinglist.Images.SetKeyName(1, "player1movingstance2.png");
            this.player1movinglist.Images.SetKeyName(2, "player1movingstance3.png");
            this.player1movinglist.Images.SetKeyName(3, "player1movingstance4.png");
            this.player1movinglist.Images.SetKeyName(4, "player1movingstance5.png");
            // 
            // player2movinglist
            // 
            this.player2movinglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player2movinglist.ImageStream")));
            this.player2movinglist.TransparentColor = System.Drawing.Color.Transparent;
            this.player2movinglist.Images.SetKeyName(0, "player2movingstance1.png");
            this.player2movinglist.Images.SetKeyName(1, "player2movingstance2.png");
            this.player2movinglist.Images.SetKeyName(2, "player2movingstance3.png");
            this.player2movinglist.Images.SetKeyName(3, "player2movingstance4.png");
            this.player2movinglist.Images.SetKeyName(4, "player2movingstance5.png");
            // 
            // MenuScreen
            // 
            this.MenuScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuScreen.Image = ((System.Drawing.Image)(resources.GetObject("MenuScreen.Image")));
            this.MenuScreen.Location = new System.Drawing.Point(0, 0);
            this.MenuScreen.Name = "MenuScreen";
            this.MenuScreen.Size = new System.Drawing.Size(1210, 464);
            this.MenuScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuScreen.TabIndex = 2;
            this.MenuScreen.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Peru;
            this.StartButton.CausesValidation = false;
            this.StartButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.DarkRed;
            this.StartButton.Location = new System.Drawing.Point(1000, 400);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(247, 50);
            this.StartButton.TabIndex = 3;
            this.StartButton.TabStop = false;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ExitButton.BackColor = System.Drawing.Color.Peru;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitButton.Location = new System.Drawing.Point(1000, 500);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(247, 50);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PauseTimer
            // 
            this.PauseTimer.Interval = 1000;
            this.PauseTimer.Tick += new System.EventHandler(this.PauseTimer_Tick);
            // 
            // CheckThings
            // 
            this.CheckThings.Enabled = true;
            this.CheckThings.Interval = 1;
            this.CheckThings.Tick += new System.EventHandler(this.CheckThings_Tick);
            // 
            // StartCountList
            // 
            this.StartCountList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("StartCountList.ImageStream")));
            this.StartCountList.TransparentColor = System.Drawing.Color.Transparent;
            this.StartCountList.Images.SetKeyName(0, "number3.png");
            this.StartCountList.Images.SetKeyName(1, "number2.png");
            this.StartCountList.Images.SetKeyName(2, "number1.png");
            this.StartCountList.Images.SetKeyName(3, "fight.png");
            this.StartCountList.Images.SetKeyName(4, "emptyimage.png");
            // 
            // CounterImage
            // 
            this.CounterImage.BackColor = System.Drawing.Color.Transparent;
            this.CounterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CounterImage.Location = new System.Drawing.Point(870, 100);
            this.CounterImage.Name = "CounterImage";
            this.CounterImage.Size = new System.Drawing.Size(350, 350);
            this.CounterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CounterImage.TabIndex = 5;
            this.CounterImage.TabStop = false;
            this.CounterImage.Visible = false;
            // 
            // player2wins2
            // 
            this.player2wins2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player2wins2.BackColor = System.Drawing.Color.Transparent;
            this.player2wins2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2wins2.Image = ((System.Drawing.Image)(resources.GetObject("player2wins2.Image")));
            this.player2wins2.Location = new System.Drawing.Point(1138, -200);
            this.player2wins2.Name = "player2wins2";
            this.player2wins2.Size = new System.Drawing.Size(100, 50);
            this.player2wins2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2wins2.TabIndex = 6;
            this.player2wins2.TabStop = false;
            this.player2wins2.Visible = false;
            // 
            // player2wins1
            // 
            this.player2wins1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player2wins1.BackColor = System.Drawing.Color.Transparent;
            this.player2wins1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2wins1.Image = ((System.Drawing.Image)(resources.GetObject("player2wins1.Image")));
            this.player2wins1.Location = new System.Drawing.Point(1248, -200);
            this.player2wins1.Name = "player2wins1";
            this.player2wins1.Size = new System.Drawing.Size(100, 50);
            this.player2wins1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2wins1.TabIndex = 7;
            this.player2wins1.TabStop = false;
            this.player2wins1.Visible = false;
            // 
            // player1wins1
            // 
            this.player1wins1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1wins1.BackColor = System.Drawing.Color.Transparent;
            this.player1wins1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player1wins1.Image = ((System.Drawing.Image)(resources.GetObject("player1wins1.Image")));
            this.player1wins1.InitialImage = null;
            this.player1wins1.Location = new System.Drawing.Point(-132, -200);
            this.player1wins1.Name = "player1wins1";
            this.player1wins1.Size = new System.Drawing.Size(100, 50);
            this.player1wins1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1wins1.TabIndex = 9;
            this.player1wins1.TabStop = false;
            this.player1wins1.Visible = false;
            // 
            // player1wins2
            // 
            this.player1wins2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1wins2.BackColor = System.Drawing.Color.Transparent;
            this.player1wins2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player1wins2.Image = ((System.Drawing.Image)(resources.GetObject("player1wins2.Image")));
            this.player1wins2.InitialImage = null;
            this.player1wins2.Location = new System.Drawing.Point(-22, -200);
            this.player1wins2.Name = "player1wins2";
            this.player1wins2.Size = new System.Drawing.Size(100, 50);
            this.player1wins2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1wins2.TabIndex = 10;
            this.player1wins2.TabStop = false;
            this.player1wins2.Visible = false;
            // 
            // PauseGameImage
            // 
            this.PauseGameImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PauseGameImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PauseGameImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PauseGameImage.Location = new System.Drawing.Point(486, 84);
            this.PauseGameImage.Name = "PauseGameImage";
            this.PauseGameImage.Size = new System.Drawing.Size(259, 252);
            this.PauseGameImage.TabIndex = 11;
            this.PauseGameImage.TabStop = false;
            this.PauseGameImage.Visible = false;
            // 
            // Resume
            // 
            this.Resume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resume.BackColor = System.Drawing.Color.MistyRose;
            this.Resume.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resume.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resume.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Resume.Location = new System.Drawing.Point(563, 100);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(108, 48);
            this.Resume.TabIndex = 12;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = false;
            this.Resume.Visible = false;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Restart
            // 
            this.Restart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Restart.BackColor = System.Drawing.Color.MistyRose;
            this.Restart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Restart.Location = new System.Drawing.Point(563, 178);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(108, 48);
            this.Restart.TabIndex = 13;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.BackColor = System.Drawing.Color.MistyRose;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Exit.Location = new System.Drawing.Point(563, 258);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 48);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // player1atackanimation
            // 
            this.player1atackanimation.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player1atackanimation.ImageStream")));
            this.player1atackanimation.TransparentColor = System.Drawing.Color.Transparent;
            this.player1atackanimation.Images.SetKeyName(0, "player1attackstance1.png");
            this.player1atackanimation.Images.SetKeyName(1, "player1attackstance2.png");
            this.player1atackanimation.Images.SetKeyName(2, "player1attackstance3.png");
            this.player1atackanimation.Images.SetKeyName(3, "player1attackstance4.png");
            this.player1atackanimation.Images.SetKeyName(4, "player1attackstance5.png");
            this.player1atackanimation.Images.SetKeyName(5, "player1attackstance1.png");
            // 
            // player2atackanimation
            // 
            this.player2atackanimation.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player2atackanimation.ImageStream")));
            this.player2atackanimation.TransparentColor = System.Drawing.Color.Transparent;
            this.player2atackanimation.Images.SetKeyName(0, "player2attackstance1.png");
            this.player2atackanimation.Images.SetKeyName(1, "player2attackstance2.png");
            this.player2atackanimation.Images.SetKeyName(2, "player2attackstance3.png");
            this.player2atackanimation.Images.SetKeyName(3, "player2attackstance4.png");
            this.player2atackanimation.Images.SetKeyName(4, "player2attackstance5.png");
            // 
            // atackanimationp1
            // 
            this.atackanimationp1.Interval = 150;
            this.atackanimationp1.Tick += new System.EventHandler(this.atackanimation_Tick);
            // 
            // countdown
            // 
            this.countdown.Interval = 1000;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // textcountdowner
            // 
            this.textcountdowner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textcountdowner.BackColor = System.Drawing.Color.Yellow;
            this.textcountdowner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textcountdowner.Enabled = false;
            this.textcountdowner.Font = new System.Drawing.Font("Impact", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcountdowner.ForeColor = System.Drawing.Color.Black;
            this.textcountdowner.Location = new System.Drawing.Point(562, -250);
            this.textcountdowner.Name = "textcountdowner";
            this.textcountdowner.Size = new System.Drawing.Size(125, 33);
            this.textcountdowner.TabIndex = 15;
            this.textcountdowner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textcountdowner.Visible = false;
            // 
            // atackanimationp2
            // 
            this.atackanimationp2.Interval = 150;
            this.atackanimationp2.Tick += new System.EventHandler(this.atackanimationp2_Tick);
            // 
            // timerplayer2animations
            // 
            this.timerplayer2animations.Interval = 250;
            this.timerplayer2animations.Tick += new System.EventHandler(this.timerplayer2animations_Tick_1);
            // 
            // player1damagedstances
            // 
            this.player1damagedstances.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player1damagedstances.ImageStream")));
            this.player1damagedstances.TransparentColor = System.Drawing.Color.Transparent;
            this.player1damagedstances.Images.SetKeyName(0, "player1damagedstance1.png");
            this.player1damagedstances.Images.SetKeyName(1, "player1damagedstance2.png");
            this.player1damagedstances.Images.SetKeyName(2, "player1damagedstance3.png");
            this.player1damagedstances.Images.SetKeyName(3, "player1damagedstance4.png");
            // 
            // p1damaged
            // 
            this.p1damaged.Interval = 130;
            this.p1damaged.Tick += new System.EventHandler(this.p1damaged_Tick);
            // 
            // player2damagedstances
            // 
            this.player2damagedstances.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player2damagedstances.ImageStream")));
            this.player2damagedstances.TransparentColor = System.Drawing.Color.Transparent;
            this.player2damagedstances.Images.SetKeyName(0, "player2damagedsstance1.png");
            this.player2damagedstances.Images.SetKeyName(1, "player2damagedstance2.png");
            this.player2damagedstances.Images.SetKeyName(2, "player2damagedstance3.png");
            this.player2damagedstances.Images.SetKeyName(3, "player2damagedstance4.png");
            // 
            // p2damaged
            // 
            this.p2damaged.Interval = 130;
            this.p2damaged.Tick += new System.EventHandler(this.p2damaged_Tick);
            // 
            // player1poze
            // 
            this.player1poze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1poze.BackColor = System.Drawing.Color.Transparent;
            this.player1poze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player1poze.BackgroundImage")));
            this.player1poze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1poze.Location = new System.Drawing.Point(-327, -275);
            this.player1poze.Name = "player1poze";
            this.player1poze.Size = new System.Drawing.Size(200, 160);
            this.player1poze.TabIndex = 16;
            this.player1poze.TabStop = false;
            this.player1poze.Visible = false;
            // 
            // player2poze
            // 
            this.player2poze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player2poze.BackColor = System.Drawing.Color.Transparent;
            this.player2poze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player2poze.BackgroundImage")));
            this.player2poze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2poze.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.player2poze.Location = new System.Drawing.Point(1378, -275);
            this.player2poze.Name = "player2poze";
            this.player2poze.Size = new System.Drawing.Size(200, 160);
            this.player2poze.TabIndex = 17;
            this.player2poze.TabStop = false;
            this.player2poze.Visible = false;
            // 
            // player1name
            // 
            this.player1name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1name.BackColor = System.Drawing.Color.Transparent;
            this.player1name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player1name.BackgroundImage")));
            this.player1name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1name.Location = new System.Drawing.Point(-145, -285);
            this.player1name.Name = "player1name";
            this.player1name.Size = new System.Drawing.Size(226, 56);
            this.player1name.TabIndex = 18;
            this.player1name.TabStop = false;
            this.player1name.Visible = false;
            // 
            // player2name
            // 
            this.player2name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player2name.BackColor = System.Drawing.Color.Transparent;
            this.player2name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player2name.BackgroundImage")));
            this.player2name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2name.Location = new System.Drawing.Point(1130, -285);
            this.player2name.Name = "player2name";
            this.player2name.Size = new System.Drawing.Size(226, 56);
            this.player2name.TabIndex = 19;
            this.player2name.TabStop = false;
            this.player2name.Visible = false;
            // 
            // pauseImage
            // 
            this.pauseImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pauseImage.BackColor = System.Drawing.Color.Transparent;
            this.pauseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pauseImage.Image = ((System.Drawing.Image)(resources.GetObject("pauseImage.Image")));
            this.pauseImage.Location = new System.Drawing.Point(320, -190);
            this.pauseImage.Name = "pauseImage";
            this.pauseImage.Size = new System.Drawing.Size(591, 268);
            this.pauseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pauseImage.TabIndex = 20;
            this.pauseImage.TabStop = false;
            this.pauseImage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1210, 464);
            this.Controls.Add(this.pauseImage);
            this.Controls.Add(this.player2name);
            this.Controls.Add(this.player1name);
            this.Controls.Add(this.player2poze);
            this.Controls.Add(this.player1poze);
            this.Controls.Add(this.textcountdowner);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.PauseGameImage);
            this.Controls.Add(this.player1wins2);
            this.Controls.Add(this.player1wins1);
            this.Controls.Add(this.player2wins1);
            this.Controls.Add(this.player2wins2);
            this.Controls.Add(this.CounterImage);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MenuScreen);
            this.Controls.Add(this.player2HPbar);
            this.Controls.Add(this.player1HPbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExitGame);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.MenuScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2wins2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2wins1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1wins1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1wins2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseGameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1poze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2poze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timerplayer1animations;
        public System.Windows.Forms.ImageList player1stances;
        public System.Windows.Forms.ImageList player2stances;
        public System.Windows.Forms.ProgressBar player1HPbar;
        public System.Windows.Forms.ProgressBar player2HPbar;
        public System.Windows.Forms.ImageList player1movinglist;
        public System.Windows.Forms.ImageList player2movinglist;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox MenuScreen;
        public System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.Timer PauseTimer;
        public System.Windows.Forms.Timer CheckThings;
        public System.Windows.Forms.ImageList StartCountList;
        public System.Windows.Forms.PictureBox CounterImage;
        public System.Windows.Forms.PictureBox player2wins2;
        public System.Windows.Forms.PictureBox player2wins1;
        public System.Windows.Forms.PictureBox player1wins1;
        public System.Windows.Forms.PictureBox player1wins2;
        public System.Windows.Forms.Button Resume;
        public System.Windows.Forms.Button Restart;
        public System.Windows.Forms.Button Exit;
        public System.Windows.Forms.PictureBox PauseGameImage;
        public System.Windows.Forms.ImageList player1atackanimation;
        public System.Windows.Forms.ImageList player2atackanimation;
        public System.Windows.Forms.Timer atackanimationp1;
        public System.Windows.Forms.Timer countdown;
        public System.Windows.Forms.TextBox textcountdowner;
        public System.Windows.Forms.Timer atackanimationp2;
        public System.Windows.Forms.Timer timerplayer2animations;
        public System.Windows.Forms.ImageList player1damagedstances;
        public System.Windows.Forms.Timer p1damaged;
        public System.Windows.Forms.ImageList player2damagedstances;
        public System.Windows.Forms.Timer p2damaged;
        private System.Windows.Forms.PictureBox player1poze;
        private System.Windows.Forms.PictureBox player2poze;
        private System.Windows.Forms.PictureBox player1name;
        private System.Windows.Forms.PictureBox player2name;
        public System.Windows.Forms.PictureBox pauseImage;
    }
}

