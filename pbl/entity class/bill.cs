using System;
using client;
using inforProduct;
using humanFeature;
using employee;
using System.Linq;

namespace billOrder
{   
    const double count = 1;
    public class bill
    {
        // thêm biến tĩnh để gán cho mã bill
        public string IDbill;
        public cashier responser;
        public client whoBuy;
        public inforProduct whatBuy;
        public date whenBuy;
        public double totalPrice;

        public bill(string IDbill, cashier responser, client whoBuy, inforProduct whatBuy, date whenBuy, double totalPrice)
        {
            this.IDbill = IDbill;
            this.responser = responser;
            this.whoBuy = whoBuy;
            this.whatBuy = whatBuy;
            this.whenBuy = whenBuy;
            this.totalPrice = totalPrice;
        }
        public string IDBill
        {
            get { return IDbill; }
            set { IDbill = value; }
        }
        public bill()
        {
            this.IDbill = "0000";
            this.responser = new cashier();
            this.whoBuy = new client();
            this.whatBuy = new inforProduct();
            this.whenBuy = new date();
            this.totalPrice = 0;
        }

        public void addBill(string IDbill, cashier responser, client whoBuy, inforProduct whatBuy, date whenBuy, double totalPrice)
        {
            this.IDbill = IDbill;
            this.responser = responser;
            this.whoBuy = whoBuy;
            this.whatBuy = whatBuy;
            this.whenBuy = whenBuy;
            this.totalPrice = totalPrice;
        }

        public void showBill(string IDbill, cashier responser, client whoBuy, inforProduct whatBuy, date whenBuy, double totalPrice)
        {
            //nhập thông tin bill
            //mã hoá đơn sẽ được tự động gán cho biến tĩnh
            Console.WriteLine(IDbill);
            // In ra tên nhân viên phụ trách
            Console.WriteLine("Tên nhân viên thu ngân: " + responser.name);
            //In ra mã nhân viên
            Console.WriteLine("Mã nhân viên: " + responser.ID);
            //In ra ngày giờ mua hàng
            Console.WriteLine("Ngày giờ mua hàng: " + whenBuy.day + "/" + whenBuy.month + "/" + whenBuy.year);
            //In ra tên khách hàng
            Console.WriteLine("Tên khách hàng: " + whoBuy.name);
            //In ra mã khách hàng
            Console.WriteLine("Mã khách hàng: " + whoBuy.ID);
            //Hiển thị danh sách mua hàng
            double totalPrice = 0;
            for (int i = 1; i < whoBuy.productList.Count; i++)
            {
                Console.WriteLine("Tên sản phẩm: " + whoBuy.productList[i]);
                Console.WriteLine("Giá sản phẩm: " + whoBuy.price[i]);
                Console.WriteLine("Số lượng sản phẩm: " + whoBuy.quantity.ElementAt(i));
                Console.WriteLine();
                totalPrice += whoBuy.price[i] * whoBuy.quantity[i];
            }
            // In ra tổng tiền
            Console.WriteLine("Tổng tiền: " + totalPrice);
            //cần tìm cách để gán vô cơ sở dữ liệu
            addBill(IDbill, responser, whoBuy, whatBuy, whenBuy, totalPrice);

        }


    };
}
