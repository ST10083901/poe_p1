using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poe_p1
{
    internal class Steps
    {
        public Steps(string description)
        {
            Description = description;
            Step = new List<Steps>();
        }

       

        public string Description { get; set; }
        public List<Steps> Step { get; set; }

        public void AddStep(string description)
        {
            Steps.Add(new Step { Description = description });
        }

        private static void Add(Steps steps)
        {
            throw new NotImplementedException();
        }
    }
}
