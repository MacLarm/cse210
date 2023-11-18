public class Level
{
    private int _currentPoints;
    private int _totalPoints;
    private int _level;

    public Level()
    {
        _currentPoints = 0;
        _totalPoints = 0;
        _level = 1;
    }

    public Level(int currentPoints, int totalPoints, int level)
    {
        _currentPoints = currentPoints;
        _totalPoints = totalPoints;
        _level = level;
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
        _currentPoints += points;
        if(_currentPoints >= (_level * 1000))
        {
            _level ++;
            _currentPoints -= 1000;
        }
    }

    public void DisplayPoints()
    {
        int pointsToLevel = (_level * 1000) - _currentPoints;
        Console.WriteLine($"Level {_level}: {_totalPoints} total Points.");
        Console.WriteLine($"{pointsToLevel} more points to level up.");
    }

    public string StringifyLevel()
    {
        //       0            1              2              3 
        return $"Level|{_currentPoints}|{_totalPoints}|{_level}";
    }
}