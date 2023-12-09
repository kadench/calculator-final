// Purpose: the purpose of the file class is to save previous history to a list for reference. I will not be adding a load feature
// as you can look back to a previous file.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
// https://sl.bing.net/DzYVGoxCJU | Replacing invalid file characters for hyphens.
// https://youtu.be/fEY3AtYPWfc?si=cugI6P4hBQtiPBir | Help finding the folder directory.
// https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-write-text-to-a-file | Remembering how to write text to a file.
// https://sl.bing.net/iRil3X6BLJk | Asking for a faster and easier way to save a file. Helped me better understand how to save to a file.



class khFile {
    private string _khHistoryString;
    private List<string> _khHistoryList;
    private string _khFileName;
    private string _khSaveDestination;

    // The file's constructor. making the instance do something.
    public khFile(string khHistoryString) {
        khHistory khProgramHistory = khHistory.KhGetInstance();
        _khHistoryList = khProgramHistory.GetHistoryList();
        if (_khHistoryList.Count == 0) {
            Console.WriteLine();
            Console.WriteLine("You don't have any history to save.");
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
        }
        else {
        _khHistoryString = khHistoryString;
        _khSaveDestination = "C:\\Users\\garfu\\OneDrive\\Documents\\GitHub\\calculator-final\\saved-history";
        KhSetFileName();
        KhSaveFile();
        }
    }

    // Asks for the file name for the instance.
    private void KhSetFileName() {
        bool khFileNameCorrect = false;
        do {
            Console.WriteLine();
            Console.WriteLine("TIP: You cannot put spaces or [\\, /, :, *, ?, \", <, >, |] in your file name");
            Console.WriteLine("TIP: If you have no saved history, your file will be blank.");
            Console.Write("What do you want this file to be called? (.txt only): ");
            string khPotentialFileName = Console.ReadLine().Replace(" ", "-").Replace("\\", "-").Replace("/", "-").Replace(":", "-").Replace("*", "-").Replace("?", "-").Replace("<", "-").Replace(">", "-").Replace("|", "-");
            Console.Clear();
            Console.WriteLine($"--WARNING: If a file with the name {khPotentialFileName} exists in {_khFileName}, the contents of the old file will be overridden!");
            Console.Write($"Are you sure you want to call the new file {khPotentialFileName}? (y/n): ");
            string khUserResponse = Console.ReadLine().ToLower();
            if (khUserResponse == "y") {
                khFileNameCorrect  = true;
                _khFileName = khPotentialFileName;
            }
            else if (khUserResponse == "n") {
                khFileNameCorrect  = false;
            }
            else {
                Console.WriteLine($"\"{khUserResponse}\" didn't match the expected output. Try again.");
                Console.Write("Press enter to continue: ");
                Console.ReadLine();
            }

        } while(khFileNameCorrect == false);
    }
    
    // Saves the history ToString to the file of the users choice.
    public void KhSaveFile() {
            string khFullPath = Path.Combine(_khSaveDestination, _khFileName);
            File.WriteAllText(khFullPath, _khHistoryString);
            Console.WriteLine($"File saved at {khFullPath}");
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
    }
}
