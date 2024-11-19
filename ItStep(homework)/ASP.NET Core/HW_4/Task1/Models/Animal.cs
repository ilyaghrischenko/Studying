namespace Task1.Models;

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual string MakeSound()
    {
        return $"{Name} makes a sound.";
    }
}