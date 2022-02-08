namespace WindowsFormsApp2
{
    partial class Hi_score
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hi_score));
            this.pkt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pkt
            // 
            this.pkt.AutoSize = true;
            this.pkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pkt.Location = new System.Drawing.Point(234, 352);
            this.pkt.Name = "pkt";
            this.pkt.Size = new System.Drawing.Size(132, 24);
            this.pkt.TabIndex = 1;
            this.pkt.Text = "Twoje punkty: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 73);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spadające flagi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 81);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gram jeszcze raz!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(234, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Złapane dobre flagi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(232, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wygrałeś! Złapano 30 dobrych flag!";
            // 
            // Hi_score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pkt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hi_score";
            this.Text = "Hi_score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// Liczba punktów gracza
        /// </summary>
        private System.Windows.Forms.Label pkt;
        /// <summary>
        /// Tytuł gry
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// Przycisk gry jeszcze raz
        /// </summary>
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}