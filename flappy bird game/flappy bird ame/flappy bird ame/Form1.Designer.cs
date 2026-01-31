namespace flappy_bird_ame
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
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappybird
            // 
            this.flappybird.Image = global::flappy_bird_ame.Properties.Resources.bird;
            this.flappybird.Location = new System.Drawing.Point(51, 167);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(76, 61);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::flappy_bird_ame.Properties.Resources.pipe;
            this.pipebottom.Location = new System.Drawing.Point(297, 370);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(75, 192);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 1;
            this.pipebottom.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::flappy_bird_ame.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(434, -50);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(75, 213);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 2;
            this.pipetop.TabStop = false;
            this.pipetop.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ground
            // 
            this.ground.Image = global::flappy_bird_ame.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-10, 525);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(620, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(12, 9);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(121, 29);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score : 0";
            this.scoretext.Click += new System.EventHandler(this.label1_Click);
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(575, 562);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.flappybird);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer gametimer;
    }
}

