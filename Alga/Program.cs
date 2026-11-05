    // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var employees = new List<Employee>
{
    new FullTimeEmployee("Anna", 1200m),
    new HourlyEmployee("Jānis", 8m, 100)
};

foreach (Employee e in employees)
{
    Console.WriteLine($"{e.Name}: {e.CalculateSalary():F2}");
}

var payroll = new PayrollCalculator();
Console.WriteLine($"Kopā: {payroll.TotalSalary(employees):F2}");

// Pievienojam SalesEmployee bez PayrollCalculator izmaiņām
employees.Add(new SalesEmployee("Marta", 500m, 4000m));

Console.WriteLine("--- pēc Marta pievienošanas ---");
foreach (Employee e in employees)
{
    Console.WriteLine($"{e.Name}: {e.CalculateSalary():F2}");
}
Console.WriteLine($"Kopā: {payroll.TotalSalary(employees):F2}");

/* Paskaidrojums:
 * 
 * Polimorfisms redzams šeit:
 * 1. Saraksts List<Employee> satur dažādu klašu objektus (FullTimeEmployee, HourlyEmployee, SalesEmployee)
 * 2. foreach cilpā e.CalculateSalary() izsauc pareizo metodi katram objektam atbilstoši tā faktiskajam tipam
 * 3. PayrollCalculator.TotalSalary() neizmanto is/as/GetType(), bet darbojas ar jebkuru Employee atvasinājumu
 * 
 * OCP (Open/Closed Principle) ievērošana:
 * - PayrollCalculator un citas klases ir SLĒGTAS modifikācijai (nekas nav mainīts)
 * - Sistēma ir ATVĒRTA paplašinājumam (SalesEmployee ir jauna klase, kas atvasināta no Employee)
 * - Jaunas algas aprēķina veida pievienošana neprasa PayrollCalculator maiņu
 */
