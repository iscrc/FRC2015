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
        public vector normal { get; private set; }
        //public double nx { get; private set; }
        //public double ny { get; private set; }
        //public double nz { get; private set; }

        //surface extent from location

        public Wall(Environment e) : base(e)
        {

        }

        public Wall(vector p,Environment e) :base(e)
        {
            base.position(p.x, p.y);
            if (p.x<0 && p.y<1) //top wall
            {
                normal = new vector(0, 1, 0);
                //nx = 0.0;
                //ny = 1.0; //points down towards center of display
                //nz = 0.0;
            }
        }
        public Wall(vector Origin, vector Normal,Environment e):base(e)
        {
            base.position(Origin.x, Origin.y);
            normal = Normal;
        }

        
        public double distanceFrom(vector pt)
        {
            /*
            double d = -( nx * x + ny * y + nz * z);
            double num = nx * x0 + ny * y0 + nz * z0 + d;
            double denom = Math.Sqrt(Math.Pow(nx, 2) + Math.Pow(ny, 2) + Math.Pow(nz, 2));
            double dist = num / denom;
            */
            return normal.pointFromPlane(location, pt);
        }
        

        //given a passed in vector, return a vector that is bouce off this surface normal
        public vector vectorBounce(vector v)
        {
            return normal.impact(v);
        }
        public override bool collision(PhysicalObject collideWith)
        {
            //using the normal of this wall, pass location of plane and location of object to test
            if (normal.pointFromPlane(location, collideWith.location) < 0) return true;
            return false;
        }
        /*
        public override bool collision(PhysicalObject collideWith)
        {
            if (x < 0) //this is a top or bottom wall
            { 
                if (y < 1) //top wall check
                {
                    if (collideWith.y < y)
                        return true;
                }
                else //bottom wall check
                {
                    if (collideWith.y > y)
                        return true;
                }
            }
            else //this is a left or right wall
            {
                if (x < 1) //left wall check
                {
                    if (collideWith.x < x)
                        return true;
                }
                else //right wall check
                {
                    if (collideWith.x > x)
                        return true;
                }
            }
            return false;
        }
        */
    
    }
}
