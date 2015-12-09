using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAgentBasedModel
{
    abstract class PhysicalObject
    {
        //location in space
        public double x { get; private set; }
        public double y { get; private set; }
        public double z { get; private set; }
        //mass
        double mass;
        //for purpose of simulation considered immovable
        bool immovable;
        //from environment what is tolerences
        protected double tolerence;

        public PhysicalObject(Environment e)
        {
            tolerence = e.tolerence;
        }

        public void position(double x,double y)
        {
            this.x = x;
            this.y = y;
            this.z = 0;
        }
        public virtual bool collision(PhysicalObject collideWith)
        {
            //determine if this object has collided with the passed object
            if (Math.Abs(x - collideWith.x) < tolerence && Math.Abs(y - collideWith.y) < tolerence && Math.Abs(z - collideWith.z) < tolerence)
                return true;
            else
                return false;
        }
    }
}
