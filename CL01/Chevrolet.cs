

internal partial class Program
{
    //private string? _name = string.Empty;
    //private string? _brendName = string.Empty;
    //private DateTime _date = new DateTime();
    //private double _salary = default(double);

    public class Chevrolet : Car
    {

        public Chevrolet(string name, string brendName, DateTime date, double salary)
        {
            this.Name = name;
            this.BrendName = brendName;
            this.Date = date;
            this.Salary = salary;
        }

        public void GetInfo()
        {
            Console.WriteLine($@" 
This is car name:{this.Name} 
Brend: {this.BrendName}
Salary: {this.Date}
Date of manufacture: {this.Salary}
");
        }

    }





}