public class AsyncAwaitDemo
{
    public async Task Run()
    {
        Console.WriteLine("Processing...");

        await Task.Delay(3000);

        Console.WriteLine("Completed");
    }
}