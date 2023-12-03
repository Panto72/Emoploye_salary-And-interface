using Employez_salary;

public class Program
{
    public static void Main()
    {
        Employe emp =new Employe(5000,2000,2000,20000);
        emp.Id = 1;
        emp.Name = "Mafuj Ahammad Pranto";
        emp.Email = "Praanto@gmail.com";
        emp.Address = "Dhanmondi";
        emp.Phone = "01819017267";
        emp.designation = "It Manager";
        emp.Department = "IT Deparetment";
        double salary = emp.Salary();
        Console.WriteLine("ID:"+emp.Id);
        Console.WriteLine("Name:"+emp.Name);
        Console.WriteLine("Email:" + emp.Email);
        Console.WriteLine("Address:" + emp.Address);
        Console.WriteLine("Phone:" + emp.Phone);
        Console.WriteLine("Department:" + emp.Department);
        Console.WriteLine("Desingnation:" + emp.designation);
        Console.WriteLine("Salary amount:"+salary);
    }
}