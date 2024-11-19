namespace Task2.Models;

public abstract class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    // Метод для рисования фигуры
    public abstract string Draw();
}
