using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

public abstract class Employee
{
    public int EmpID { get; set; }
    public string Name { get; set; } = ""; //this removes the yellow warnings
    public string Department { get; set; }
    
    private double salary;
    public double Salary
    {
        get { return salary; }
        set
        {
            if (value > 0) salary = value;
        }
    }
    public abstract void Work();
}