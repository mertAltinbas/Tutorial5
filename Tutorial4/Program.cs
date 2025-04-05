using Tutorial3.Models;

namespace Tutorial3;

public class Program
{
    public static void Main(string[] args)
    {
        var emps = Database.GetEmps();
        List<Emp> result = emps.Where(e => e.DeptNo == 30).OrderBy(e => e.Sal).ToList();

        foreach (var emp in result)
        {
            Console.WriteLine($"EmpId: {emp.EmpNo}, Name: {emp.EName}, Salary: {emp.Sal}, Hire Date: {emp.HireDate}");
        }
    }
}