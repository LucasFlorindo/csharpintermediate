using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using exemploenum.Entities;
using exemploenum.Entities.Enums;


namespace exemploenum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment


            };



            Console.WriteLine(order);


            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os;
            Enum.TryParse("Delivered", out os);

            Console.WriteLine(txt);
            Console.WriteLine(os);



        }
    }
}
