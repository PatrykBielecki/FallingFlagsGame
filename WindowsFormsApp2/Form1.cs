using SpadajaceFlagi.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    /// <summary>
    /// Klasa przedstawiająca grę
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Czy wciśnięta strzałka w prawo
        /// </summary>
        bool goRight;

        /// <summary>
        /// Czy wciśnięta strzałka w lewo
        /// </summary>
        bool goLeft;

        /// <summary>
        /// Prędkość gracza
        /// </summary>
        int speed = 8;

        /// <summary>
        /// Prędkość flagi
        /// </summary>
        int flagSpeed = 4;

        /// <summary>
        /// Liczba uzyskanych punktóww
        /// </summary>
        int score = 0;

        /// <summary>
        /// Liczba uzyskanych wszystkich punktóww
        /// </summary>
        int scoreAll = 0;

        /// <summary>
        /// Liczba błędnie zebranych głosek
        /// </summary>
        int missed = 0;

        /// <summary>
        /// Losowanie położenia flagi po osi OY
        /// </summary>
        private readonly Random rndY = new Random();

        /// <summary>
        /// Losowanie położenia flagi po osi OX
        /// </summary>
        private readonly Random rndX = new Random();

        /// <summary>
        /// Jaki rodzaj flag zbierać - zmienna dziedziczona z klasy Main()
        /// </summary>
        private readonly bool co_zbierac;

        /// <summary>
        /// Zmienna losująca flage
        /// </summary>
        int number;

        /// <summary>
        /// Zmienna numeru poziomu
        /// </summary>
        int level = 1;

        /// <summary>
        /// Zmienna sprawdzająca czy zebrano właściwą flage
        /// </summary>
        bool dobrze = false;

        /// <summary>
        /// Konstruktor klasy odpowiedzialny za wywolanie pierwszych flag i dziedziczenie od klasy Menu wybranej opcji gracza
        /// </summary>
        /// <param name="zbieraj_z_UE"></param>
        public Form1(int zbieraj_z_UE)
        {
            InitializeComponent();
            if (zbieraj_z_UE == 0)
                co_zbierac = false;
            else co_zbierac = true;

            Reset();
        }

        /// <summary>
        /// Po kliknięciu strzałki lewo lub prawo następuje przygotowanie do ruchu gracza oraz warunki aby nie wychodził poza okno gry
        /// </summary>
        /// <param name="sender">Objekt</param>
        /// <param name="e">Akcja</param>
        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && player.Left + player.Width < 1010)
            {
                goRight = true;
            }
        }

        /// <summary>
        /// Po zwolnieniu przycisku przestań wykonywać ruchu gracza
        /// </summary>
        /// <param name="sender">Objekt</param>
        /// <param name="e">Akcja</param>
        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        /// <summary>
        /// Wykonywanie określonych akcji jak np. losowanie flagi która ma się pojawić, przesuwanie gracza itp.
        /// </summary>
        /// <param name="sender">Objekt</param>
        /// <param name="e">Akcja</param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (co_zbierac)
            {
                Label_missed.Text = "Zebrane flagi z UE: " + missed.ToString();
                Label_Score.Text = "Zebrane flagi spoza UE: " + scoreAll.ToString();
            }
            else
            {
                Label_missed.Text = "Zebrane flagi z UE: " + scoreAll.ToString();
                Label_Score.Text = "Zebrane flagi spoza UE: " + missed.ToString();
            }

            Punkty.Text = "Punkty: " + (score).ToString();

            if (goLeft) { player.Left -= speed; }
            if (goRight) { player.Left += speed; }

            if (player.Left < 5)
            {
                goLeft = false;
            }
            else if (player.Left + player.Width > 920)
            {
                goRight = false;
            }


            foreach (Control X in Controls)
            {
                if (X is Label && (string)X.Tag == "Flaga")
                {
                    X.Top += flagSpeed;

                    if (X.Top + X.Height > ClientSize.Height)
                    {
                        X.Top = rndY.Next(10, 800) * -1;
                        X.Left = rndX.Next(5, ClientSize.Width - X.Width);
                        X.Text = Convert.ToString(rndX.Next(36));

                        X.BackgroundImage = Image.FromFile(@"../../assets/" + X.Text + ".png");

                    }

                    if (X.Bounds.IntersectsWith(player.Bounds))
                    {
                        ChangeLevel();
                        X.Top = rndY.Next(10, 800) * -1;
                        X.Left = rndX.Next(5, ClientSize.Width - X.Width);
                        if (co_zbierac)
                        {
                            if (Convert.ToInt32(X.Text) < 18)
                            {
                                score += level * 10;
                                scoreAll++;
                                dobrze = true;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(X.Text) >= 18)
                            {
                                score += level * 10;
                                scoreAll++;
                                dobrze = true;
                            }
                        }

                        if (!dobrze)
                        {
                            if (score - level * 10 >= 0) score -= level * 10;
                            else score = 0;
                            missed++;
                        }
                        dobrze = false;

                        number = rndX.Next(36);
                        X.Text = number.ToString();

                        X.BackgroundImage = Image.FromFile(@"../../assets/" + X.Text + ".png");

                        SoundPlayer boop = new SoundPlayer(Resources.boop);
                        boop.Play();
                    }

                    if (missed >= 5)
                    {
                        timer1.Stop();
                        Hi_score win2 = new Hi_score(score, scoreAll, "Przegrana, złapano 5 niepoprawnych flag :(") { Owner = this };
                        Hide();
                        _ = win2.ShowDialog();
                        Close();
                    }

                    if (scoreAll >= 30)
                    {
                        timer1.Stop();
                        Hi_score win2 = new Hi_score(score, scoreAll, "Wygrana! Złapano 30 dobrych flag!") { Owner = this };
                        Hide();
                        _ = win2.ShowDialog();
                        Close();
                    }
                }
            }

        }

        /// <summary>
        /// Zmiana poziomu trudności
        /// </summary>
        private void ChangeLevel()
        {
            if (scoreAll == 4)
            {
                flagSpeed = 6;
                speed = 10;
                ChangeLevelInfo(2);
            }
            else if (scoreAll == 9)
            {
                flagSpeed = 8;
                speed = 12;
                ChangeLevelInfo(3);
            }
            else if (scoreAll == 14)
            {
                flagSpeed = 10;
                speed = 16;
                ChangeLevelInfo(4);
            }
        }

        /// <summary>
        /// Przygotowanie do gry i wylosowanie pierwszych flag
        /// </summary>
        private void Reset()
        {
            foreach (Control X in Controls)
            {
                if (X is Label && (string)X.Tag == "Flaga")
                {
                    X.Top = rndY.Next(10, 800) * -1;
                    X.Left = rndX.Next(5, ClientSize.Width - X.Width);
                    X.Text = Convert.ToString(rndX.Next(36));

                    X.BackgroundImage = Image.FromFile(@"../../assets/" + X.Text + ".png");
                }
            }

            player.Left = ClientSize.Width / 2 - 80;
            score = 0;
            missed = 0;
            speed = 8;
            Label_missed.Text = "Zebrane flagi z UE: " + missed.ToString();
            Label_Score.Text = "Zebrane flagi spoza UE: " + scoreAll.ToString();
            Punkty.Text = "Punkty: " + (score).ToString();
            goLeft = false;
            goRight = false;
            timer1.Start();
            ChangeLevelInfo(1);
        }

        /// <summary>
        /// Pokazanie informacji o zmianie poziomu
        /// </summary>
        /// <param name="x">Numer poziomu</param>
        private async void ChangeLevelInfo(int x)
        {
            await Task.Delay(40);
            level = x;
            CurrentLevel.Text = "Poziom: " + x;
            NextLevelInfo.Text = "Poziom " + x;
            NextLevelInfo.Visible = true;
            timer1.Stop();
            await Task.Delay(2000);
            timer1.Start();
            NextLevelInfo.Visible = false;
        }
    }
}
