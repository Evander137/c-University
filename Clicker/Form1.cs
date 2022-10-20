using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        int clickCount = 0;
        int seconds = 0;
        bool counting = false;

        int gameLength = 0;
        System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            clickCount++;
            gameLength = Convert.ToInt32(numGameLength.Value);
            labelInst.Hide();
            labelKerdes.Hide();
            numGameLength.Hide();
            Random r = new Random();
            int rX = r.Next(0, 650);
            int rY = r.Next(0, 600);
            this.btn.Location = new Point(
                rX,
                rY
            );
            if (!counting)
            {
                seconds = 0;
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000;
                timer.Tick += RunEvent;
                timer.Start();
            }
        }

        private void RunEvent(object sender, EventArgs e)
        {
            counting = true;
            seconds++;
            labelSeconds.Text = seconds.ToString();
            if (seconds >= gameLength)
            {
                timer.Stop();
                btn.Enabled = false;
                labelInst.Text = "Elért pontszám: " + clickCount;
                labelInst.Visible = true;
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.vineBoom);
                simpleSound.Play();
                String text = gameLength.ToString() + "s - " + clickCount + " points";
                File.WriteAllText("Data.txt", text);
            }
        }
    }
}
