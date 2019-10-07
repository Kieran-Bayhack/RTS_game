using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTS_Game
{
    public partial class Form1 : Form
    {
        GameEngine engine;
        int count = 0;
        private static System.Timers.Timer timer1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            engine = new GameEngine(this, this.GroupBox);
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            engine.UpdateMap();
            engine.UpdateDisplay();
            lbl_Round.Text = (++count).ToString();
        }

        public void displayInfo(string message)
        {
            lBox1.Items.Add(message);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
