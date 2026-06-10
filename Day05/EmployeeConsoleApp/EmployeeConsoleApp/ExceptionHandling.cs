public class ExceptionHandling
{
    public void Run()
    {
        try
        {
            Console.WriteLine("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Salary: {salary}");

        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program Finished.");
        }

    }
}
