using System;

namespace OO_Tasks_Interface {
    public interface IShapeProps {

        double GetArea();
        double GetPerimeter();

    }

    public interface ICircleProps {
        double GetCircumference();
        double GetArea();
        double GetPerimeter();
    }

    public class Shape
    {
        private string _name;
        private string _colour;

        public Shape(string name, string colour)
        {
            _name = name;
            _colour = colour;
        }
        public string Colour()
        {
            return _colour;
        }

        public string Name()
        {
            return _name;
        }

    }

    public class Quadrilateral : Shape
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

    public class Square : Quadrilateral, IShapeProps
    {
        private double _sideLength;
        
        public Square(string name, string colour, double sideLength) : base(name,colour)
        {
            _sideLength = sideLength;
        }
        public double GetArea()
        {
            return Math.Round(_sideLength * _sideLength, 2);
        }

        public double GetPerimeter()
        {
            return Math.Round(_sideLength * 4, 2);
        }
    }

    public class Rectangle : Quadrilateral, IShapeProps
    {
        private double _length;
        private double _width;

        public Rectangle(string name, string colour, double length, double width) : base(name, colour)
        {
            _length = length;
            _width = width;
        }

        public double GetArea()
        {
            return Math.Round(_length * _width, 2);
        }

        public double GetPerimeter()
        {
            return Math.Round((2 * _length) + (2 * _width), 2);
        }
    }

    public class Circle : Shape, ICircleProps
    {
        public const double PI = 3.142;
        private double _radius;

        public Circle(string name, string colour, double radius) : base(name,colour)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.Round(_radius * _radius * PI, 2);
        }

        public double GetCircumference()
        {
            return Math.Round(2 * _radius * PI, 2);
        }
        public double GetPerimeter()
        {
            return Math.Round(2 * _radius * PI, 2);
        }
    }
}