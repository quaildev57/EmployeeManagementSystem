//public class DelegateDemo
//{
//    public delegate void DisplayMessage();
//    public void Show()
//    {
//        Console.WriteLine("Hello there!");
//    }
//    public void Run()
//    {
//        DisplayMessage message = Show;
//        message();
//    }
//}

public class DelegateDemo
{
    public delegate void DisplayMessage();

    public void Show()
    {
        Console.WriteLine("Hello from Delegate");
    }

    public void Run()
    {
        DisplayMessage message = Show;

        message();
    }
}