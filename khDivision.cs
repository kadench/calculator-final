// Purpose: the purpose of the additions class is to be a child to the operations class, which divides the given numbers.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
// Emma helped me realize I needed the base class to construct the children.

class khDivision : khOperation {
    
    // The constructor for the division class that gets the two numbers from the passed in list. 
    public khDivision(List<double> khNumbersList) : base(khNumbersList) {
        _khNumber1 = khNumbersList[0];
        _khNumber2 = khNumbersList[1];
        KhDoOperation();
    }

    // Divides two numbers together.
    protected override void KhDoOperation() {
        if (_khNumber2 != 0) {
            _khSolution = _khNumber1 / _khNumber2;
        }
        else {
            Console.WriteLine("You cannot divide by zero!");
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
        }
    }

    // Returns the solution as a double to be added up later.
    public double GetSolution() {
        return _khSolution;
    }

    // Returns the ToString of the division class,
    public override string ToString()
    {
        return $"{_khSolution}";
    }
}