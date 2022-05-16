using System;
using System.Linq.Expressions;

public class Program
{
    public static void Main()
    {
        Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;

        //compile Expression using Compile method to invoke it as Delegate
        Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();

        //Invoke
        bool result = isTeenAger(new Student() { StudentID = 1, StudentName = "Steve", Age = 20 });

        Console.WriteLine(result);
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}