using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAgentBasedModel
{
    class simpleBot : Agent
    {
        const double twoPI = 2.0 * Math.PI;
        double x, y; // x,y locations in space
        double dir; //direction frame is pointing, in radians, relative to x,y grid
        double speed;

        public simpleBot(Environment e): base(e)
        {
            x = 20; y = 120; dir = 40 * Math.PI / 180.0;
            speed = 10; //10 units per time unit
        }
        public override void Act(double timeStep)
        {
            base.Act(timeStep); //do any generic stuff
            x += Math.Sin(dir) * timeStep * speed;
            y += Math.Cos(dir) * timeStep * speed;
            dir += 10.0 * Math.PI / 180.0; //rate of turn 10 degrees/unit timestep , convert to radians
            if (dir < 0) dir += twoPI;
            if (dir > twoPI) dir -= twoPI;
        }

        public override void impact()
        {
            base.impact(); //get collsion info
            //decide what to do with collsions, for simple bot, bounce off walls
        }
        public void plot(System.Drawing.Graphics g)
        {
            //g.DrawLine(System.Drawing.Pens.Black, (float)x, (float)y, (float)x+10, (float)y-10);
            g.DrawRectangle(System.Drawing.Pens.Black, (float)x - 3, (float)y - 3, 6, 6);
        }
    }
}
