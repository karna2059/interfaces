//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace interfaces
//{
//    interface IShape
//    {
//        void Area();

//        double Perimeter();
        
        
       
//    }
//    public class circle : IShape
//    {
//        public double radius;
//        public void Area()
//        {
//            Console.WriteLine("Area of the circle: "+ Math.PI * radius * radius);
//        }

//        public double Perimeter()
//        {
//            return 2 * Math.PI * radius;
//        }
//    }

//    public class  rectangle : IShape 
//    {
//        public double length {  get; set; }

//        public double width {  get; set; }

//        public void Area()
//        {
//            Console.WriteLine("Area of the rectangle: "+ length * width);
//        }
//        public double Perimeter()
//        {
//            return 2 * (length + width);
//        }
//    }
//    internal class shape
//    {
//        static void Main(string[] args)
//        {
//            IShape circle = new circle() { radius = 5 };
//            circle.Area();
//            Console.WriteLine("Perimeter of the circle: " + circle.Perimeter());
//            IShape rectangle = new rectangle() { length = 4, width = 6 };
//            rectangle.Area();
//            Console.WriteLine("Perimeter of the rectangle: " + rectangle.Perimeter());
//        }
//    }
//}
