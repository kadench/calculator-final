// Purpose: the purpose of the file class is to save previous history to a list for reference. I will not be adding a load feature
// as you can look back to a previous file.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
class khFile {
    private string _khHistoryString;
    private string _khFileName;
    private string _khSaveDestination;

    // The file's constructer
    public khFile(string history_string) {
        Console.WriteLine("The file system hasn't been implemented yet.");
        Console.WriteLine("I have only included the methods and constructers I gave myself with the template.");
        Console.Write("Press enter to continue: ");
        Console.ReadLine();
    }

    private void KhSetFileName() {

    }

    private string GetFileName() {
        return _khFileName;
    }

    private void SetSaveDestination() {

    }

    public string GetSaveDestination() {
        return _khSaveDestination;
    }

    public void SaveFile() {

    }

    public override string ToString()
    {
        return "";
    }

}