using System;
using System.Collections.Generic;
using System.Text;

public class  HR: IEmployee
{
    public int ID { get; set; }
    public  void Work()
    {
        Console.WriteLine("HR manages employee recruitment and relations.");
    }
}