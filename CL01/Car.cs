

internal partial class Program
{
    public abstract class Car
    {
        private string? _name = string.Empty;
        private string? _brendName = string.Empty;
        private DateTime _date = new DateTime();
        private double _salary = default(double);


        public string? Name { get => _name; set => this._name = value; }

        public string? BrendName { get => _brendName; set => this._brendName = value; }

        public DateTime Date { get => this._date; set => this._date = value; }

        public double Salary { get => this._salary; set => _salary = value; }

        public override string ToString()
        {
            return $@" 
This is car name:{this._name} 
Brend: {_brendName}
Salary: {this._salary}
Date of manufacture: {this._date}
";
        }
    }





}