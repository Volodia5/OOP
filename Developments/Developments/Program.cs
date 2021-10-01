using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developments
{
    class Phone
    {
        public int BateryPower { get; private set; }

        public delegate void Discharge(int powerBatery);

        public event Discharge dischargingPhone;
        public Phone(int bateryPower)
        {
            BateryPower = bateryPower;
        }

        public void Discharg()
        {
            for (int i = 0; i < BateryPower; BateryPower--)
            {
                if (BateryPower <= 20)
                {
                    dischargingPhone(BateryPower);
                    break;
                }
            }
        }
    }

    class PhoneUser
    {
        public void DischargePhone(int powerBatery)
        {
            Console.WriteLine("Заряд батареи менее 20% , нужно поставить телефон на зарядку !!!");
            Console.WriteLine("Пользовател пошел ставить телефон на зарядку");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone(100);
            PhoneUser phoneUser = new PhoneUser();

            phone.dischargingPhone += phoneUser.DischargePhone;

            phone.Discharg();

            Console.ReadKey();
        }
    }
}
