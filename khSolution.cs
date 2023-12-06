// Purpose: the purpose of the solution class is to take the items from an equation and calculate them for use later.
// It will give easy access to the solution data and will guide the numbers and operators where they need to go.
// This class, again, was not on my project plan, but I felt it was necessary to add as well.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
class khSolution {
    private List<double> _khNumbersList;
    private List<string> _khOperatorsList;
    private string _khOperator;
    private List<double> _khSolutionList;
    private double _khSolution;
    private double _khTemporarySolution;
    private string _khEquationString; 

    // Constructs the solution class.
    public khSolution(List<double> khNumbersList, List<string> khOperatorsList, string khEquationString) {
        // Sets the attributes
        _khNumbersList = khNumbersList;
        _khOperatorsList = khOperatorsList;
        _khEquationString = khEquationString;
        _khSolutionList = new List<double>{}; 

        // Finds the solution based on the information in the above lists.
        foreach (string khOperator in _khOperatorsList) {
            _khOperator = khOperator;
            KhParseEquationToSolve();
            KhCallOperation();
            KhAddToTotal();
        };
    }

    // takes the first two items from the list for a new calculation.
    private void KhParseEquationToSolve() {
        if (_khNumbersList.Count == 2) {
            
            // Gets the first two numbers in the numbers list for the equation
            double khNumber1 = _khNumbersList[0];
            double khNumber2 = _khNumbersList[1];
            _khNumbersList.RemoveAt(0);
            _khSolutionList.Add(khNumber1);
            _khSolutionList.Add(khNumber2);
        }
    }

    // Calls the right operation based on the 
    private void KhCallOperation() {
        double khRealSolution;
        switch (_khOperator) {
            case "*":
            case "x":
                khRealSolution = KhMultiplyNumbers();
                _khTemporarySolution = khRealSolution;
                break;
            case "/":
                khRealSolution = KhDivideNumbers();
                _khTemporarySolution = khRealSolution;
                break;
            case "+":
                khRealSolution = KhAddNumbers();
                _khTemporarySolution = khRealSolution;
                break;
            case "-":
                khRealSolution = KhSubtractNumbers();
                _khTemporarySolution = khRealSolution;
                break;
            default:
                _khTemporarySolution = 0;
                break;
            
        }
    }
    
    // Creates a new multiplication class for the solution.
    private double KhMultiplyNumbers() {
        khMultiplication khNewSolution = new khMultiplication(_khSolutionList);
        return khNewSolution.GetSolution();
    }
    
    // Creates a new division class for the solution.
    private double KhDivideNumbers() {
        khDivision khNewSolution = new khDivision(_khSolutionList);
        return khNewSolution.GetSolution();
    }
    
    // Creates a new addition class for the solution.
    private double KhAddNumbers() {
        khAddition khNewSolution = new khAddition(_khSolutionList);
        return khNewSolution.GetSolution();
    }
    
    // Creates a new subtraction class for the solution.
    private double KhSubtractNumbers() {
        khSubtraction khNewSolution = new khSubtraction(_khSolutionList);
        return khNewSolution.GetSolution();
    }

    // Adds all of the equations' solutions to one solution.
    private void KhAddToTotal() {
        _khSolution += _khTemporarySolution;
    }

    public override string ToString()
    {
        return $"{_khEquationString} = {_khSolution}";
    }
}   
