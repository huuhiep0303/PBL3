using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace humanFeature
{
    public class Location
    {
        protected string street { get; set; }
        protected string city { get; set; }
        protected string country { get; set; }
        Location()
        {
            street = "";
            city = "";
            country = "";
        }
        Location(string street, string city, string country)
        {
            this.street = street;
            this.city = city;
            this.country = country;
        }
        ~Location() { }

        public void getAddress()
        {
            Console.WriteLine("Nhập địa chỉ: ");
            Console.WriteLine("Số nhà: ");
            this.street = Console.ReadLine();
            Console.WriteLine("Thành phố: ");
            this.city = Console.ReadLine();
            Console.WriteLine("Quốc gia: ");
            this.country = Console.ReadLine();
        }
        public void startAddress() //khởi tạo giá trị cho lớp dùng quan hệ has is
        {
            street = "";
            city = "";
            country = "";
        }
    };
    public class human
    {
        protected int ID { get; set; }
        protected string name { get; set; }
        protected DateTime birth { get; set; }
        protected string gender { set; get; }
        protected Location address { get; set; }
        protected string phone { get; set; }
        protected string userName { get; set; }
        protected string password { get; set; }
        public human()
        {
            ID = 0;
            name = "";
            birth = new DateTime(0,0,0);
            gender = "";
            address.startAddress();
            phone = "";
            userName = "";
            password = "";
        }
        public human(int ID, string name, DateTime birth, string gender, Location address, string phone, string userName, string password)
        {
            this.ID = ID;
            this.name = name;
            this.birth = birth;
            this.gender = gender;
            this.address = address;
            this.phone = phone;
            this.userName = userName;
            this.password = password;
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

        public void checkUser(string name, string id)
        {
            //cú pháp check cơ sở dữ liệu
        }

        public void signIn()
        {
            Console.WriteLine("Tên tài khoản: ");
            this.userName = Console.ReadLine();
            Console.WriteLine("Mật khẩu: ");
            this.password = Console.ReadLine();
            //cần tạo một hàm để kiểm tra thử tài khoản này có tồn tại hay chưa
        }
    };
}
