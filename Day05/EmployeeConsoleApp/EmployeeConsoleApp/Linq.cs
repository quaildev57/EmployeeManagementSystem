public class Linq
{
    public void Run() 
    {
        List<int> salaries = new List<int>() { 50000, 60000, 55000, 70000, 65000 };
        var highSalaries = from salary in salaries
                           where salary > 55000
                           select salary;

        //where
        var result =
        salaries.Where(s => s > 60000);

        foreach (var salary in result)
        {
            Console.WriteLine(salary);
        }

        //first or default
        var firstHighSalary = salaries.FirstOrDefault(s => s > 60000);

        //count
        int count = salaries.Count(s => s > 60000);
        Console.WriteLine($"Number of salaries greater than 60000: {count}");


    }



}
    
