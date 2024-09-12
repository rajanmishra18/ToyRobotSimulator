using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulator.Services
{
    public interface IRobotActions
    {
        public void Move();
        public void TurnLeft();
        public void TurnRight();
    }
}
