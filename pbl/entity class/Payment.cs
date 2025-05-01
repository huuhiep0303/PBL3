using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.entity_class
{
    public enum PaymentStatus { Pending, Completed, Failed, Canceled}
    public enum PaymentMethod { CreditCart, BankTransfer, Wallet, Cash}
    internal class Payment
    {
        [Key]
        public int paymentId {  get; set; }
        public int orderId { get; set; }
        public decimal amount { get; set; }
        public PaymentStatus status { get; set; }
        public PaymentMethod method { get; set; }
        public DateTime date { get; set; }
        public Payment(int orderId, decimal amount, PaymentMethod method)
        {
            this.orderId = orderId;
            this.amount = amount;
            this.method = method;
            status = PaymentStatus.Pending;
            date = DateTime.Now;

        }
        public override string ToString()
        {
            return $"PaymentId: {paymentId}, OrderId: {orderId}, Amount: {amount:C}, Method: {method}" +
                $", Status: {status}, Date: {date}";
        }
    }
}
