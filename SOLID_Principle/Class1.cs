using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    public interface IShape
    {

    }

    public interface I2DShape : IShape
    {
        double GetArea();
    }
    public interface I3DShape : IShape
    {
        double GetValume();
    }

    public class Circle : I2DShape
    {
        public Circle(double radious)
        {
            Radious = radious;
        }

        public double Radious { get; }

        public double GetArea()
        {
            return Math.PI * Radious * Radious;
        }
    }
    public class Rectangle : I2DShape
    { 
       public double Lenght { get; set; }   
        public double Width { get; set; }
        public double GetArea()
        { 
          return Lenght * Width;
        }
    }
    public class Square : I2DShape
    {
       public double side { get; set; }
        public double GetArea()
        {
          return side * side;
        }
    }
    public class Cube : I3DShape
    { 
      public double side { get; set;}
        public double GetValume()
        { 
          return side * side * side;
        }
    }

}
