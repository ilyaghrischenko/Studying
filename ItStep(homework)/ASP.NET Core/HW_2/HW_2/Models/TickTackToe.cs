using System.IO;

namespace HW_2.Models;

public class TickTackToe
{
    public List<int> Zeroes { get; set; } = new();
    public List<int> Crosses { get; set; } = new();

    public TickTackToe()
    {
    }

    public void ChangeValue(int choice)
    {
        try
        {
            using var file = File.Open("html/ticktacktoe/tickTackToe.html", FileMode.Open, FileAccess.ReadWrite);
            using TextReader textReader = new StreamReader(file);
            char text;
            long seek;
            int x = 0;
            while (true)
            {
                ++x;
                text = (char)textReader.Read();
                if (text == (char)(48 + choice)) break;
            }

            file.Close();
            using var file2 = File.Open("html/ticktacktoe/tickTackToe.html", FileMode.Open, FileAccess.Write);
            using StreamWriter streamWriter = new(file2);
            file2.Seek(x - 1, SeekOrigin.Begin);
            streamWriter.Write('X');
            Crosses.Add(choice);

            int computerChoice = 0;
            Random random = new();
            do
            {
                computerChoice = random.Next(1, 9);
            } while (Crosses.Any(x => x == computerChoice));
            
            //DO
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}