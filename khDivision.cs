// Purpose: the purpose of the additions class is to be a child to the operations class, which divides the given numbers.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.

class Division : khOperation {
    public Division(List<double> numbers) {
        _khNumberList = numbers;
        Console.WriteLine("The operation system hasn't been implemented yet and tested so this is made up for now, giving you an idea of what it may look like");
        Console.WriteLine("I have only included the methods and constructers I gave myself with the template.");
        Console.Write("Press enter to continue: ");
    }

    protected override void KhDoOperation() {
        double quotient = _khNumberList[0];
        for (int i = 1; i < _khNumberList.Count; i++) {
            if (_khNumberList[i] != 0) {
                quotient /= _khNumberList[i];
            } else {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }
        }
        Console.WriteLine("The quotient is: " + quotient);
    }
}