using System;
using static System.Console;

namespace DataProcessor
{
    class FileProcessor
    {
        public string InputFilePath { get; }

        public FileProcessor(string filePath) => InputFilePath = filePath;

        public void Process()
        {
            WriteLine($"Begin process of {InputFilePath}");
        }
    }
}
