namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Zmienna środowiskowa
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">W celach optymalizacyjnych</param>
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
            this.player = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_missed = new System.Windows.Forms.Label();
            this.Punkty = new System.Windows.Forms.Label();
            this.Label_Score = new System.Windows.Forms.Label();
            this.CurrentLevel = new System.Windows.Forms.Label();
            this.NextLevelInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.player.Enabled = false;
            this.player.Location = new System.Drawing.Point(455, 688);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(122, 29);
            this.player.TabIndex = 0;
            this.player.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(204, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 30);
            this.label1.TabIndex = 4;
            this.label1.Tag = "Flaga";
            this.label1.Text = "  ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(489, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 30);
            this.label2.TabIndex = 5;
            this.label2.Tag = "Flaga";
            this.label2.Text = "  ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(732, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 30);
            this.label3.TabIndex = 6;
            this.label3.Tag = "Flaga";
            this.label3.Text = "  ";
            // 
            // Label_missed
            // 
            this.Label_missed.AutoSize = true;
            this.Label_missed.BackColor = System.Drawing.Color.Transparent;
            this.Label_missed.Location = new System.Drawing.Point(835, 54);
            this.Label_missed.Name = "Label_missed";
            this.Label_missed.Size = new System.Drawing.Size(95, 13);
            this.Label_missed.TabIndex = 7;
            this.Label_missed.Text = "Zebrane flagi z UE";
            // 
            // Punkty
            // 
            this.Punkty.AutoSize = true;
            this.Punkty.BackColor = System.Drawing.Color.Transparent;
            this.Punkty.Location = new System.Drawing.Point(30, 24);
            this.Punkty.Name = "Punkty";
            this.Punkty.Size = new System.Drawing.Size(46, 13);
            this.Punkty.TabIndex = 8;
            this.Punkty.Text = "Punkty: ";
            // 
            // Label_Score
            // 
            this.Label_Score.AutoSize = true;
            this.Label_Score.BackColor = System.Drawing.Color.Transparent;
            this.Label_Score.Location = new System.Drawing.Point(835, 24);
            this.Label_Score.Name = "Label_Score";
            this.Label_Score.Size = new System.Drawing.Size(118, 13);
            this.Label_Score.TabIndex = 9;
            this.Label_Score.Text = "Zebrane flagi spoza UE";
            // 
            // CurrentLevel
            // 
            this.CurrentLevel.AutoSize = true;
            this.CurrentLevel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentLevel.Location = new System.Drawing.Point(30, 54);
            this.CurrentLevel.Name = "CurrentLevel";
            this.CurrentLevel.Size = new System.Drawing.Size(53, 13);
            this.CurrentLevel.TabIndex = 10;
            this.CurrentLevel.Text = "Poziom: 1";
            // 
            // NextLevelInfo
            // 
            this.NextLevelInfo.AutoSize = true;
            this.NextLevelInfo.BackColor = System.Drawing.Color.Transparent;
            this.NextLevelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NextLevelInfo.Location = new System.Drawing.Point(378, 281);
            this.NextLevelInfo.Name = "NextLevelInfo";
            this.NextLevelInfo.Size = new System.Drawing.Size(299, 73);
            this.NextLevelInfo.TabIndex = 11;
            this.NextLevelInfo.Text = "Poziom 1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(390, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 30);
            this.label4.TabIndex = 12;
            this.label4.Tag = "Flaga";
            this.label4.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.CurrentLevel);
            this.Controls.Add(this.Label_missed);
            this.Controls.Add(this.Label_Score);
            this.Controls.Add(this.NextLevelInfo);
            this.Controls.Add(this.Punkty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spadające flagi";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Gracz
        /// </summary>
        private System.Windows.Forms.Button player;
        /// <summary>
        /// Objekt służący do wykonywania operacji pod wpływem stałych interwałów czasowych
        /// </summary>
        private System.Windows.Forms.Timer timer1;
        /// <summary>
        /// Losowa spadająca flaga
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// Losowa spadająca flaga
        /// </summary>
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// Losowa spadająca flaga
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// Liczba błędnych flag
        /// </summary>
        private System.Windows.Forms.Label Label_missed;
        /// <summary>
        /// Liczba zebranych punktów
        /// </summary>
        private System.Windows.Forms.Label Punkty;
        /// <summary>
        /// Liczba prawidłowych flag
        /// </summary>
        private System.Windows.Forms.Label Label_Score;
        private System.Windows.Forms.Label CurrentLevel;
        private System.Windows.Forms.Label NextLevelInfo;
        private System.Windows.Forms.Label label4;
    }
}

