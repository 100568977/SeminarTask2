using System;

namespace OO_Tasks_Interface {
    public interface IShapeProps { }

    public interface ICircleProps { }

    public class Shape {
        private string _name;
        private string _colour;
    }

    public class Quadrilateral : Shape { }

    public class Square { }

    public class Rectangle { }

    public class Circle {
        public const double PI = 3.142;
    }
}