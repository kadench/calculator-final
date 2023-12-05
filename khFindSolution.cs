// Purpose: the purpose of the solution class is to take the items from an equation and calculate them for use later.
// It will give easy access to the solution data and will guide the numbers and operators where they need to go.
// This class, again, was not on my project plan, but I felt it was necessary to add as well.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
class khSolution {
    List<double> _khNumbersList;
    string _khOperator;
    List<object> _khSolutionList;
    double _khSolution;
    int _khSolutionParseIndex;

    // Constructs the solution class.
    public khSolution(List<double> khNumbersList, List<string> khOperatorsList) {
        // Sets the attributes
        _khNumbersList = khNumbersList;
        _khOperator = khOperatorsList[0];
        _khSolutionParseIndex = 0;

        // Finds the solution based on the information in the above lists.
        KhParseEquationToSolve(_khOperator);
        KhCall
    }

    private void KhParseEquationToSolve(string khOperator) {
        if (_khNumbersList.Count >= 2) {
            // Gets the first two numbers in the numbers list for the equation
            double khNumber1 = _khNumbersList[0 + _khSolutionParseIndex];
            double khNumber2 = _khNumbersList[1 + _khSolutionParseIndex];
            _khNumbersList.RemoveAt(0);
            _khNumbersList.RemoveAt(0);
            _khSolutionList.Add(khNumber1);
            _khSolutionList.Add(khOperator);
            _khSolutionList.Add(khNumber2);
            _khSolutionParseIndex += 1;
        }
        
    }
}   
