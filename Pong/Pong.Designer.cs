namespace Pong
{
    partial class Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.score_p1_label = new System.Windows.Forms.Label();
            this.score_p2_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.player1.Image = ((System.Drawing.Image)(resources.GetObject("player1.Image")));
            this.player1.Location = new System.Drawing.Point(12, 163);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(10, 90);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.player2.Image = ((System.Drawing.Image)(resources.GetObject("player2.Image")));
            this.player2.Location = new System.Drawing.Point(778, 163);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(10, 90);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.InitialImage = null;
            this.ball.Location = new System.Drawing.Point(368, 200);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // score_p1_label
            // 
            this.score_p1_label.AutoSize = true;
            this.score_p1_label.BackColor = System.Drawing.Color.Transparent;
            this.score_p1_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_p1_label.ForeColor = System.Drawing.Color.White;
            this.score_p1_label.Location = new System.Drawing.Point(195, 48);
            this.score_p1_label.Name = "score_p1_label";
            this.score_p1_label.Size = new System.Drawing.Size(22, 24);
            this.score_p1_label.TabIndex = 3;
            this.score_p1_label.Text = "0";
            this.score_p1_label.Click += new System.EventHandler(this.score_p1_Click);
            // 
            // score_p2_label
            // 
            this.score_p2_label.AutoSize = true;
            this.score_p2_label.BackColor = System.Drawing.Color.Transparent;
            this.score_p2_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_p2_label.ForeColor = System.Drawing.Color.White;
            this.score_p2_label.Location = new System.Drawing.Point(566, 48);
            this.score_p2_label.Name = "score_p2_label";
            this.score_p2_label.Size = new System.Drawing.Size(22, 24);
            this.score_p2_label.TabIndex = 4;
            this.score_p2_label.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.score_p2_label);
            this.Controls.Add(this.score_p1_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pong";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label score_p1_label;
        private System.Windows.Forms.Label score_p2_label;
        private System.Windows.Forms.Timer timer1;
    }
}

