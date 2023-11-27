// Purpose: the purpose of program is to run the program and guide the information with it's datatypes to its correct
// position. This program class will act as the start to the calculator progrom, but will not do any sort of
// manipulation of data.
// Authorship: Written and planned out by Kaden Hansen.
// Copyright (date): Kaden Hansen 12/09/23
// Sources:
// https://byui.instructure.com/courses/249838/discussion_topics/7606166 | Formatting the program and the comment block.
// https://byui.instructure.com/courses/249838/assignments/11893911?module_item_id=32704680 | Following the assignment's rubric.
// https://acrobat.adobe.com/id/urn:aaid:sc:US:5c0d42b8-a5c3-4502-9246-da8e9fb1445c | First draft of my project plan.

using System;

class khProgram {
        // Runs the calculator program.
        static void Main(string[] args) {
                // Call the "KhPrintStartingMessage()" method to print the program's starting message method.
                KhPrintStartingMessage();
        }

        // Writes the program's starting message to the terminal.
        static void KhPrintStartingMessage() {
                Console.WriteLine("---------- Welcome to the Calculator. ----------");
                Console.WriteLine("You will be able to do simple equations and save");
                Console.WriteLine("the answers in a new file. (if you so choose to)");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine();
        }
}