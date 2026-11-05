public class FullTimeEmployee : Employee
{
    private decimal _monthlySalary;

    public FullTimeEmployee(string name, decimal monthlySalary) : base(name)
    {
        _monthlySalary = monthlySalary;
    }

    public override decimal CalculateSalary()
    {
        return _monthlySalary;
    }
}