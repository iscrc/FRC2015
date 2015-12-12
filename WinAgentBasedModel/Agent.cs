using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAgentBasedModel
{
    class Agent : PhysicalObject
    {
        //properties of the agent
        //behaviors of agent
        //access to the environment
        Environment embed;
        protected List<PhysicalObject> collide;

        public Agent(Environment e) : base(e)
        {
            embed = e;
            collide = new List<PhysicalObject>();
        }
        //stimulus-response of agents
        //time step of Agent
        public virtual void Act(double timeStep)
        {
            //generic actions here
        }
        public virtual void impact(double timeStep)
        {
            //check to see if agent has had any physical collosions with either other agents or environment
            foreach (PhysicalObject po in embed.localObjects)
            {
                if (po.collision(this)) collide.Add(po);
            }
        }
    }
}
