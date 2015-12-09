using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAgentBasedModel
{
    class Agent
    {
        //properties of the agent
        //behaviors of agent
        //access to the environment
        Environment embed;

        public Agent(Environment e)
        {
            embed = e;
        }
        //stimulus-response of agents
        //time step of Agent
        public virtual void Act(double timeStep)
        {
            //generic actions here
        }
        public virtual void impact()
        {
            //check to see if agent has had any physical collosions with either other agents or environment
            foreach (PhysicalObject po in embed.localObjects)
            { }
        }
    }
}
