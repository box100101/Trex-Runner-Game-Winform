namespace T_rex_Runner_Game
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
            this.highestScore = new System.Windows.Forms.Label();
            this.Hi = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.upLevel = new System.Windows.Forms.Label();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.Panel();
            this.meteorite2 = new System.Windows.Forms.PictureBox();
            this.meteorite1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.banner = new System.Windows.Forms.PictureBox();
            this.btnReplay = new System.Windows.Forms.PictureBox();
            this.gameOver = new System.Windows.Forms.PictureBox();
            this.bird1 = new DevExpress.XtraEditors.PictureEdit();
            this.cactus2 = new System.Windows.Forms.PictureBox();
            this.dinosaur = new DevExpress.XtraEditors.PictureEdit();
            this.cactus1 = new System.Windows.Forms.PictureBox();
            this.cactus3 = new System.Windows.Forms.PictureBox();
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            this.ground1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meteorite2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorite1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinosaur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // highestScore
            // 
            this.highestScore.AutoSize = true;
            this.highestScore.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestScore.ForeColor = System.Drawing.Color.DarkGray;
            this.highestScore.Location = new System.Drawing.Point(691, 3);
            this.highestScore.Name = "highestScore";
            this.highestScore.Size = new System.Drawing.Size(71, 34);
            this.highestScore.TabIndex = 6;
            this.highestScore.Text = "00000";
            // 
            // Hi
            // 
            this.Hi.AutoSize = true;
            this.Hi.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hi.ForeColor = System.Drawing.Color.DarkGray;
            this.Hi.Location = new System.Drawing.Point(653, 3);
            this.Hi.Name = "Hi";
            this.Hi.Size = new System.Drawing.Size(32, 34);
            this.Hi.TabIndex = 8;
            this.Hi.Text = "HI";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.DimGray;
            this.score.Location = new System.Drawing.Point(768, 3);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(71, 34);
            this.score.TabIndex = 9;
            this.score.Text = "00000";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // upLevel
            // 
            this.upLevel.AutoSize = true;
            this.upLevel.BackColor = System.Drawing.Color.Transparent;
            this.upLevel.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLevel.ForeColor = System.Drawing.Color.DimGray;
            this.upLevel.Location = new System.Drawing.Point(801, 111);
            this.upLevel.Name = "upLevel";
            this.upLevel.Size = new System.Drawing.Size(98, 34);
            this.upLevel.TabIndex = 12;
            this.upLevel.Text = "Up Level!";
            this.upLevel.Visible = false;
            // 
            // cloud2
            // 
            this.cloud2.Image = global::T_rex_Runner_Game.Properties.Resources.clouds;
            this.cloud2.Location = new System.Drawing.Point(1090, 40);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(1090, 184);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cloud2.TabIndex = 11;
            this.cloud2.TabStop = false;
            // 
            // ground1
            // 
            this.ground1.BackColor = System.Drawing.Color.Transparent;
            this.ground1.BackgroundImage = global::T_rex_Runner_Game.Properties.Resources.ground;
            this.ground1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground1.Controls.Add(this.meteorite2);
            this.ground1.Controls.Add(this.meteorite1);
            this.ground1.Controls.Add(this.btnPlay);
            this.ground1.Controls.Add(this.banner);
            this.ground1.Controls.Add(this.btnReplay);
            this.ground1.Controls.Add(this.gameOver);
            this.ground1.Controls.Add(this.bird1);
            this.ground1.Controls.Add(this.cactus2);
            this.ground1.Controls.Add(this.dinosaur);
            this.ground1.Controls.Add(this.cactus1);
            this.ground1.Controls.Add(this.cactus3);
            this.ground1.Location = new System.Drawing.Point(0, 216);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(1090, 299);
            this.ground1.TabIndex = 10;
            // 
            // meteorite2
            // 
            this.meteorite2.Image = global::T_rex_Runner_Game.Properties.Resources.Removal_978;
            this.meteorite2.Location = new System.Drawing.Point(1300, 0);
            this.meteorite2.Name = "meteorite2";
            this.meteorite2.Size = new System.Drawing.Size(87, 88);
            this.meteorite2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meteorite2.TabIndex = 12;
            this.meteorite2.TabStop = false;
            this.meteorite2.Visible = false;
            // 
            // meteorite1
            // 
            this.meteorite1.Image = global::T_rex_Runner_Game.Properties.Resources.Removal_978;
            this.meteorite1.Location = new System.Drawing.Point(1200, 8);
            this.meteorite1.Name = "meteorite1";
            this.meteorite1.Size = new System.Drawing.Size(87, 93);
            this.meteorite1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meteorite1.TabIndex = 11;
            this.meteorite1.TabStop = false;
            this.meteorite1.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::T_rex_Runner_Game.Properties.Resources.icons8_play_40;
            this.btnPlay.Location = new System.Drawing.Point(531, 113);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(55, 55);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 10;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // banner
            // 
            this.banner.Image = global::T_rex_Runner_Game.Properties.Resources.Banner;
            this.banner.Location = new System.Drawing.Point(448, 42);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(224, 59);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banner.TabIndex = 9;
            this.banner.TabStop = false;
            // 
            // btnReplay
            // 
            this.btnReplay.Image = global::T_rex_Runner_Game.Properties.Resources.btn_replay;
            this.btnReplay.Location = new System.Drawing.Point(531, 113);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(55, 50);
            this.btnReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReplay.TabIndex = 8;
            this.btnReplay.TabStop = false;
            this.btnReplay.Visible = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // gameOver
            // 
            this.gameOver.Image = global::T_rex_Runner_Game.Properties.Resources.Removal_317;
            this.gameOver.Location = new System.Drawing.Point(399, 42);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(320, 30);
            this.gameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameOver.TabIndex = 7;
            this.gameOver.TabStop = false;
            this.gameOver.Visible = false;
            // 
            // bird1
            // 
            this.bird1.EditValue = global::T_rex_Runner_Game.Properties.Resources.bird_unscreen;
            this.bird1.Location = new System.Drawing.Point(1700, 30);
            this.bird1.Name = "bird1";
            this.bird1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bird1.Properties.Appearance.Options.UseBackColor = true;
            this.bird1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bird1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.bird1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.bird1.Size = new System.Drawing.Size(62, 48);
            this.bird1.TabIndex = 6;
            this.bird1.Visible = false;
            // 
            // cactus2
            // 
            this.cactus2.BackColor = System.Drawing.Color.Transparent;
            this.cactus2.Image = global::T_rex_Runner_Game.Properties.Resources.cactus_2;
            this.cactus2.Location = new System.Drawing.Point(1600, 190);
            this.cactus2.Name = "cactus2";
            this.cactus2.Size = new System.Drawing.Size(80, 88);
            this.cactus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cactus2.TabIndex = 5;
            this.cactus2.TabStop = false;
            // 
            // dinosaur
            // 
            this.dinosaur.EditValue = global::T_rex_Runner_Game.Properties.Resources.Dinosaur_unscreen;
            this.dinosaur.Location = new System.Drawing.Point(45, 195);
            this.dinosaur.Name = "dinosaur";
            this.dinosaur.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.dinosaur.Properties.Appearance.Options.UseBackColor = true;
            this.dinosaur.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dinosaur.Properties.Padding = new System.Windows.Forms.Padding(-10);
            this.dinosaur.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.dinosaur.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.dinosaur.Size = new System.Drawing.Size(63, 75);
            this.dinosaur.TabIndex = 2;
            // 
            // cactus1
            // 
            this.cactus1.BackColor = System.Drawing.Color.Transparent;
            this.cactus1.Image = global::T_rex_Runner_Game.Properties.Resources.cactus_1;
            this.cactus1.Location = new System.Drawing.Point(1100, 177);
            this.cactus1.Name = "cactus1";
            this.cactus1.Size = new System.Drawing.Size(43, 93);
            this.cactus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cactus1.TabIndex = 3;
            this.cactus1.TabStop = false;
            // 
            // cactus3
            // 
            this.cactus3.BackColor = System.Drawing.Color.Transparent;
            this.cactus3.Image = global::T_rex_Runner_Game.Properties.Resources.cactus_3;
            this.cactus3.Location = new System.Drawing.Point(2100, 190);
            this.cactus3.Name = "cactus3";
            this.cactus3.Size = new System.Drawing.Size(80, 89);
            this.cactus3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cactus3.TabIndex = 4;
            this.cactus3.TabStop = false;
            // 
            // cloud1
            // 
            this.cloud1.BackColor = System.Drawing.Color.Transparent;
            this.cloud1.Image = global::T_rex_Runner_Game.Properties.Resources.clouds;
            this.cloud1.Location = new System.Drawing.Point(0, 40);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(1090, 184);
            this.cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cloud1.TabIndex = 1;
            this.cloud1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 526);
            this.Controls.Add(this.upLevel);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Hi);
            this.Controls.Add(this.highestScore);
            this.Controls.Add(this.cloud1);
            this.IconOptions.Image = global::T_rex_Runner_Game.Properties.Resources.Dinosaur;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "T-rex Runner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            this.ground1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meteorite2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorite1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinosaur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox cloud1;
        private DevExpress.XtraEditors.PictureEdit dinosaur;
        private System.Windows.Forms.PictureBox cactus1;
        private System.Windows.Forms.PictureBox cactus3;
        private System.Windows.Forms.PictureBox cactus2;
        private System.Windows.Forms.Label highestScore;
        private System.Windows.Forms.Label Hi;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel ground1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox cloud2;
        private DevExpress.XtraEditors.PictureEdit bird1;
        private System.Windows.Forms.PictureBox gameOver;
        private System.Windows.Forms.PictureBox btnReplay;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.Label upLevel;
        private System.Windows.Forms.PictureBox meteorite1;
        private System.Windows.Forms.PictureBox meteorite2;
    }
}

