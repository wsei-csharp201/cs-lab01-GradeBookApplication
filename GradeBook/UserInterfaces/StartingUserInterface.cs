﻿using GradeBook.GradeBooks;
using System;

namespace GradeBook.UserInterfaces
{
    public static class StartingUserInterface
    {
        public static bool Quit = false;
        public static void CommandLoop()
        {
            while (!Quit)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine(">> What would you like to do?");
                var command = Console.ReadLine().ToLower();
                CommandRoute(command);
            }
        }

        public static void CommandRoute(string command)
        {
            if (command.StartsWith("create"))
                CreateCommand(command);
            else if (command.StartsWith("load"))
                LoadCommand(command);
            else if (command == "help")
                HelpCommand();
            else if (command == "quit")
                Quit = true;
            else
                Console.WriteLine("{0} was not recognized, please try again.", command);
        }

        public static void CreateCommand(string command)
        {
            var parts = command.Split(' ');
            if (parts.Length != 4)
            {
                Console.WriteLine("Command not valid, Create requires a name, type of gradebook, if it's weighted (true / false).");
                return;
            }
            var name = parts[1];
            if (parts[2] == "standard" && parts[3] == "true")
            {
                BaseGradeBook gradeBook = new StandardGradeBook(name, true);
                GradeBookUserInterface.CommandLoop(gradeBook);
            }
            else if (parts[2] == "ranked" && parts[3] == "true")
            {
                BaseGradeBook gradeBook = new RankedGradeBook(name, true);
                GradeBookUserInterface.CommandLoop(gradeBook);
            }
            else if (parts[2] == "standard" && parts[3] == "false")
            {
                BaseGradeBook gradeBook = new StandardGradeBook(name, false);
                GradeBookUserInterface.CommandLoop(gradeBook);
            }
            else if (parts[2] == "ranked" && parts[3] == "false")
            {
                BaseGradeBook gradeBook = new RankedGradeBook(name, false);
                GradeBookUserInterface.CommandLoop(gradeBook);
            }
            else
            {
                Console.WriteLine($"{parts[2]} is not a supported type of gradebook, please try again");
                return;
            }

            Console.WriteLine("Created gradebook {0}.", name);
        }

        public static void LoadCommand(string command)
        {
            var parts = command.Split(' ');
            if (parts.Length != 2)
            {
                Console.WriteLine("Command not valid, Load requires a name.");
                return;
            }
            var name = parts[1];
            var gradeBook = BaseGradeBook.Load(name);

            if (gradeBook == null)
                return;

            GradeBookUserInterface.CommandLoop(gradeBook);
        }

        public static void HelpCommand()
        {
            Console.WriteLine();
            Console.WriteLine("GradeBook accepts the following commands:");
            Console.WriteLine();
            Console.WriteLine("Create 'Name' 'Type' 'Weighted' - Creates a new gradebook where 'Name' is the name of the gradebook, 'Type' is what type of grading it should use, and 'Weighted' is whether or not grades should be weighted (true or false).");
            Console.WriteLine();
            Console.WriteLine("Load 'Name' - Loads the gradebook with the provided 'Name'.");
            Console.WriteLine();
            Console.WriteLine("Help - Displays all accepted commands.");
            Console.WriteLine();
            Console.WriteLine("Quit - Exits the application");
        }
    }
}
