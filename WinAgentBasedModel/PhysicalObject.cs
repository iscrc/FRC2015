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
        public vector location { get; protected set; }
        //public double x { get; protected set; }
        //public double y { get; protected set; }
        //public double z { get; protected set; }
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
            location = new vector(x,y,0);
        }
        public virtual bool collision(PhysicalObject collideWith)
        {
            //determine if this object has collided with the passed object
            if (location.distance(collideWith.location) < tolerence)
                return true;
            else
                return false;
        }
    }
}
