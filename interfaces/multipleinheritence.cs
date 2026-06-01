using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    interface iphonebasic
    {
        void calling();
        void recieving();

        void sendingmessage();

        void endcall();
    }
    class iphonese : iphonebasic
    {
        public void calling()
        {
            Console.WriteLine("iphonese calling");
        }
        public void endcall()
        {
            Console.WriteLine("iphonese end call");
        }
        public void recieving()
        {
            Console.WriteLine("iphonese recieving");
        }
        public void sendingmessage()
        {
            Console.WriteLine("iphonese sending message");
        }
    }

    interface iphoneadvance
    {
        void faceid();
        void videocall();

        void wirelesscharging();
    }

    class iphone11 : iphonebasic, iphoneadvance
    {
       public void calling()
        {
            Console.WriteLine("iphone11 calling");
        }
        public void endcall()
        {
            Console.WriteLine("iphone11 end call");
        }
        public void recieving()
        {
            Console.WriteLine("iphone11 recieving");
        }
        public void sendingmessage()
        {
            Console.WriteLine("iphone11 sending message");
        }
        public void faceid()
        {
            Console.WriteLine("iphone11 faceid");
        }
        public void videocall()
        {
            Console.WriteLine("iphone11 videocall");
        }
        public void wirelesscharging()
        {
            Console.WriteLine("iphone11 wirelesscharging");
        }
    }

    internal class multipleinheritence
    {
        static void Main(string[] args)
        {
            iphonebasic obj=new iphonese();
            obj.calling();
            obj.recieving();
            obj.sendingmessage();
            obj.endcall();
            obj = new iphone11();
            obj.calling();
            obj.recieving();
            obj.sendingmessage();
            obj.endcall();
            iphoneadvance obj1 = new iphone11();
            obj1.faceid();
            obj1.videocall();
            obj1.wirelesscharging();
        }
    }
}
