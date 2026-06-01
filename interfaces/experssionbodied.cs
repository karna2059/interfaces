using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class ExpressionBodiedMembers
    {
        public void PrintMessage() => Console.WriteLine("Hello, World!");

        public int square(int x) => x * x;

        public ExpressionBodiedMembers() => Console.WriteLine("Constructor called!");
    }
    internal class experssionbodied
    {
        static void Main(string[] args)
        {
            ExpressionBodiedMembers obj= new ExpressionBodiedMembers();
            obj.PrintMessage();
            Console.WriteLine(obj.square(5));
        }
    }
}
