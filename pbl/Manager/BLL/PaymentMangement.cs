using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl.entity_class;
using pbl.Manager.Interface;

namespace pbl.Manager.BLL
{
    internal class PaymentMangement : IPaymentManagement
    {
        public async Task<Payment> Process(Order order, PaymentMethod Method)
        {
            var payment = new Payment(order.OrderId, order.OrderTotal, Method);
            Console.WriteLine($"Processing payment for Order #{order.OrderId} with " +
                $"amount {order.OrderTotal:C} using {Method}...");

            await Task.Delay(1000);// giả vờ xử lý

            // giả vờ thành công
            payment.status = PaymentStatus.Completed;
            payment.date = DateTime.Now;

            Console.WriteLine("payment success");
            Console.WriteLine(payment);
            order.UpdateStatus(Status.Completed);
            return payment;

        }
    }
}
