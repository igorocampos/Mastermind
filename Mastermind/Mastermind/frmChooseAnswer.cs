using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class frmChooseAnswer : Form
    {
        public bool CloseAll { get; private set; }

        private readonly List<CirclePanel> circleList = new List<CirclePanel>();

        public frmChooseAnswer()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                var coloredPin = new CirclePanel { Size = new Size(20, 20), Location = new Point(30 * i + 85, 100) };
                this.Controls.Add(coloredPin);
                circleList.Add(coloredPin);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (var form = new frmMain(circleList[0].CurrentColor, circleList[1].CurrentColor, circleList[2].CurrentColor, circleList[3].CurrentColor))
            {
                form.ShowDialog();
                this.CloseAll = form.CloseAll;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
            => this.Close();
    }
}