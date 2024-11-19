namespace Task1.Models;

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override string MakeSound()
    {
        return $"{Name} says: Meow!";
    }
}