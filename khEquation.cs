// Purpose: the purpose of the equation class is to make an equation to be calculated later in the program.
// It will give easy access to the equation's contents while keeping it seperate from the program itself.
// This class was not on my plan, but I felt it was necessary to add.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements | Learning about the benifits of the switch method.
// https://sl.bing.net/gsbQoCK33cG | Help with the clearing of the equation.
// https://learn.microsoft.com/en-us/dotnet/api/system.string.join?view=net-8.0 | Learning more about String.join.


class khEquation {
    private List<string> _khEquationList = new List<string>();
    private string _khEquationString;
    private bool _khEquationCorrect = false;
    private List<string> _khOperationsList = new List<string> { "+", "-", "x", "*", "/", "="};
    private List<string> _khUsedOperations = new List<string>();
    private int _khNumberOfOperators = 0;
    private int _khNumberOfNumbersInEquation = 0;

    // Constructs the calculator class.
    public khEquation() {
        do {
            KhMakeEquationList();
            KhCheckEquationList();
        } while(_khEquationCorrect == false);
    }

    // Makes an equation list for easy manipulation later.
private void KhMakeEquationList() {
    string khEquationPart = "none";
    _khNumberOfNumbersInEquation = 0;
    _khNumberOfOperators = 0;
    _khEquationString = "";
    do {
        Console.Clear();
        // Clear the console and ask for the next equation part.
        Console.WriteLine("--------------------------- Enter Equation ---------------------------");
        Console.WriteLine("--TIP: you'll be able to look over the equation before it's calculated");
        Console.WriteLine("--TIP: type \"=\" when you're done entering an equation");
        Console.WriteLine("--TIP: valid operation symbols are: +, -, x, *, /, =");
        Console.WriteLine("--TIP: type \"c\" if you've entered a mistake");
        Console.WriteLine("--TIP: type \"cl\" to clear the whole equation");
        Console.WriteLine("-----------------------------------------------------------------------");
        Console.WriteLine("Items in equation so far:");
        Console.WriteLine($"Numbers: {_khNumberOfNumbersInEquation} | Operaters: {_khNumberOfOperators} | Last Entered: {khEquationPart}");
        
        // Write different things to the terminal depending on run through.
        if (_khNumberOfNumbersInEquation == 0) {
            // Sets the equation string to nothing so none doesn't show up again.
            Console.WriteLine($"Equation: none");
        }
        else {
            Console.WriteLine($"Equation: {_khEquationString}");
        }

        Console.WriteLine();
        Console.Write("Enter a number or operation symbol (whole or rational): ");
        khEquationPart = Console.ReadLine().ToLower();
        
        switch (khEquationPart)
        {
            case "c":
                if (_khEquationList.Count > 0)
                {
                    
                    _khEquationList.RemoveAt(_khEquationList.Count - 1);
                    _khEquationString = string.Join(" ", _khEquationList);
                    _khEquationString += " ";
                }
                break;

            case "cl":
                _khEquationList.Clear();
                _khEquationString = "";
                _khNumberOfNumbersInEquation = 0;
                _khNumberOfOperators = 0;
                break;

            default:
                // If the user entered a number or operator
                // Add that part to the equation list.
                _khEquationList.Add(khEquationPart);
                _khEquationString += $"{khEquationPart} ";
                _khNumberOfNumbersInEquation += 1;

                // If the equation part is an operation, put it in the operations list.
                if (_khOperationsList.Contains(khEquationPart))
                {
                    _khUsedOperations.Add(khEquationPart);
                    _khNumberOfOperators += 1;
                    _khNumberOfNumbersInEquation -= 1;
                }
                break;
}

    } while(khEquationPart != "=");
    _khEquationString = _khEquationString.Trim();
    }



    // Turns the Equation List into a string so the user can validate it.
    private void KhCheckEquationList() {
            // Asks the user if the calculation is correct. Have them enter it again if not. 
            Console.Write($"Did you mean to put \"{_khEquationString}\"?: ");
            string khUserNumberResponse = Console.ReadLine();
            switch (khUserNumberResponse.ToLower()) {
                    case "y":
                    case "yes":
                    // Calls class to split equation so it can be passed into an operation.
                    _khEquationCorrect = true;
                    break;
                    case "n":
                    case "no":
                    // Has the user enter the right equation in.
                    _khEquationCorrect = false;
                    break;
                    default:
                    Console.WriteLine($"\"{khUserNumberResponse}\" is not a valid response. \"yes\" or \"no\" only (first letter accepted too).");
                    break;
            }
        }
        
    // Gets the operators used list
    public List<string> KhGetOperatorsList() {
        return _khUsedOperations;
    }
    
    // Gets the equation list
    public List<string> KhGetEquationList() {
        return _khEquationList;
    }

    public override string ToString()
    {
        return $"Equation: {_khEquationString}";
    }
}