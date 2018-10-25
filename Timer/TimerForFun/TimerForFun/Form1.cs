using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TimerForFun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DateTime startTime; // it'll keep the execution date of app.
        Stopwatch sw; // Definiton for stopwatch.
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            startTime = DateTime.Now;
            lblStartTime.Text = startTime.ToString().Substring(10, 9);
            sw = new Stopwatch();
            sw.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = sw.Elapsed.ToString().Substring(0, 10);
            lblCurrent.Text = DateTime.Now.ToString().Substring(10, 9);
        }
    }
}
