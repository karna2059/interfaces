using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    using System;

    namespace PaymentInterfaces
    {
       
        interface IPaymentMethod
        {
            void Pay();
            void CancelPayment();
            void CheckBalance();
        }

       
        class DebitCard : IPaymentMethod
        {
            public void Pay()
            {
                Console.WriteLine("Payment done using Debit Card");
            }

            public void CancelPayment()
            {
                Console.WriteLine("Debit Card payment cancelled");
            }

            public void CheckBalance()
            {
                Console.WriteLine("Checking Debit Card balance");
            }
        }

      
        interface IOnlinePayment
        {
            void PayPal();
            void UPI();
            void Wallet();
        }

     
        class PayPalPayment : IPaymentMethod, IOnlinePayment
        {
            public void Pay()
            {
                Console.WriteLine("Online payment successful");
            }

            public void CancelPayment()
            {
                Console.WriteLine("Online payment cancelled");
            }

            public void CheckBalance()
            {
                Console.WriteLine("Checking online account balance");
            }

            public void PayPal()
            {
                Console.WriteLine("Payment through PayPal");
            }

            public void UPI()
            {
                Console.WriteLine("Payment through UPI");
            }

            public void Wallet()
            {
                Console.WriteLine("Payment through Wallet");
            }
        }

      
    internal class paymentinterfaces
    {
            static void Main(string[] args)
            {
                IPaymentMethod obj = new DebitCard();

                obj.Pay();
                obj.CheckBalance();
                obj.CancelPayment();

                Console.WriteLine();

                obj = new PayPalPayment();

                obj.Pay();
                obj.CheckBalance();
                obj.CancelPayment();

                Console.WriteLine();

                IOnlinePayment obj1 = new PayPalPayment();

                obj1.PayPal();
                obj1.UPI();
                obj1.Wallet();
            }
        }
    }
}
