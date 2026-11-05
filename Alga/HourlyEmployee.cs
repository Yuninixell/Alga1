public class HourlyEmployee : Employee
{
    private decimal _hourlyRate;
    private int _hoursWorked;

    public HourlyEmployee(string name, decimal hourlyRate, int hoursWorked) : base(name)
    {
        _hourlyRate = hourlyRate;
        _hoursWorked = hoursWorked;
    }

    public override decimal CalculateSalary()
    {
        return _hourlyRate * _hoursWorked;
    }
}