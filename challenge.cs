
public abstract class Employee
{
    private static int _empCount = 0;
    protected static int IDStart;

    //public Employee(){}

    // static constructor is called before anything happens in the class, cannot be inherited or overloaded
    static Employee(){
        IDStart = 1000;
    }
    public Employee(){
        Employee._empCount++;
        ID = Employee.IDStart++;
    }
    
    public static int EmployeeCount { get => _empCount; }
    // This is the only one that is prevented from being changed after it's been assigned
    public required int ID { get; init; }
    public required int Department { get; set; }
    public required int FullName { get; set; }

    // This method is intended to be overriden
    public abstract void AdjustPay(decimal percentage) { }

}

public class HourlyEmployee : Employee
{
    public HourlyEmployee(){}

    // This value may be changed in the future
    public decimal PayRate { get; set; }
    public override void AdjustPay(decimal percentage)
    {
        PayRate += (PayRate * percentage);
    }
}