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
        Wall[] walls = new Wall[5];
        simpleBot bot;
        Bitmap img;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            Random r = new Random();
            e = new Environment();
            walls[0] = new Wall(new vector(10,0,0), new vector(1,0,0),e); //left wall
            walls[1] = new Wall(new vector(250, 0,0), new vector(-1,0,0), e); //right wall
            walls[2] = new Wall(new vector(0,10,0), new vector(0,1,0), e); //top wall
            walls[3] = new Wall(new vector(0, 180,0), new vector(0,-1,0), e); //bottom wall
            walls[4] = new Wall(new vector(100, 100, 0), new vector(0.5, 0.5, 0), e); //corner slanted wall
            for (int i = 0; i < 5; i++) e.addOjbect(walls[i]);

            //bot = new simpleBot(e);                 e.addAgent(bot);
            bot = new simpleBot(e, 140, 150, 0, 2);   e.addAgent(bot);
            bot = new simpleBot(e, 150,150, Math.PI, 1);e.addAgent(bot);
            /*
            for (int i=0; i<10; i++)
            {
                bot = new simpleBot(e, r.NextDouble() * 100.0+50.0, r.NextDouble() * 100+50.0, r.NextDouble() * 2 * Math.PI, r.NextDouble() * 5 + 5.0);
                e.addAgent(bot);
            }
            */
            img = new Bitmap(pictureBox1.Size.Width,pictureBox1.Size.Height);
        }
        private void doStep()
        {
            Graphics g = Graphics.FromImage(img);
            //g.Clear(Color.AntiqueWhite);
            g.Clear(Color.FromKnownColor(KnownColor.Control));
            e.timeStep(0.1);
            foreach (simpleBot bot in e.agents)
                bot.plot(g);
            foreach (PhysicalObject po in e.localObjects)
                po.plot(g);
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
