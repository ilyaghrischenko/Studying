namespace HW_2.Models;

public class GuessNumber
{
    private int _random = new Random().Next(1, 10);
    
    public GuessNumber() {}

    public bool TryGuess(int number)
    {
        return number == _random;
    }
}