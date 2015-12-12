using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAgentBasedModel
{
    class Environment
    {
        //tolerences used in this environment, values less than this are equal to zero
        public double tolerence { get; private set; }

        //agents will be injected into environment
        public List<Agent> agents { get; private set; }
        public List<PhysicalObject> localObjects { get; private set; }

        public Environment()
        {
            agents = new List<Agent>();
            localObjects = new List<PhysicalObject>();
            tolerence = 1.0; //a single unit

        }
        public void addOjbect(PhysicalObject po)
        {
            localObjects.Add(po);
        }
        public void addAgent(Agent a)
        {
            agents.Add(a);
        }
        //environment is stepped thru time with some increment
        double currentTime;
        public void timeStep(double increment)
        {
            //adjust non-agent aspects of environment (e.g. falling objects)
            foreach (Object o in localObjects)
            {

            }

            //tells each agent to act, within the time step increment
            foreach (Agent a in agents) { a.Act(increment); }
            currentTime += increment;
        }
    }
}
