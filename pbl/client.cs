using humanFeature;
using inforProduct;

    public class client : human
{
    protected List<string> productList;
    protected List<double> price;
    protected LinkedList<int> quantity;

    public client()
    {
        this.productList = new List<string>();
        this.price = new List<double>();
        this.quantity = new LinkedList<int>();
    }

    public void addProduct(string product, double price, int quantity)
    {
        this.productList.Add(product);
        this.price.Add(price);
        this.quantity.AddLast(quantity);
    }

    public void removeProduct(string product)
    {
        for(int i = 0; i <this.productList.count; i++)
        {
            if(this.productList[i] == product)
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
        Console.writeLine("Danh sách sản phẩm: ");
        for(int i = 0; i < this.productList[i]; i++)
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
    