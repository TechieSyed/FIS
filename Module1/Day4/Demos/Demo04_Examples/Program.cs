using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Examples
{
    class Customer
    {
        public string Email { get; set; }
        public string PhoneNo { get; set; }
    }
    class Program
    {
        delegate void OTPSender(string otp, Customer customer);
        static void Main(string[] args)
        {
            var random = new Random();
            var otp = random.Next(1000, 99999);

            var custA = new Customer();
            custA.Email = "Syed.khaleel@outlook.com";
            custA.PhoneNo = "9676516962";


            var otpsender = new OTPSender(SendOTPToSms);
            otpsender += SendOTPToEmail;
            if (otpsender != null)
            {
                otpsender(otp.ToString(), custA);
            }

            Console.ReadKey();
        }
        static void SendOTPToSms(string otp, Customer obj)
        {
            Console.WriteLine("Sending otp {0} to mobile {1}", otp, obj.PhoneNo);
        }
        static void SendOTPToEmail(string otp, Customer obj)
        {
            Console.WriteLine("Sending otp {0} to email {1}", otp, obj.Email);
        }
    }
}
