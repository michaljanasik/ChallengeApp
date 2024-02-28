using challangeApp;

using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

var employee = new Employee("abc", "cda");
Statistics st;
try
{
    /*
     employee.AddGrade(2.2);
     employee.AddGrade(2);
     employee.AddGrade(10);
     employee.AddGrade("29");
     employee.AddGrade("23,5");
     employee.AddGrade(23.56546);
     employee.AddGrade(-10);
     */
    /*
     employee.AddGrade(10.0000);
     employee.AddGrade(10);
     employee.AddGrade(10);
     employee.AddGrade("10.0000");
     employee.AddGrade("10");
     employee.AddGrade(10);
     employee.AddGrade(10);
     employee.AddGrade("10,0000");
    */
    employee.AddGrade(-10.0000);
    employee.AddGrade(10);
    employee.AddGrade(10.00);
    employee.AddGrade("10.0000");
    employee.AddGrade("-10");
    employee.AddGrade(10);
    employee.AddGrade(10.00000);
    employee.AddGrade("10,0000");

    employee.showAllGrades();
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}

st = employee.getStatistics();

Console.WriteLine($"\n\nMin: {st.Min:N2}, Max: {st.Max:N2}, Average: {st.Average:N2}\n\n\n");