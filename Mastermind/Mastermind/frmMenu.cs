using System;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.Hide();

            using (var form = new frmMain((eColor)rnd.Next(0, 5), (eColor)rnd.Next(0, 5), (eColor)rnd.Next(0, 5), (eColor)rnd.Next(0, 5)))
            {
                form.ShowDialog();
                if (form.CloseAll)
                    this.Close();
                else
                    this.Show();
            }
        }

        private void btnTwoPlayers_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var form = new frmChooseAnswer())
            {
                form.ShowDialog();
                if (form.CloseAll)
                    this.Close();
                else
                    this.Show();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}