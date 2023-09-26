namespace Cls01.Models
{
    public class Circle
    {
        private double _radius;
        private float _pi = 3.14159f;

        public double Radius { get => _radius; set => _radius = value; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        //Area Formul  πR2 -> π == 3.14 multiplay R pow
        public double CircleArea()
        {
            return _pi * (Radius * Radius);
        }

        //2 * π * R formula Circumference
        public double CircleCircumference()
        {
            return (2 * _pi) * Radius;
        }

        public double CircleDiametr()
        {
            return Radius * Radius;
        }
    }
}
