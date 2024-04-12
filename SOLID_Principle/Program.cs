namespace SOLID_Principle
{
    public class Program
    {
        static void Main(string[] args)
        {
            I2DShape circle = new Circle(2);
            I2DShape rectangle = new Rectangle { Lenght =4, Width = 4};
            CalculateArea(rectangle);
            new Printer().Print(rectangle);
            Console.ReadLine();
        }

        private static void CalculateArea(I2DShape circle)
        {
            
            Console.WriteLine("area1 is " + circle.GetArea());
        }
        
    }
}
