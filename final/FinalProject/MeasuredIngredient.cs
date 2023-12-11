using System.Diagnostics;

public class MeasuredIngredient : Ingredient 
// this will handle the conversion from cups, to tablespoons, to teaspoons,
// and fractions of each.
{
    private List<string> _measurement = new List<string>()
    {"Cup", "Tablespoon", "Teaspoon"};
    private string _type;
    private double _tsp;

    public MeasuredIngredient(string type)
    {
    
        SetType(type);
        SetTsp();
    }
    
    public MeasuredIngredient(double quantity,string name, string type) : base (quantity, name)
    {
        _type = type;
        SetTsp();
    }

    public void DisplayTypes()
    {
        int number = 1;
        foreach(string type in _measurement)
        {
            Console.WriteLine($"{number}. {type}");
            number ++;
        }
    }

    public void SetType(string type)
    {
        switch (type)
        {
            case "1":
                _type = "Cup";
                break;
            case "2":
                _type = "Tablespoon";
                break;
            case "3":
                _type = "Teaspoon";
                break;
        }
    }

    public void SetTsp()
    {
        switch (_name)
        {
            case "Cup":
                _tsp = _quantity * 48;
                break;
            case "Tablespoon":
                _tsp = _quantity * 3;
                break;
            case "Teaspoon":
                _tsp = _quantity;
                break;
        }
    }

    public override void DisplayIngredient()
    {
        //Console.WriteLine($"{DisplayMeasurement()} {_name}");
        Console.WriteLine($"{_quantity} {_type} {_name}");
    }

    public string DisplayMeasurement()
    {
        string measurment = "";
        switch(_tsp)
        {
            case <= 3:
                measurment = $"{_quantity} Teaspoons";
                break;
            case <= 12:
                measurment = $"{_quantity} Tablespoons";
                break;
            default:
                measurment = $"{_quantity} Cups";
                break;
        }
        return measurment;
    }

    public override string StringifyIngredient()
    {
        return $"{_name}~{_quantity}~{_type}";
    }
}