using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = "눌림";

            lblStatus.Text += "+";
            tbStatus.Text += "+";

            if(timer1.Enabled == false)
            {
                timer1.Enabled = true;
                elapsedTime = 0;
                lblStatus.Text = "";
                tbStatus.Text = "" ;
                toolStripProgressBar1.Value = 0;
            }
            else timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            lblStatus.Text = elapsedTime + "초 경과";
            tbStatus.Text = elapsedTime + "초 경과"; ;
            toolStripProgressBar1.Value =  elapsedTime;
        }
        private int elapsedTime = 0;
    }
}
