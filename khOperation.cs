// Purpose: the purpose of the operations class is a parent abstract class. It builds similarities, but allows polymorphism with its
// children: addition, subtraction, multiplication, and division.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
abstract class khOperation {
    protected List<double> _khNumberList;

    // The Operations's constructer
    public khOperation() {
        Console.WriteLine("The operation system hasn't been implemented yet.");
        Console.WriteLine("I have only included the methods and constructers I gave myself with the template.");
        Console.Write("Press enter to continue: ");
        Console.ReadLine();
    }

    protected abstract void KhDoOperation();

}