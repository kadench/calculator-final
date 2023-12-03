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
// https://youtu.be/Qu93CRt-FGc?si=zJT7hEYTu_8Kth-r | An example of a switch case being used.

using System;

class khProgram {
        // Runs the calculator program.
        static void Main(string[] args) {
                Console.Clear();
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

        // Prints the program's calculator menu for the user. (There is a delay for each writeline to add a cool effect.)
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
                bool khMethodCalled = false;
                do {
                        switch (khUsersChoice.ToLower()) {
                                case "equation":
                                case "e":
                                case "1":
                                // Call the class for entering an equation
                                khEquation khNewEquation = new khEquation();
                                khNewEquation.KhGetEquationList();
                                khNewEquation.KhGetOperatorsList();
                                khMethodCalled = true;
                                break;
                                case "vh":
                                case "view":
                                case "2":
                                case "view history":
                                // Call the method for viewing history
                                Console.WriteLine("Worked.");
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
                                default:
                                Console.WriteLine("Invalid input. Please try again.");
                                break;
                        }
                } while(!khMethodCalled == true);
        }

        

}