// Purpose: the purpose of program is to run the "calculator", meaning to guide the information with it's
// datatypes to the correct position. This program class will act as the start to the calculator progrom,
// but will not do any sort of manipulation of data for a new result.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/discussion_topics/7606166 | Formatting the program and the comment block.
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.
// https://github.com/kadench/polymorphism-development-project/blob/main/program.cs | Remembering how to do the while loop for
// the guiding of the program with the user's chosen action.
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements | Learning about the benifits of the switch method.
// https://youtu.be/Qu93CRt-FGc?si=zJT7hEYTu_8Kth-r | An example of a switch case being used. Explained how to return multiple things.
// https://sl.bing.net/d60Hbq7xh2y | Asking about scope and the use of static variables in program that effect its running.

using System;

class khProgram {
        // Static attribute controls if the program should continue or not. Allows for easy and wide change.
        static bool khProgramDone = false;

        // Runs the calculator program.
        static void Main(string[] args) {
                Console.Clear();
                // Prints the introduction to the terminal.
                KhPrintStartingMessage();
                // Creates one history instance to be used at any point in the program.
                khHistory khProgramHistory = khHistory.KhGetInstance();
                // Prints the calculator menu to the terminal.
                do {
                        Console.Clear();
                        // Asks for the user's choice.
                        KhPrintCalculatorMenu();
                        string khUsersChoice = KhGetUserMenuAction();
                        // Calls the right class to do the right action.
                        KhCallClass(khUsersChoice);
                }while (khProgramDone == false);
        }

        // Writes the program's starting message to the terminal.
        static void KhPrintStartingMessage() {
                Console.WriteLine("---------- Welcome to the Calculator. ----------");
                Console.WriteLine("You will be able to do simple equations and save");
                Console.WriteLine("the answers in a new file. (if you so choose to)");
                Console.WriteLine("------------------------------------------------");
                Console.Write("Press enter to continue to the calculator: ");
                Console.ReadLine();
                Console.Clear();
        }

        // Prints the program's calculator menu for the user. (There is a delay for each writeline to add a cool effect.)
        static void KhPrintCalculatorMenu() {
                Console.WriteLine("--- Calculator Menu ---");
                Console.WriteLine("1. Enter an equation");
                Console.WriteLine("2. View History");
                Console.WriteLine("3. Save History");
                Console.WriteLine("4. Clear History");
                Console.WriteLine("-----------------------");
        }

        // Asks for the user's requested action.
        static string KhGetUserMenuAction() {
                
                Console.Write("Action: ");
                string khUsersChoice = Console.ReadLine();
                return khUsersChoice;
        }
        
        // Creates or calls the correct class instance in the calculator based on the user's choice. 
        static bool KhCallClass(string khUsersChoice) {
                bool khMethodCalled = false;
                do {
                        switch (khUsersChoice.ToLower()) {
                                case "equation":
                                case "e":
                                case "1":
                                        // Makes the equation to solve.
                                        khEquation khMadeEquation = KhNewEquation();
                                        List<double> khUsedNumbers = khMadeEquation.KhGetNumbersList();
                                        List<string> khUsedOperators = khMadeEquation.KhGetOperatorsList();

                                        // Takes the equation information and calls the right operation
                                        // khSolution khNewSolution = KhSolveEquation(khUsedNumbers, khUsedOperators);
                                        KhSaveItem(khMadeEquation);
                                        khMethodCalled = true;
                                        break;
                                case "vh":
                                case "view":
                                case "2":
                                case "view history":
                                        // Call the method for viewing history
                                        khHistory khProgramHistory = khHistory.KhGetInstance();
                                        Console.WriteLine(khProgramHistory.ToString());
                                        khMethodCalled = true;
                                        break;
                                case "sh":
                                case "save":
                                case "3":
                                case "save history":
                                        // Call the method for saving history
                                        Console.WriteLine("Worked.");
                                        khMethodCalled = true;
                                        break;
                                case "ch":
                                case "clear":
                                case "4":
                                case "clear history":
                                        // Call the method for clearing history
                                        Console.WriteLine("Worked.");
                                        khMethodCalled = true;
                                        break;
                                case "quit":
                                case "q":
                                case "5":
                                        bool khUserQuitAnswer = KhQuitConfirmation();
                                        khMethodCalled = true;
                                        if (khUserQuitAnswer == true) {
                                                khProgramDone = true;
                                        }
                                        break;
                                default:
                                Console.WriteLine("Invalid input. Please try again.");
                                break;
                        }
                } while(!khMethodCalled == true);
                return khMethodCalled;
        }

        // Makes a new equation and returns it to KhCallClass
        static khEquation KhNewEquation() {
                khEquation khNewEquation = new khEquation();
                return khNewEquation;
        }

        // Saves the history to the history instance for that program.
        static void KhSaveItem(khEquation khSaveItem) {
                khHistory khProgramHistory = khHistory.KhGetInstance();
                khProgramHistory.KhUpdateHistoryList(khSaveItem.ToString());
        }

        // Writes the quit warning message to the user.
        static bool KhQuitConfirmation() {
                bool khQuitQestionAnswered = false;
                bool khUserQuitAnswer = false;
                Console.WriteLine("All unsaved history will be lost.");
                do {
                Console.Write("Are you sure you want to quit the program?: ");
                string khUserAnswer = Console.ReadLine().ToLower();
                switch (khUserAnswer) {
                        case "y":
                        case "yes":
                                khUserQuitAnswer = true;
                                break;
                        case "n":
                        case "no":
                                khUserQuitAnswer = false;
                                break;
                        default:
                                Console.WriteLine($"\"{khUserAnswer}\" is an invalid response. Try again.");
                        break;
                }
                } while(khQuitQestionAnswered == false);
                return khUserQuitAnswer;
        }

}