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
// https://www.tutorialspoint.com/How-to-calculate-the-length-of-the-string-using-Chash#:~:text=Use%20the%20String.,the%20length%20of%20the%20string. | How to get string lrngth


class khEquation {
    private List<double> _khNumbersList;
    private string _khEquationString;
    private bool _khEquationCorrect;
    private List<string> _khOperationsList;
    private List<string> _khUsedOperations;
    private int _khNumberOfOperators;
    private int _khNumberOfNumbersInEquation;

    // Constructs the calculator class. (Calls and brings the methods together)
    public khEquation() {
        // Setting the attributes
        _khNumbersList = new List<double>();
        _khEquationCorrect = false;
        _khOperationsList = new List<string>{"+", "-", "x", "*", "/", "="};
        _khUsedOperations = new List<string>();
        _khNumberOfOperators = 0;
        _khNumberOfNumbersInEquation = 0;
        
        // Creating the equation
        do {
            KhMakeEquation();
            KhEquationCheck();
        } while(_khEquationCorrect == false);
    }

    // Starts the equation making process
    private void KhMakeEquation() {
    string khEquationPart = "none";
    do {
        KhPrintMenu(khEquationPart);
        khEquationPart = Console.ReadLine();
        KhProcessInput(khEquationPart);
    } while (khEquationPart != "=");
}

    // Writes the equation menu.
    private void KhPrintMenu(string khEquationPart) {
        Console.Clear();
        Console.WriteLine("--------------------------- Enter Equation ---------------------------------");
        Console.WriteLine("--TIP: Please enter one item at a time or it will not recognize the input.");
        Console.WriteLine("--TIP: you'll be able to look over the equation before it's calculated.");
        Console.WriteLine("--TIP: valid operation symbols are: +, -, x, *, /, =.");
        Console.WriteLine("--TIP: type \"cl\" to clear the whole equation.");
        Console.WriteLine("--TIP: type \"c\" if you've entered a mistake. This will not delete operators.");
        Console.WriteLine("--TIP: type \"=\" when you're done entering an equation.");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Items in equation so far:");
        Console.WriteLine($"Numbers: {_khNumberOfNumbersInEquation} | Operaters: {_khNumberOfOperators} | Last Entered: {khEquationPart}");
        
        if (_khNumberOfNumbersInEquation == 0) {
            Console.WriteLine($"Equation: none");
        }
        else {
            Console.WriteLine($"Equation: {_khEquationString}");
        }

        Console.WriteLine();
        Console.Write("Enter a number or operation symbol (whole or rational): ");
    }

    // Processes the input of the user.
    private void KhProcessInput(string khEquationPart) {
        switch (khEquationPart)
        {
            case "c":
                KhRemoveLastNumber();
                break;
            case "cl":
                KhClearEquation();
                break;
            case "+":
            case "-":
            case "x":
            case "*":
            case "/":
                KhAddOperator(khEquationPart);
                break;
            default:
                KhAddNumber(khEquationPart);
                break;
        }
    }

    // Clears the last NUMBER from the equation. Does not delete any operation.
    private void KhRemoveLastNumber() {
        // Setting the number length so that the number can be deleted fully.
        int khDeleteToIndex = _khNumbersList[_khNumbersList.Count - 1].ToString().Length + 1;
        int khInitialLength = _khEquationString.Length;

        // Making sure that the last character in the equation string is not an operator. If so, do nothing.
        if (_khEquationString.Length > 0 && _khEquationString.EndsWith(" ") && !_khOperationsList.Contains(_khEquationString[_khEquationString.Length - 2].ToString())) {
            
            // Deletes the number from the equation string based on length of the last number in the numbers' list.
            for (int i = khInitialLength; i > khInitialLength - khDeleteToIndex; i--) {
                _khEquationString = _khEquationString.Remove(_khEquationString.Length - 1);
            }
            _khNumberOfNumbersInEquation -= 1;
            _khNumbersList.RemoveAt(_khNumbersList.Count - 1);
        }
    }

    // Clears the equation completely.
    private void KhClearEquation() {
        _khNumbersList.Clear();
        _khUsedOperations.Clear();
        _khEquationString = "";
        _khNumberOfOperators = _khUsedOperations.Count;
        _khNumberOfNumbersInEquation = _khNumbersList.Count;
    }

    // Adds an operator to the equation.
    private void KhAddOperator(string khEquationPart) {
        _khUsedOperations.Add(khEquationPart);
        _khNumberOfOperators += 1;
        _khEquationString += $"{khEquationPart} ";
    }

    // Checks if the equation is valid.
    private bool KhEquationValidator() {
        bool endsWithOperation = false;
        foreach (string khOperation in _khUsedOperations)
        {
            if (_khEquationString.EndsWith(khOperation)) {
                endsWithOperation = true;
            }
            if (_khUsedOperations.Count > 1) {
                endsWithOperation = true;
            }
        }
        return endsWithOperation;
    }

    // Adds a number to the equation list.
    private void KhAddNumber(string khEquationPart) {
        double khEquationPartToDouble;
        if (double.TryParse(khEquationPart, out khEquationPartToDouble)){
            _khNumbersList.Add(khEquationPartToDouble);
            _khEquationString += $"{khEquationPart} ";
            _khNumberOfNumbersInEquation += 1;
        }
    }

    // Writes the equation string to the terminal so the user can validate it.
    private void KhEquationCheck() {
        _khEquationString = _khEquationString.Trim();
        bool khEndWithOperator = KhEquationValidator();
        
        // Only runs this part if the equation doesn't end in an operatiom. 
        if (khEndWithOperator == false) {
            
            // Asks the user if the calculation is correct. Have them enter it again if not.
            Console.Clear();
            Console.WriteLine("The equation you typed in:");
            Console.Write($"Did you mean to put \"{_khEquationString}\"?: ");
            string khUserNumberResponse = Console.ReadLine();
            switch (khUserNumberResponse.ToLower()) {
                    case "y":
                    case "yes":
                    // Lets the equation pass.
                    _khEquationCorrect = true;
                    break;
                    case "n":
                    case "no":
                    // Resets equations stats to have the user enter in a fixed equation.
                    _khEquationCorrect = false;
                    KhClearEquation();
                    Console.WriteLine("That's ok. Try again.");
                    Console.Write("Press enter to continue: ");
                    Console.ReadLine();
                    break;
                    default:
                    Console.WriteLine($"\"{khUserNumberResponse}\" is not a valid response. \"yes\" or \"no\" only (first letter accepted too).");
                    KhClearEquation();
                    break;
            }
        }
        else {
            Console.WriteLine("Your equation is too long (1 operator max) or ends in an operator. Try again.");
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
        }
                    
        
    }
        
    // Gets the operators used list.
    public List<string> KhGetOperatorsList() {
        return _khUsedOperations;
    }
    
    // Gets the numbers list.
    public List<double> KhGetNumbersList() {
        return _khNumbersList;
    }

    // Returns the raw equation string.
    public string KhGetEquationString() {
        return _khEquationString;
    }
    
    // Returns the tostring of the equation instance.
    public override string ToString()
    {
        return $"Equation: {_khEquationString}";
    }
}