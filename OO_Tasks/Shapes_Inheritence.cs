using System;

namespace OO_Tasks_Inheritence {
    public abstract class Shape
    {
        private string _name;
        private string _colour;

        public Shape(string name, string colour)
        {
            _name = name;
            _colour = colour;
        }

        public string Name()
        {
            return _name;
        }

        public string Colour()
        {
            return _colour;
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();
    }


    public abstract class Quadrilateral : Shape
    {
        private int _NumSides;

        public Quadrilateral(string name, string colour) : base(name, colour)
        {

        }

        public int NumSides()
        {
            return _NumSides;
        }
    }

    public class Square : Quadrilateral
    {
        private double _sideLength;

        public Square(string name, string colour, double sideLength) : base(name, colour)
        {
            _sideLength = sideLength;
        }

        public override double GetArea()
        {
            return Math.Round(_sideLength * _sideLength, 2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(4 * _sideLength, 2);
        }
        public double SideLength()
        {
            return _sideLength;
        }
    }

    public class Rectangle : Quadrilateral
    {
        private double _length;
        private double _width;

        public Rectangle(string name, string colour, double length, double width) : base(name, colour)
        {
            _length = length;
            _width = width;
        }

        public override double GetArea()
        {
            return Math.Round(_length * _width, 2);
        }

        public override double GetPerimeter()
        {
            return Math.Round((2 * _length) + (2 * _width), 2);
        }

        public double Length()
        {
            return _length;
        }

        public double Width()
        {
            return _width;
        }


    }

    public class Circle : Quadrilateral
    {
        public const double PI = 3.142;
        private double _radius;

        public Circle(string name, string colour, double radius) : base(name, colour)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.Round(_radius * _radius * PI, 2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * _radius * PI, 2);
        }
        public double GetCircumference()
        {
            return Math.Round(2 * _radius * PI, 2);
        }

        public double Radius()
        {
            return _radius;
        }
    }
    
    
}