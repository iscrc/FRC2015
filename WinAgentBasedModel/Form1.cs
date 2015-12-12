using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAgentBasedModel
{
    public partial class Form1 : Form
    {
        Environment e;
        Wall[] walls = new Wall[4];
        simpleBot bot;
        Bitmap img;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            e = new Environment();
            walls[0] = new Wall(new vector(0,0,0), new vector(1,0,0),e); //left wall
            walls[1] = new Wall(new vector(258, 0,0), new vector(-1,0,0), e); //right wall
            walls[2] = new Wall(new vector(0,10,0), new vector(0,1,0), e); //top wall
            walls[3] = new Wall(new vector(0, 189,0), new vector(0,-1,0), e); //bottom wall
            for (int i = 0; i < 4; i++) e.addOjbect(walls[i]);

            //bot = new simpleBot(e);                 e.addAgent(bot);
            //bot = new simpleBot(e, 50, 50, 0, 5);   e.addAgent(bot);
            bot = new simpleBot(e, 100, 25, 0.2, 2);e.addAgent(bot);

            img = new Bitmap(pictureBox1.Size.Width,pictureBox1.Size.Height);
        }
        private void doStep()
        {
            Graphics g = Graphics.FromImage(img);
            g.Clear(Color.AntiqueWhite);
            e.timeStep(1.0);
            foreach (simpleBot bot in e.agents)
                bot.plot(g);
            pictureBox1.Image = img;
            //get a dist calc
            vector v = e.agents[0].location;
            double d = walls[0].distanceFrom(v);
            distLeft.Text = String.Format("{0:F2}", d);
            d = walls[1].distanceFrom(v);
            distRight.Text = String.Format("{0:F2}", d);
            d = walls[2].distanceFrom(v);
            distTop.Text = String.Format("{0:F2}", d);
            d = walls[3].distanceFrom(v);
            distBottom.Text = String.Format("{0:F2}", d);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doStep();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            doStep();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
