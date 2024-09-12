using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulator.Services
{
    public interface IRobotIO
    {
        void Place(int x, int y, Direction direction);
        public string Report();
    }
}
