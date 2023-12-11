public class Recipe
{
    private string _title;
    private List<Ingredient> _ingredeients = new List<Ingredient>();
    private List<Instruction> _instructions = new List<Instruction>();

    public Recipe()
    {
        bool conditionsMet = false;
        string userInput = "";

        Console.Clear();
        Console.WriteLine("To add a recipe, first give the recipe a title, then add all the ingredients to the recipe, then add all the steps to complete.");
        Console.WriteLine();
        Console.WriteLine("What do you want to call your recipe? ");
        _title = Console.ReadLine();

        //add ingredients
        while (!conditionsMet)
        {
            Console.Clear();
            Console.WriteLine("Add ingredient? ");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                AddIngredient();
            }
            else if (userInput == "2")
            {
                conditionsMet = true;
            }
            else
            {
                Console.WriteLine("Please select a valid option");
            }
        }

        conditionsMet = false;

        // add instructions.
        while(!conditionsMet)
        {
            Console.Clear();
            Console.WriteLine("Add instruction? ");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                AddInstruction();
            }
            else if (userInput == "2")
            {
                conditionsMet = true;
            }
            else
            {
                Console.WriteLine("Please select a valid option");
            }
        }
    }

    public Recipe(string name, string[] ingredients, string[] instructions)
    {
        _title = name;

        foreach(string ingredient in ingredients)
        {
            string[] ingredientParts = ingredient.Split("~");
            if (ingredientParts.Length > 1)
            {
                string ingredientName = ingredientParts[0];
                double ingredientQuantity = double.Parse(ingredientParts[1]);
                if(ingredientParts.Length == 3)
                {
                    string ingredientType = ingredientParts[2];
                    MeasuredIngredient m = new MeasuredIngredient(ingredientQuantity, ingredientName,ingredientType);
                    _ingredeients.Add(m);
                }
                else
                {
                    Ingredient i = new Ingredient(ingredientQuantity, ingredientName);
                    _ingredeients.Add(i);
                }
                //_ingredeients.RemoveAt(_ingredeients.Count - 1);
            }   
        }

        foreach(string step in instructions)
        {
            if(step.Length > 0)
            {
                Instruction instruction = new Instruction(step);
                _instructions.Add(instruction);
            }
        }
    }

    public void FollowRecipe()
    {
        DisplayRecipe();
        Console.WriteLine();
        Console.WriteLine("press enter to start recipe");
        Console.ReadLine();
        GatherIngredients();
        FollowSteps();
    }

    public void GatherIngredients()
    {
        Console.Clear();
        Console.WriteLine("Gather the following Ingredients");
        Console.WriteLine();
        DisplayIngredients();
        Console.WriteLine();
        Console.WriteLine("Press enter when they are all gathered.");
        Console.ReadLine();
    }

    public void FollowSteps()
    {
        bool stepsCompleted = false;
        while(!stepsCompleted)
        {
            Console.Clear();
            DisplayIngredients();
            Console.WriteLine("====================================================================");
            foreach(Instruction instruction in _instructions)
            {
                if(instruction.CheckCompleted())
                {
                    stepsCompleted = true;
                    instruction.DisplayInstruction();
                }
                else
                {
                    stepsCompleted = false;
                    instruction.DisplayInstruction();
                    Console.WriteLine();
                    Console.WriteLine("Press enter when you complete the step.");
                    Console.ReadLine();
                    instruction.CompleteStep();
                    break;
                }
            }
        }
    }

    public void UnfollowRecipe()
    {
        foreach(Instruction instruction in _instructions)
        {
            instruction.UncompleteStep();
        }
    }

    public void DisplayIngredients()
    {
        int ingCounter = 1;
        foreach(Ingredient ingredient in _ingredeients)
        {
            Console.Write($"{ingCounter}.) ");
            ingredient.DisplayIngredient();
            ingCounter ++;
        }
    }

    public void DisplayInstructions()
    {
        int insCounter = 1;
        foreach(Instruction instruction in _instructions)
        {
            Console.Write($"{insCounter}.) ");
            instruction.DisplayInstruction();
            insCounter ++;
        }
    }

    public void DisplayRecipe()
    {
        DisplayIngredients();
        Console.WriteLine("====================================================================");
        DisplayInstructions();
    }

    public void DisplayRecipeTitle()
    {
        Console.WriteLine(_title);
    }

    public void AddIngredient()
    {
        string userInput = "";

        bool conditionsMet = false;     
        while(!conditionsMet)
        {
            Console.Clear();
            Console.WriteLine($"How is this ingredient measured? ");
            Console.WriteLine("1. Cup");
            Console.WriteLine("2. Tablespoon");
            Console.WriteLine("3. Teaspoon");
            Console.WriteLine("4. Other");
            Console.WriteLine("5. Quit opperation");
            userInput = Console.ReadLine();

            // use a switch to differentiate between the types of classes it could be.
            switch (userInput)
            {
                case "1":
                    conditionsMet = true;
                    MeasuredIngredient measuredIngredient = new MeasuredIngredient(userInput);
                    _ingredeients.Add(measuredIngredient);
                    break;
                case "2":
                    goto case "1";
                case "3":
                    goto case "1";
                case "4":
                    conditionsMet = true;
                    Ingredient ingredient = new Ingredient();
                    _ingredeients.Add(ingredient);
                    break;
                case "5":
                    conditionsMet = true;
                    break;
            }
        }
    }

    public void AddInstruction()
    {
        string userInput = "";
        
        Console.WriteLine("Type in the step of the cookbook.");
        userInput = Console.ReadLine();
        Instruction instruction = new Instruction(userInput);
        _instructions.Add(instruction);
    }

    public string StringifyRecipe()
    {
        string recipe = $"{_title}|";
        foreach(Ingredient ingredient in _ingredeients)
        {
            recipe += ingredient.StringifyIngredient();
            recipe += "+";
        }
        recipe += "|";
        foreach(Instruction instruction in _instructions)
        {
            recipe += instruction.StringifyInstruction();
            recipe += "~";
        }
        return recipe;
    }
}