using System.Runtime.CompilerServices;
using static System.Console;

namespace LibraryDLL
{
    public static class FileWork
    {
        //task 3
        //1
        public static bool CopyFile(string source, string target)
        {
            if (!File.Exists(source) || new FileInfo(source).Length == 0)
            {
                return false;
            }

            try
            {
                File.WriteAllBytes(target, File.ReadAllBytes(source));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        //2
        public static bool CopyDirectory(string source, string target)
        {
            if (!Directory.Exists(source)) return false;

            try
            {
                if (!Directory.Exists(target))
                {
                    Directory.CreateDirectory(target);
                }

                string[] files = Directory.GetFiles(source);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(target, fileName);
                    File.Copy(file, destFile, true);
                }

                string[] directories = Directory.GetDirectories(source);

                foreach (string directory in directories)
                {
                    string dirName = Path.GetFileName(directory);
                    string destDir = Path.Combine(target, dirName);
                    CopyDirectory(directory, destDir);
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        //3
        public static bool DeleteFile(string path)
        {
            if (!File.Exists(path)) return false;

            try
            {
                File.Delete(path);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        //4
        public static bool DeleteFiles(string[] fileNames)
        {
            try
            {
                foreach (string fileName in fileNames)
                {
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }
                    else
                    {
                        WriteLine($"File '{fileName}' does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"An error occurred: {ex.Message}");
                return false;
            }

            return true;
        }
        //5
        public static bool DeleteFilesByPattern(string pattern)
        {
            try
            {
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), pattern);

                files
                     .ToList()
                     .ForEach(File.Delete);

                return true;
            }
            catch (Exception ex)
            {
                WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
        //6
        public static bool MoveFile(string source, string target)
        {
            try
            {
                if (!File.Exists(source)) return false;
                File.Move(source, target);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //7
        public static void SearchCountWord(string path, string word, string savePath)
        {
            if (!File.Exists(path) || new FileInfo(path).Length == 0)
            {
                WriteLine("File does not exist or empty");
                return;
            }
            var data = File
                           .ReadAllText(path)
                           .Split(" ,.!?;:\'\"".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                           .ToList();
            string result = $"Count: {data.Where(x => x == word).Count()}";
            File.WriteAllText(savePath, result);
            WriteLine(result);
        }
        //8
        public static void SearchCountWordFolder(string path, string word, string savePath)
        {
            try
            {
                var matchedFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                    .Where(file => File.ReadAllText(file).Contains(word))
                    .ToList();

                File.WriteAllLines(savePath, matchedFiles);

                WriteLine($"Report generated successfully: {savePath}");
            }
            catch (Exception ex)
            {
                WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
