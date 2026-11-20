namespace Topic9Demo;

public class Menu
{
    /**
    * A simple method that prompts a user with the given prompt, and expects to return a positive (>0) int
    * How do we automatically test that:
    * 1) The prompt is correctly displayed?
    * 2) The method works as expected with both valid and invalid inputs?
    **/
    public int GetPositiveIntInput(string prompt)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();

        int num;

        // if the input parses as an int *and* is >0...return it
        if(int.TryParse(input, out num) && num > 0)
        {   
            return num;
        }
        else
        {
            // display an error and return -1 as a sentinel for invalid input
            Console.WriteLine("Invalid input");
            return -1;
        }
    }
}
