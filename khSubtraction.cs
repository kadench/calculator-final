// Purpose: the purpose of the additions class is to be a child to the operations class, which subtracts the given numbers together.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
// Emma helped me realize I needed the base class to construct the children.

class khSubtraction : khOperation {
    
    // Constructer that sets up the instance to be subtracted from.
    public khSubtraction(List<double> khNumbersList) : base(khNumbersList) {
        _khNumber1 = khNumbersList[0];
        _khNumber2 = khNumbersList[1];
        KhDoOperation();
    }

    // Subtracts the two numbers to find the solution.
    protected override void KhDoOperation() {
        _khSolution = _khNumber1 - _khNumber2;
    }

    // Returns the solution as a double to be added up later.
    public double GetSolution() {
        return _khSolution;
    }

    // Returns the ToString of the subtraction class,
    public override string ToString()
    {
        return $"{_khSolution}";
    }
}