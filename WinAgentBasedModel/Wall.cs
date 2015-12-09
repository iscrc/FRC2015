using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAgentBasedModel
{
    class Wall : PhysicalObject 
    {
        //surface normal
        public double nx { get; private set; }
        public double ny { get; private set; }
        public double nz { get; private set; }

        //surface extent from location

        public Wall(Environment e) : base(e)
        {

        }

        public Wall(System.Drawing.PointF p,Environment e) :base(e)
        {
            base.position(p.X, p.Y);
        }

        public override bool collision(PhysicalObject collideWith)
        {
            if (x < 0) //this is a top or bottom wall
            {
                if (Math.Abs(y - collideWith.y) < tolerence)
                    return true;
            }
            else //this is a left or right wall
            {
                if (Math.Abs(x - collideWith.x) < tolerence)
                    return true;
            }
            return false;
        }
    
    }
}
