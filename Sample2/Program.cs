using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    interface Phone
    {
        void priceDetails();
    }
    class Samsung : Phone
    {
        void Phone.priceDetails()
        {
            Console.WriteLine("Samsung has low price...");
        }
    }

    class Huawei : Phone
    {
        void Phone.priceDetails()
        {
            Console.WriteLine("Huawei has middle price...");
        }
    }

    class iPhone : Phone
    {
        void Phone.priceDetails()
        {
            Console.WriteLine("iPhone is expensive...");
        }
    }

    class PhoneFactory
    {
        public static Phone getPhone(String PhoneType)
        {
            if (PhoneType == null)
            {
                return null;
            }
            else if (PhoneType.Equals("Samsung", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Samsung();
            }
            else if (PhoneType.Equals("Huawei", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Huawei();
            }
            else if (PhoneType.Equals("iPhone", StringComparison.CurrentCultureIgnoreCase))
            {
                return new iPhone();
            }

            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Phone first = PhoneFactory.getPhone("Huawei");
            first.priceDetails();

            Phone second = PhoneFactory.getPhone("Samsung");
            second.priceDetails();

            Phone third = PhoneFactory.getPhone("iPhone");
            third.priceDetails();

            Console.ReadLine();
        }
    }

}
