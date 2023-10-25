public class Elevator
{
    protected string _name;
    protected int _currentFloor;
    protected bool _doorOpen = false;
    protected int _floors;

    public Elevator(string name, int floors)
    {
        _name = name;
        _currentFloor = 1;
        _floors = floors;
    }

    public void OpenDoor()
    {
        _doorOpen = true;
        Console.WriteLine("Door is now open.");
    }

    public void CloseDoor()
    {
        _doorOpen = false;
        Console.WriteLine("Door is now closed.");
    }

    public void MoveToFloor(int floor)
    {
        _currentFloor = floor;
        Console.WriteLine($"Moving to floor {floor}.");
    }

    public void ListFloors()
    {
        int floor = 1;
        while (floor <= _floors)
        {
            if (floor != _currentFloor)
            {
                Console.WriteLine($"{floor}");
            }
            floor ++;
        }
    }

    public void CallElevator(int callFloor)
    {
        _currentFloor = callFloor;
        Console.WriteLine($"Calling Elevator to floor {callFloor}");
    }

    public void DisplayFloor()
    {
        Console.WriteLine($"{_name} is on floor {_currentFloor}");
    }
}