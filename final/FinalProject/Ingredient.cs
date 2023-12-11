public class Ingredient
// This is for random whole units of cooking measurment, ex. chicken breast, 2 apples,
// 1 pinch, ect.
{
    protected string _name;
    protected double _quantity;

    public Ingredient()
    {
        SetName();
        SetQuantity();
    }

    public Ingredient(double quantity, string name)
    {
        _quantity = quantity;
        _name = name;
    }

    public void SetName()
    {
        Console.Clear();
        Console.WriteLine("What is the name of your ingredient?");
        _name = Console.ReadLine();
    }

    public virtual void SetQuantity()
    {
        Console.WriteLine($"How much {_name} will you have? (add .5 for half) ");
        _quantity = double.Parse(Console.ReadLine());
    }

    public virtual void DisplayIngredient()
    {
        Console.WriteLine($"{_quantity} {_name}");
    }

    public void ChangeServing(double factor)
    // changes the serving by the factor given.
    {
        _quantity *= factor;
    }

    public void ChangeServing()
    {
        Console.WriteLine("By how much would you like to change this serving? (0.5 for half, 2 for double)");
        double factor = double.Parse(Console.ReadLine());
        _quantity *= factor;
    }

    public virtual string StringifyIngredient()
    {
        return $"{_name}~{_quantity}";
    }
}