using humanFeature;
using System;
//cập nhật list của mỗi đối tượng sau mỗi lần cập nhật trên API.
// Mỗi lần tính tiền thì lấy một mảng tạm thời để đem ra tính.
//Lấy biến tạm để lấy dữ liệu từ cơ sở dữ liệu
namespace client
{
    public class client : human
    {
        protected List<string> productList;
        protected List<double> price;
        protected List<int> quantity;

        public client()
        {
            this.productList = new List<string>();
            this.price = new List<double>();
            this.quantity = new List<int>();
        }

        public client(List<string> productList, List<double> price, List<int> quantity)
        {
            this.productList = productList;
            this.price = price;
            this.quantity = quantity;
        }


        public void addProduct(string product, double price, int quantity)
        {
            this.productList.Add(product);
            this.price.Add(price);
            this.quantity.Add(quantity);
        }

        public void removeProduct(string product)
        {
            for (int i = 0; i < this.productList.Count; i++)
            {
                if (this.productList[i] == product)
                {
                    this.productList.RemoveAt(i);
                    this.price.RemoveAt(i);
                    this.quantity.RemoveAt(i);
                    break;
                }
            }
        }

        public void showProduct()
        {
            Console.WriteLine("Danh sách sản phẩm: ");
            for (int i = 0; i < this.productList.Count; i++)
            {
                Console.WriteLine("Tên sản phẩm: " + this.productList[i]);
                Console.WriteLine("Giá sản phẩm: " + this.price[i]);
                Console.WriteLine("Số lượng sản phẩm: " + this.quantity.ElementAt(i));
                Console.WriteLine();
            }
        }

        public void register()
        {
            //Cái này là lớp đa hình do khách hàng và nhân viên đều có chung nên sẽ thêm môt số thành phần sau
            //Mã khách hàng sẽ được gán cho giá trị biến đếm là count với kiểu static tăng dần với mỗi khách
            Console.WriteLine("Tên cá nhân: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Ngày sinh: ");
            birth.getDate();
            Console.WriteLine("Giới tính: ");
            this.gender = Console.ReadLine();
            Console.WriteLine("Địa chỉ: ");
            address.getAddress();
            Console.WriteLine("Số điện thoại: ");
            this.phone = Console.ReadLine();
            Console.WriteLine("Nhập tên tài khoản: ");
            this.userName = Console.ReadLine();
            Console.WriteLine("Nhập mật khẩu: ");
            this.password = Console.ReadLine();
            string check_password;
            Console.WriteLine("Nhập lại mật khẩu: ");
            check_password = Console.ReadLine();
            while (this.password != check_password)
            {
                Console.WriteLine("Mật khẩu không khớp, vui lòng nhập lại: ");
                Console.WriteLine("Nhập mật khẩu: ");
                this.password = Console.ReadLine();
                Console.WriteLine("Nhập lại mật khẩu: ");
                check_password = Console.ReadLine();
            }
            //cần tạo một hàm để kiểm tra thử tài khoản này có tồn tại hay chưa
        }

        public void login()
        {
            Console.WriteLine("Nhập tên tài khoản: ");
            this.userName = Console.ReadLine();
            Console.WriteLine("Nhập mật khẩu: ");
            this.password = Console.ReadLine();
            //cần tạo một hàm để kiểm tra thử tài khoản này có tồn tại hay chưa
        }

        public void logout()
        {
            Console.WriteLine("Đăng xuất thành công");
        }


    }
}