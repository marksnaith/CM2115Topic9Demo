namespace Topic9Demo.Tests;

public class MenuTest
{

    [Fact]
    public void MenuValidInt()
    {
       // arrange
       var menu = new Menu();
       var prompt = "Please enter a positive integer";

       // act
       int actual = menu.GetPositiveIntInput(prompt);

       // assert
       // ???
    }

}
