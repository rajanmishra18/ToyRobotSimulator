using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobotSimulator.Services;

namespace ToyRobotSimulator
{
    public enum Direction { NORTH, EAST, SOUTH, WEST }

    public class Robot: IRobotActions,IRobotIO
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Facing { get; private set; }
        private Table _table;

        public Robot(Table table)
        {
            _table = table;
        }


        // Implement all actions imported from interface

        public void Move()
        {
            int newX = X, newY = Y;
            switch (Facing)
            {
                case Direction.NORTH: newY++; break;
                case Direction.EAST: newX++; break;
                case Direction.SOUTH: newY--; break;
                case Direction.WEST: newX--; break;
            }

            if (_table.IsPositionValid(newX, newY))
            {
                X = newX;
                Y = newY;
            }
        }

        public void TurnLeft() => Facing = (Direction)(((int)Facing + 3) % 4);
        public void TurnRight() => Facing = (Direction)(((int)Facing + 1) % 4);
        public void Place(int x, int y, Direction direction)
        {
            if (_table.IsPositionValid(x, y))
            {
                X = x;
                Y = y;
                Facing = direction;
            }
        }
        public string Report() => $"{X},{Y},{Facing}";
    }
}
