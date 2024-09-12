using System;
using ToyRobotSimulator;

class Program
{
    static void Main(string[] args)
    {
        var table = new Table(5, 5);
        var robot = new Robot(table);

        while (true)
        {
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) break;

            var command = input.Split(' ');
            switch (command[0])
            {
                case "PLACE":
                    var parameters = command[1].Split(',');
                    robot.Place(int.Parse(parameters[0]), int.Parse(parameters[1]), Enum.Parse<Direction>(parameters[2]));
                    break;
                case "MOVE": robot.Move(); break;
                case "LEFT": robot.TurnLeft(); break;
                case "RIGHT": robot.TurnRight(); break;
                case "REPORT": Console.WriteLine(robot.Report()); break;
            }
        }
    }
}