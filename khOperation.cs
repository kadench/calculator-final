// Purpose: the purpose of the operations class is a parent abstract class. It builds similarities, but allows polymorphism with its
// children: addition, subtraction, multiplication, and division.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
abstract class khOperation {
    protected double _khNumber1;
    protected double _khNumber2;
    protected double _khSolution;

    // The Operation's constructor
    public khOperation(List<double> khNumbersList) {
        _khNumber1 = khNumbersList[0];
        _khNumber2 = khNumbersList[1];
    }

    // The abstract method that allows override of the child classes as they all do
    // different things.
    protected abstract void KhDoOperation();
}