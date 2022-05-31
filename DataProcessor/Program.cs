using System;
using static System.Console;

namespace DataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Parsing command line options");

            var command = args[0]; //especificamos al usuario --archivo o --dir

            if (command == "--file")
            {
                var filePath = args[1];
                //Check if path is absolute
                if (!Path.IsPathFullyQualified(filePath))
                {
                    WriteLine($"ERROR: path '{filePath}' must be fully qualified.");
                    ReadLine();
                    return;
                }

                WriteLine($"Single file {filePath} selected");
                ProcessSingleFile(filePath);
            }
            else if (command == "--dir")
            {
                var directoryPath = args[1];
                var fileType = args[2];
                WriteLine($"Directory {directoryPath} selected for {fileType} files");
                ProcessDirectory(directoryPath, fileType);
            }
            else
            {
                WriteLine("Invalid command line options");
            }
            WriteLine("Press enter to quit.");
            ReadLine();
        }

        private static void ProcessSingleFile(string filePath)
        {
            var fileProcessor = new FileProcessor(filePath);
            fileProcessor.Process();
        }

        private static void ProcessDirectory(string directoryPath, string fileType)
        {

        }
    }
}

