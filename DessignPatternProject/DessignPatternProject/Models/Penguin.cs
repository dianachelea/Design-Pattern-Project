using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatternProject.Models
{
    public class Penguin : Animal
    {
        public override string Species
        {
            get
            {
                return "Penguin";
            }
        }

        public Penguin(string name) : base(name) { }
    }
}
