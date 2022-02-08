using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    /// <summary>
    /// Klasa z wynikiem gracza
    /// </summary>
    public partial class Hi_score : Form
    {
        /// <summary>
        /// Konstruktor dziedziczący parametry
        /// </summary>
        /// <param name="punkty">Punkty końcowe gracza</param>
        /// <param name="ileFlag">Zebrane flagi</param>
        /// <param name="info"></param>
        public Hi_score(int punkty, int ileFlag, string info)
        {
            InitializeComponent();
            pkt.Text = "Punkty: " + punkty;
            label1.Text = "Złapane dobre flagi: " + ileFlag;
            label2.Text = info;
        }

        /// <summary>
        /// Po kliknięciu przycisku gra zaczyna się od nowa
        /// </summary>
        /// <param name="sender">Parametr</param>
        /// <param name="e">Akcja</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            Main win2 = new Main { Owner = this };
            Hide();
            _ = win2.ShowDialog();
            Close();
        }
    }
}
