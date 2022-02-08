using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    /// <summary>
    /// Klasa wyświetlająca okno gry i menu
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// Konstruktor klasy głównej
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Po kliknięciu w przycisk przejdź do okna gry z właściwym parametrem
        /// </summary>
        /// <param name="sender">Objekt</param>
        /// <param name="e">Akcja</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 win2 = new Form1(0)
            {
                Owner = this
            };
            Hide();
            _ = win2.ShowDialog();
            Close();
        }

        /// <summary>
        /// Po kliknięciu w przycisk przejdź do okna gry z właściwym parametrem
        /// </summary>
        /// <param name="sender">Objekt</param>
        /// <param name="e">Akcja</param>
        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 win2 = new Form1(1)
            {
                Owner = this
            };
            Hide();
            _ = win2.ShowDialog();
            Close();
        }

        private void InstrukcjaButton_Click(object sender, EventArgs e)
        {
            string message = "Twoim zadaniem jest zebranie 30 flag,\nz wybranej przez ciebie kategorii:\n-Kraje należące do Uni Europejskiej\n-Kraje nie należące do Uni Europejskiej\n\nGracz przegrywa po zebraniu 5 błędnych flag.";
            MessageBox.Show(message, "Instrukcja do gry", MessageBoxButtons.OK);
        }
    }
}
