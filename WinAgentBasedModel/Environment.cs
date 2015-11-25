using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAgentBasedModel
{
    class Environment
    {
        //agents will be injected into environment
        List<Agent> agents;
        List<Object> localObjects;

        void addAgent(Agent a)
        {
            agents.Add(a);
        }
        //environment is stepped thru time with some increment
        double currentTime;
        void timeStep(double increment)
        {
            //adjust non-agent aspects of environment (e.g. falling objects)
            foreach (Object o in localObjects)
            {

            }

            //tells each agent to act, within the time step increment
            foreach (Agent a in agents) { }
            currentTime += increment;
        }
    }
}
