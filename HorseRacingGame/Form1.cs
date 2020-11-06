using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private int distanceFinish;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            distanceFinish = lblFinish.Left;

            pbxHorse1.Left += random.Next(1, 15);
            pbxHorse2.Left += random.Next(1, 15);
            pbxHorse3.Left += random.Next(1, 15);

            if (pbxHorse1.Right>= distanceFinish)
            {
                timer1.Enabled = false;
                lblResult.Text = "1 number horse finished race in front";
                lblResult.BackColor = Color.SaddleBrown;
                HorseEnabled(false,pbxHorse1);

            }
            if (pbxHorse2.Right >= distanceFinish)
            {
                timer1.Enabled = false;
                lblResult.Text = "2 number horse finished race in front";
                lblResult.BackColor = Color.SandyBrown;
                HorseEnabled(false,pbxHorse2);

            }
            if (pbxHorse3.Right >= distanceFinish)
            {
                timer1.Enabled = false;
                lblResult.Text = "3 number horse finished race in front";
                lblResult.BackColor = Color.Gray;
                HorseEnabled(false,pbxHorse3);


            }

            if (pbxHorse1.Left > pbxHorse2.Left + 1 && pbxHorse1.Left > pbxHorse3.Left +1)
            {
                lblResult.Text = "1 number horse come to the fore";
                lblResult.BackColor = Color.SaddleBrown;
                
            }

            if (pbxHorse2.Left > pbxHorse1.Left + 1 && pbxHorse2.Left > pbxHorse3.Left + 1)
            {
                lblResult.Text = "2 number horse come to the fore";
                lblResult.BackColor = Color.SandyBrown;
               
            }
            if (pbxHorse3.Left > pbxHorse2.Left + 1 && pbxHorse3.Left > pbxHorse1.Left + 1)
            {
                lblResult.Text = "3 number horse come to the fore";
                lblResult.BackColor = Color.Gray;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HorseEnabled(false);
        }

        void HorseEnabled(bool state)
        {
            pbxHorse1.Enabled = pbxHorse2.Enabled = pbxHorse3.Enabled = state;
            pbxHorse1.Left = 0;
            pbxHorse2.Left = 0;
            pbxHorse3.Left = 0;
            if (state == true)
            {
                timer1.Enabled = true;
            }
        }

        void HorseEnabled(bool state,PictureBox pbBox)
        {
            pbxHorse1.Enabled = pbxHorse2.Enabled = pbxHorse3.Enabled = state;

            pbBox.Enabled = true;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            HorseEnabled(true);

        }

    }
}
