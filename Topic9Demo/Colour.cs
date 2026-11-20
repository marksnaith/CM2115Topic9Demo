namespace Topic9Demo;

public class Colour
{
    private int r, g,b;

    public Colour(int r, int g, int b)
    {
        this.r = r;
        this.g = g;
        this.b = b;
    }

    public void Draw()
    {
        // Set the background colour using ANSI true-colour escape codes
        Console.Write($"\x1b[48;2;{this.r};{this.g};{this.b}m");

        // Draw a coloured rectangle
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(new string(' ', 20));
        }

        // Reset terminal colours
        Console.Write("\x1b[0m");
    }

}
