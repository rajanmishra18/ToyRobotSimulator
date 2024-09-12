using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulator
{
    public class Table
    {
        private readonly int _width;
        private readonly int _height;

        public Table(int width, int height)
        {
            _width = width;
            _height = height;
        }
        // Check for position inside boundary
        public bool IsPositionValid(int x, int y)
        {
            return x >= 0 && x < _width && y >= 0 && y < _height;
        }
    }
}
