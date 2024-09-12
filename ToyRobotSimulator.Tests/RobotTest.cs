using ToyRobotSimulator;

public class RobotTests
{
    private Table table = new Table(5, 5);

    [Fact]
    public void TestRobotMovement()
    {
        var robot = new Robot(table);
        robot.Place(0, 0, Direction.NORTH);
        robot.Move();
        Assert.Equal("0,1,NORTH", robot.Report());
    }

    [Fact]
    public void TestRobotTurningLeft()
    {
        var robot = new Robot(table);
        robot.Place(0, 0, Direction.NORTH);
        robot.TurnLeft();
        Assert.Equal("0,0,WEST", robot.Report());
    }

    [Fact]
    public void TestRobotFallingOffTable()
    {
        var robot = new Robot(table);
        robot.Place(0, 0, Direction.SOUTH);
        robot.Move();
        Assert.Equal("0,0,SOUTH", robot.Report()); 
    }
}