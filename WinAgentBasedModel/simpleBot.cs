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
        double dir; //direction frame is pointing, in radians, relative to x,y grid
        double speed;

        public simpleBot(Environment e): base(e)
        {
            location = new vector(20, 120, 0);
            dir = 40 * Math.PI / 180.0;
            speed = 10; //10 units per time unit
        }
        public simpleBot(Environment e,double x,double y,double dir,double speed) : base(e)
        {
            location = new vector(x, y, 0);
            this.dir = dir;
            this.speed = speed;
        }
        public override void Act(double timeStep)
        {
            base.Act(timeStep); //do any generic stuff
            impact(timeStep); //check for collisions
            location.moveX( Math.Cos(dir) * timeStep * speed);
            location.moveY( Math.Sin(dir) * timeStep * speed);
            dir += 0.0 * Math.PI / 180.0; //rate of turn 10 degrees/unit timestep , convert to radians
            if (dir < 0) dir += twoPI;
            if (dir > twoPI) dir -= twoPI;
        }

        public override void impact(double timeStep)
        {
            base.impact(timeStep); //get simple collsion info
            //decide what to do with collsions, for simple bot, bounce off walls
            foreach (PhysicalObject po in collide)
            {
                if (po is Wall)
                {
                    Wall w = (Wall)po;
                    //use wall normal to bounce;
                    dir = w.vectorBounce(new vector(dir)).toRadians();
                    location.moveX(Math.Cos(dir) * timeStep * speed);
                    location.moveY(Math.Sin(dir) * timeStep * speed);
                }
                /*
                if (Math.Abs(po.ny) < 0) //hit top or bottom
                {
                    //between 0 - pi is moving left to right
                    double diff = Math.PI / 2.0 - dir;
                    dir = Math.PI / 2.0 + diff;
                    //dir += 5.0 * Math.PI / 180.0; //turn 5 degrees
                    //y = po.y;
                }
                else //hit left or right
                {
                    double diff = Math.PI - dir;
                    dir = Math.PI + diff;
                    //dir += Math.PI; //turn 180 degress
                    //x = po.x;
                }
                */
            }
            if (collide.Count > 0) collide.Clear();
        }
        public override void plot(System.Drawing.Graphics g)
        {
            //g.DrawLine(System.Drawing.Pens.Black, (float)x, (float)y, (float)x+10, (float)y-10);
            g.DrawRectangle(System.Drawing.Pens.Black, (float)location.x - 3, (float)location.y - 3, 6, 6);
        }
    }
}
