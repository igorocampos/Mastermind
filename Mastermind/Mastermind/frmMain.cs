using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class frmMain : Form
    {
        private int remainingChances = 10;
        private readonly List<CirclePanel> currentColors = new List<CirclePanel>();
        private readonly List<eColor> answer = new List<eColor>();

        public bool CloseAll { get; private set; }

        public frmMain(eColor color1, eColor color2, eColor color3, eColor color4)
        {
            InitializeComponent();
            AddNewRow();

            answer.AddRange(new[] { color1, color2, color3, color4 });

            var answerControls = new[] {
                new CirclePanel { Size = new Size(20, 20), Location = new Point(15,20), CurrentColor = answer[0] },
                new CirclePanel { Size = new Size(20, 20), Location = new Point(38,20), CurrentColor = answer[1] },
                new CirclePanel { Size = new Size(20, 20), Location = new Point(61,20), CurrentColor = answer[2] },
                new CirclePanel { Size = new Size(20, 20), Location = new Point(84,20), CurrentColor = answer[3] }
            };

            grpAnswer.Controls.AddRange(answerControls);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            remainingChances--;
            btnVerify.Text = $"Verify{Environment.NewLine}({remainingChances} left)";
            var (blackPins, whitePins) = GetResults();
            AddNewResultRow(blackPins, whitePins);

            if (remainingChances == 0 || blackPins == 4)
                Finished();
            else
                AddNewRow();
        }

        private void AddNewResultRow(int blackPins, int whitePins)
        {
            if (blackPins + whitePins > 4)
                throw new Exception("Sum of white and black pins should be at most 4.");

            int count = 0;

            //add all black pins
            while (count < blackPins)
            {
                AddNewResultPin(Color.Black);
                count++;
            }

            //add all white pins
            while (count < whitePins + blackPins)
            {
                AddNewResultPin(Color.White);
                count++;
            }

            //add remaining transparent pins
            while (count < 4)
            {
                AddNewResultPin(Color.Transparent);
                count++;
            }

            flpResults.Controls.Add(GetNewLine(flpResults.Width - 5));
        }

        private (int, int) GetResults()
        {
            int[] array = new int[] { 0, 0, 0, 0 };
            List<eColor> remainingColors = new List<eColor>();
            (int blacks, int whites) result = (0, 0);
            //set all black pins
            for (int i = 0; i < 4; i++)
            {
                if (currentColors[i].CurrentColor == answer[i])
                {
                    array[i] = 1;
                    result.blacks++;
                }
                else
                    remainingColors.Add(answer[i]);
            }

            //set all white pins (a white can't be compared to a position that is already black)
            for (int i = 0; i < 4; i++)
            {
                var color = currentColors[i].CurrentColor;

                //If it's not set yet, search for other positions with the same color
                if (array[i] == 0)
                {
                    int index = remainingColors.IndexOf(color);

                    //Found color in different position
                    if (index >= 0)
                    {
                        remainingColors.RemoveAt(index);
                        result.whites++;
                    }
                }
            }
            return result;
        }

        private Panel GetNewLine(int width)
        {
            return new Panel
            {
                BackColor = Color.LightGray,
                Size = new Size(width, 1),
                Margin = new Padding(2, 2, 2, 2),
            };
        }

        private void AddNewResultPin(Color color)
        {
            var pin = new CirclePanel
            {
                Size = new Size(10, 10),
                Margin = new Padding(1, 2, 1, 1),
                BackColor = color,
                AllowColorChange = false
            };
            flpResults.Controls.Add(pin);
        }

        private void AddNewRow()
        {
            foreach (var pin in currentColors)
                pin.AllowColorChange = false;

            currentColors.Clear();
            for (int i = 0; i < 4; i++)
            {
                var coloredPin = new CirclePanel { Size = new Size(20, 20) };
                flpLayout.Controls.Add(coloredPin);
                currentColors.Add(coloredPin);
            }

            //Adds a separation line made with a simple Panel
            flpLayout.Controls.Add(GetNewLine(flpLayout.Width - 5));
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.CloseAll = true;
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
            => Finished();

        private void Finished()
            => pnlHide.Visible = btnVerify.Enabled = false;
    }
}