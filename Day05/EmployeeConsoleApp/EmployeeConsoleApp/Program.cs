///*string name = "Hrishita";
//string department = "IT";

//Console.WriteLine("Name: " + name);
//Console.WriteLine("Department: " + department);

//Console.ReadLine();
//const int myNum = 15;
//Console.WriteLine(myNum);
//*/
////Console.WriteLine("Enter Username: ");
////string username =Console.ReadLine();
////Console.WriteLine("Username is:" + username);
////Console.WriteLine("Eneter you age: ");
//////int age = Convert.ToInt32(Console.ReadLine());
//////Console.WriteLine("Your age is: :" + age);
//////Console.WriteLine(Math.Max(5, 10));
////using System.Text.Json.Serialization;

////string firstName = "Joe";
////string lastname = "Gaba";
//////string name = firstName + lastname;
//////string name = string.Concat(firstName, lastname); //concatentaion
//////string interpolation
////string name = $"My name is:  {firstName} {lastname}";
//////Console.WriteLine(name);
////using System.ComponentModel.Design;

////Console.WriteLine("Enter Name: ");
////string name = Console.ReadLine();
////Console.WriteLine("Enter Dept: ");
////string department = Console.ReadLine();
////Console.WriteLine("Enter age: ");
////int age = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Enter Salary: ");
////double salary = Convert.ToDouble(Console.ReadLine());
////bool isActive = true;

////double bonus = salary * 0.01;
////Console.WriteLine("Employee Details");
////Console.WriteLine("----------------");
////Console.WriteLine("Name: " + name);
////Console.WriteLine("Age: " + age);
////if(age < 18)
////{
////    Console.WriteLine("You are a minor");
////}

////else if(age>=18 && age<= 60)
////{
////    Console.WriteLine("Eligible for Employement");
////}
////else
////{
////    Console.WriteLine("senior citizen, not eligible for employment");
////    }

////Console.WriteLine("Department: " + department);
////Console.WriteLine("Salary: " + salary);
////Console.WriteLine("Bonus: " + bonus);
////Console.WriteLine("Active: " + isActive);


////for (int i = 1; i < 5; i++)
////{
////    Console.WriteLine(i);
////}

////Console.WriteLine("Employee IDs");
////for(int i = 1; i <= 5; i++)
////{
////    Console.WriteLine($"Emp{i}");
////}

//string[] departments = { "IT", "HR", "Finance" };
//Console.WriteLine(departments[0]);
//for(int i = 0;i<departments.Length; i++)
//{
//    Console.WriteLine(departments[i]);
//}
//foreach(string dept in departments)
//{
//    Console.WriteLine(dept);
//}
//Array.Sort(departments);
//Console.WriteLine("Sorted Departments:");
//foreach (string dept in departments)
//{
//    Console.WriteLine(dept);
//}

List<int> EmpId = new List<int>();
EmpId.Add(1);
EmpId.Add(2);
EmpId.Add(3);
EmpId.Add(4);
foreach(int emp in EmpId)
{
    Console.WriteLine(emp);
}
