public class Cookbook
{
    private string _bookName;
    private string _saveFile;
    private List<Recipe> _recipies = new List<Recipe>();

    public Cookbook()
    {

    }

    public Cookbook(string name, string saveLocation)
    {
        _bookName = name;
        _saveFile = saveLocation;
    }

    public void DisplayRecipies()
    {
        int counter = 1;
        foreach(Recipe recipe in _recipies)
        {
            Console.Write($"{counter}. ");
            recipe.DisplayRecipeTitle();
            counter ++;
        }
    }

    public void SelectRecipe()
    {
        DisplayRecipies();
        Console.WriteLine();
        Console.Write("Which Recipe would you like to follow? ");
        int userInput = Int32.Parse(Console.ReadLine());
        _recipies[userInput - 1].FollowRecipe();
        _recipies[userInput - 1].UnfollowRecipe();
    }

    public void DeleteRecipe()
    {
        DisplayRecipies();
        Console.WriteLine();
        Console.Write("Which Recipe would you like to Delete? ");
        int userInput = Int32.Parse(Console.ReadLine());
        _recipies.RemoveAt(userInput - 1);
    }

    public void AddRecipe()
    {
        Recipe recipe = new Recipe();
        _recipies.Add(recipe);
    }

    public void SaveCookbook()
    {
        Console.Clear();
        Console.WriteLine("Saving cookbook...");
        using (StreamWriter outputFile = new StreamWriter(_saveFile))
        {
            outputFile.WriteLine($"{_bookName}|{_saveFile}");
            foreach(Recipe recipe in _recipies)
            {
                outputFile.WriteLine(recipe.StringifyRecipe());
            }
        }
    }

    public void LoadCookbook(string name, string saveFile)
    {
        string[] cookbook = System.IO.File.ReadAllLines(saveFile);
        //deals with the info for the cookbook itself, stored on line one.
        _bookName = name;
        _saveFile = saveFile;

        //adds the recepies, each recipe is stored on a single line. 
        //They're split up into 3 main parts by '|'
        //  1.) info about the recipe (recipe title)
        //  2.) the list of ingredients
        //      a.) each ingredient is separated by a '+'
        //      b.) the info within the ingredient is separated by a '~'
        //  3.) the list of instructions. (separated by '~')
        foreach(string recipeLine in cookbook.Skip(1))
        {
            string[] parts = recipeLine.Split("|");
            string recipeName = parts[0];

            string[] ingredients = parts[1].Split("+");
            string[] instructions = parts[2].Split("~");

            Recipe recipe = new Recipe(recipeName,ingredients,instructions);
            _recipies.Add(recipe);
        }
    }
}