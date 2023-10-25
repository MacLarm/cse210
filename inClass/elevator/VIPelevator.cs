public class VIPelevator : Elevator
{
    private string _code = "1234";

    public VIPelevator(string name, int floors) : base(name, floors)
    {
        
        _currentFloor = 1;
    }

    public bool VerifyCode(string code)
    {
        if (code == _code)
        {
            Console.WriteLine("Access granted.");
        }
        else
        {
            Console.WriteLine("Access denied.");
        }
        return code == _code;
    }
}