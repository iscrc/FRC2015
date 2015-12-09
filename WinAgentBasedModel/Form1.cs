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
            walls[0] = new Wall(new PointF(0.0F,-1.0F),e); //left wall
            walls[1] = new Wall(new PointF(258.0F, -1.0F), e); //right wall
            walls[2] = new Wall(new PointF(-1.0F, 0.0F), e); //top wall
            walls[3] = new Wall(new PointF(-1.0F, 189.0F), e); //bottom wall
            for (int i = 0; i < 4; i++) e.addOjbect(walls[i]);

            bot = new simpleBot(e);
            e.addAgent(bot);
            img = new Bitmap(pictureBox1.Size.Width,pictureBox1.Size.Height);
        }
        private void doStep()
        {
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(img);
            e.timeStep(1.0);
            bot.plot(g);
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doStep();
        }
    }
}
