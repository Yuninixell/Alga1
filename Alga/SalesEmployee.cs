public class SalesEmployee : Employee
{
    private decimal _baseSalary;
    private decimal _salesAmount;

    public SalesEmployee(string name, decimal baseSalary, decimal salesAmount) : base(name)
    {
        _baseSalary = baseSalary;
        _salesAmount = salesAmount;
    }

    public override decimal CalculateSalary()
    {
        return _baseSalary + (_salesAmount * 0.05m);
    }
}