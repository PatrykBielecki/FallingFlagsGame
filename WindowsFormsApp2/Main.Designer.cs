using System.Drawing;

namespace WindowsFormsApp2
{
    partial class Main
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.instrukcjaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spadające flagi";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(168, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Łapię flagi należące\ndo Unii Europejskiej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(621, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 94);
            this.button2.TabIndex = 2;
            this.button2.Text = "Łapię flagi nie należące\ndo Unii Europejskiej";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // instrukcjaButton
            // 
            this.instrukcjaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instrukcjaButton.Location = new System.Drawing.Point(842, 657);
            this.instrukcjaButton.Name = "instrukcjaButton";
            this.instrukcjaButton.Size = new System.Drawing.Size(154, 60);
            this.instrukcjaButton.TabIndex = 3;
            this.instrukcjaButton.Text = "Instrukcja";
            this.instrukcjaButton.UseVisualStyleBackColor = true;
            this.instrukcjaButton.Click += new System.EventHandler(this.InstrukcjaButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.instrukcjaButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Spadające flagi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Tytuł gry
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// Wybór opcji łapania flag
        /// </summary>
        private System.Windows.Forms.Button button1;
        /// <summary>
        /// Wybór opcji łapania flag
        /// </summary>
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button instrukcjaButton;
    }
}