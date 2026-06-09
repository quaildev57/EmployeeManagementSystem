using System;
using System.Collections.Generic;
using System.Text;

public class Developer : Employee
{
   // public string ProgrammingLanguage { get; set; }
    public override void Work()
    {
        Console.WriteLine("Developer is coding " );
    }
}