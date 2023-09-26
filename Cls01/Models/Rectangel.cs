namespace Cls01.Models
{
    //Calculate the area and perimeter of the rectangle.
    public class Rectangel
    {
        private double _width = default;
        private double _height = default;

        public double Width { get => _width; private set => _width = value; }
        public double Height { get => _height; private set => _height = value; }

        public Rectangel(double width, double height)
        {
            Height = height;
            Width = width;
        }

        //public Rectangel()
        //{
        //    //Height = 4;
        //    //Width = 3;
        //}

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return 2 * Height + Width;
        }





    }
}
