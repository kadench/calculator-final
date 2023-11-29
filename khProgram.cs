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

using System;

class khProgram {
        // Runs the calculator program.
        static void Main(string[] args) {
                // Prints the introduction to the terminal.
                KhPrintStartingMessage();
                // Prints the calculator menu to the terminal.
                KhPrintCalculatorMenu();
                // Asks for the user's choice.
                string khUsersChoice = KhGetUserMenuAction();
                // Calls the right class to do the right action.
                KhCallClass(khUsersChoice);

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

        // Prints the program's calculator menu for the user.
        static void KhPrintCalculatorMenu() {
                Thread.Sleep(100);
                Console.WriteLine("--- Calculator Menu ---");
                Thread.Sleep(100);
                Console.WriteLine("1. Enter an equation");
                Thread.Sleep(100);
                Console.WriteLine("2. View History");
                Thread.Sleep(100);
                Console.WriteLine("3. Save History");
                Thread.Sleep(100);
                Console.WriteLine("4. Clear History");
                Thread.Sleep(100);
                Console.WriteLine("-----------------------");
                Thread.Sleep(100);
        }

        // Asks for the user's requested action.
        static string KhGetUserMenuAction() {
                
                Console.Write("Action: ");
                string khUsersChoice = Console.ReadLine();
                return khUsersChoice;
        }
        
        // Creates or calls the correct class instance in the calculator based on the user's choice. 
        static void KhCallClass(string khUsersChoice) {
                // Create string arrays that have the strings that will trigger the certain action.
                string[] khAcceptableEquationStrings = {"equation", "e", "", "1", "enter an equation"};
                string[] khAcceptableViewHistoryStrings = {"vh", "view", "2", "view history"};
                string[] khAcceptableSaveHistoryStrings = {"sh", "save", "3", "save history"};
                string[] khAcceptableClearHistoryStrings = {"ch", "clear", "4", "clear history"};

                // If statements to bring the user where they want to go based on the above trigger
                // strings.
                if (khAcceptableEquationStrings.Contains(khUsersChoice)) {
                        // Print the operations menu
                        // KhPrintOperationsMenu();
                        // string KhUserChoice = KhGetUserOperationsMenuChoice();
                        // Calls the correct operation child class.
                        // KhCallOperation();
                }
                else if (khAcceptableViewHistoryStrings.Contains(khUsersChoice)) {
                        
                }
        }
}