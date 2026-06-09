using System;
using System.Collections.Generic;
using System.Text;

public class Manager: Employee
{
    public int teamSize { get; set; }
    public override void Work()
    {
        Console.WriteLine("Manager is managing the team");
    }
}