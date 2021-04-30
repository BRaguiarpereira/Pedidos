using System;
using Pedido.Entities;
using Pedido.Entities.Enums;
namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };
            Console.WriteLine(order);

            // Convertendo enum para string
            string txt = OrderStatus.PedingPayment.ToString();

            // Convertendo string para enum tem que ser o mesmo nome do enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);


        }
    }
}
