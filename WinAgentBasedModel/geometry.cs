using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAgentBasedModel
{
    class geometry
    {
    }

    class vector
    {
        public double x { get; private set; }
        public double y { get; private set; }
        public double z { get; private set; }

        public vector(double x,double y,double z)
        {
            this.x = x; this.y = y; this.z = z;

        }

        public vector(double radians)
        {
            //given a 2D heading in radians, convert to unit vector, set Z axis to zero
            x = Math.Sin(radians);
            y = Math.Cos(radians);
            z = 0;
        }
        public double toRadians()
        {
            //convert the x,y into polar
            double results = Math.Atan2(y, x);
            if (results < 0) results += 2.0 * Math.PI;
            return results;
        }
        public void move(vector delta)
        {
            x += delta.x;
            y += delta.y;
            z += delta.z;
        }
        public void moveX(double delta)
        {
            x += delta;
        }
        public void moveY(double delta)
        {
            y += delta;
        }
        public vector impact(vector v)
        {
            vector vprime, u, w;
            //N dot N = magnitude of N^2 (note for unit vectors this is just "1")
            double mag = x * x + y * y + z * z;
            //V dot N
            double dot = v.x * x + v.y * y + v.z * z;
            // (V dot N)/(N dot N)
            dot = dot / mag;
            //u = (V dot N) N
            u = new vector(x * dot, y * dot, z * dot);
            //w = v - u
            w = new vector(v.x - u.x, v.y - u.y, v.z - u.z);
            //Vprime = W - U
            vprime = new vector(w.x - u.x,w.y-u.y,w.z-u.z);
            return vprime;
        }

        public double distance(vector v)
        {
            return Math.Sqrt(Math.Pow(v.x - x, 2) + Math.Pow(v.y - y, 2) + Math.Pow(v.z - z, 2));
        }

        //my values are the normal for a plane, passed plane orgin,and a point, return distance from plane to point
        public double pointFromPlane(vector org,vector pt)
        {
            double d = -(x * org.x + y * org.y + z * org.z);
            double num = x * pt.x + y * pt.y + z * pt.z + d;
            double denom = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            double dist = num / denom;
            return dist;
        }
    }
}
