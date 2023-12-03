// Purpose: the purpose of the additions class is to be a child to the operations class, which adds the given numbers together.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
class Addition : khOperation {
    public Addition(List<double> numbers) {
        _khNumberList = numbers;
        Console.WriteLine("The operation system hasn't been implemented yet and tested so this is made up for now, giving you an idea of what it may look like");
        Console.WriteLine("I have only included the methods and constructers I gave myself with the template.");
        Console.Write("Press enter to continue: ");
        Console.ReadLine();
    }

    protected override void KhDoOperation() {
        double sum = 0;
        foreach (double num in _khNumberList) {
            sum += num;
        }
        Console.WriteLine("The sum is:", sum);
    }
}