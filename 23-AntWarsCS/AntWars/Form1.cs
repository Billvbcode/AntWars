using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntWars
{
    public partial class Form1 : Form
    {
        int iScore; // To Keep Score
        int iTick;  // To Speed up Timer

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   


       
        private void button1_Click(object sender, EventArgs e)
        {
            L1.Text = "Hi";
            T1.Start(); //Start Timer
            A1.Top = 400; //Reset Ants
            A2.Top = 400;
            A3.Top = 400;
            A4.Top = 400;
            A4.Visible = false;
            iScore = 0;  //Reset Score
            L1.Text = "Score= " + iScore;
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            A1.Top -= 10; //Move Ant
            A2.Top -= 10; //Move Ant2
            A3.Top -= 10; //Move Ant3
            if (A4.Visible) //Only move Ant4 When Visible
                A4.Top -= 10; //Move Ant4 when visible
            if (iScore > 10) //At a score of 10
                A4.Visible = true; //Make Ant4 visible

            if (A1.Top<0 | A2.Top < 0) //A1 Off Screen
            {
                T1.Stop(); // Stop Timer
                L1.Text += "  You Lost!";
            }
            T1.Interval = 200 - iScore;  //Speed Up
            this.Text= "Speed=" + T1.Interval;  //Show Speed
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (T1.Enabled == false)
                return; //Exit if Timer not running
            A1.Top = 400;
            iScore += 5;  //Add to Score
            L1.Text = "Score= " + iScore;
        }

        private void A2_Click(object sender, EventArgs e)
        {
            A2.Top = 400;
            iScore += 5;  //Add to Score
            L1.Text = "Score= " + iScore;
        }

        private void A3_Click(object sender, EventArgs e)
        {
            A3.Top = 400;
            iScore += 5;  //Add to Score
            L1.Text = "Score= " + iScore;
        }

        private void A4_Click(object sender, EventArgs e)
        {
            A4.Top = 400;
            iScore += 5;  //Add to Score
            L1.Text = "Score= " + iScore; 
        }
    }
}
