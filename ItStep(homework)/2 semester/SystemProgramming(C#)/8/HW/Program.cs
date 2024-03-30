using LibraryDLL;
using static System.Console;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Task 1 - Testing FigureSquareCalc:");
            WriteLine($"Square of square with side 5: {FigureSquareCalc.SquareKv(5)}");
            WriteLine($"Square of rectangle with sides 4 and 6: {FigureSquareCalc.SquarePr(4, 6)}");
            WriteLine($"Square of triangle with sides 3, 4, and 5: {FigureSquareCalc.SquareTr(3, 4, 5)}");

            WriteLine();
            ReadKey();

            WriteLine("\nTask 2 - Testing TextWork:");
            WriteLine($"Is 'racecar' a palindrome? {TextWork.IsPalindrom("racecar")}");
            WriteLine($"Reverse of 'hello': {TextWork.GetReverse("hello")}");
            string text = "This is a test. It has two sentences.";
            WriteLine($"Number of sentences in '{text}': {TextWork.GetCountSentences(text)}");

            WriteLine();
            ReadKey();

            WriteLine("\nTask 3 - Testing FileWork:");
            string sourceFile = "source.txt";
            string targetFile = "target.txt";
            string[] fileNames = { "file1.txt", "file2.txt", "file3.txt" };
            string pattern = "*.txt";
            string word = "test";
            string folderPath = "folder";
            string reportFilePath = "report.txt";

            WriteLine($"Copy file '{sourceFile}' to '{targetFile}': {FileWork.CopyFile(sourceFile, targetFile)}");
            WriteLine($"Copy directory '{folderPath}' to 'targetFolder': {FileWork.CopyDirectory(folderPath, "targetFolder")}");
            WriteLine($"Delete file '{sourceFile}': {FileWork.DeleteFile(sourceFile)}");
            WriteLine($"Delete files: {FileWork.DeleteFiles(fileNames)}");
            WriteLine($"Delete files by pattern '{pattern}': {FileWork.DeleteFilesByPattern(pattern)}");
            WriteLine($"Move file '{sourceFile}' to '{targetFile}': {FileWork.MoveFile(sourceFile, targetFile)}");
            WriteLine($"Search for word '{word}' in '{sourceFile}' and save results to '{reportFilePath}': ");
            FileWork.SearchCountWord(sourceFile, word, reportFilePath);
            WriteLine($"Search for word '{word}' in folder '{folderPath}' and save results to '{reportFilePath}': ");
            FileWork.SearchCountWordFolder(folderPath, word, reportFilePath);

            WriteLine();
            ReadKey();
        }
    }
}
