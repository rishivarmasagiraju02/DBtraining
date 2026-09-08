public class Developer : Employee
{
    public string ProgrammingLanguage{ get; set;}
    public Developer( int EmployeeId, String name, int age, String Department, Decimal Salary, String programmingLanguage ) : base(EmployeeId, name, age , Department, Salary)
    {
       ProgrammingLanguage= programmingLanguage; 
    }
    public void WriteCode()
{
    Console.WriteLine(Name + " is writing " + ProgrammingLanguage + " code.");
}
public override void Work()
{
    Console.WriteLine(Name + " is writing software.");
}
}