using System.Collections.Generic;
using System.Net;
using System.Xml.Linq;
using humanFeature;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace humanFeature { 
public class clientObject : human
{
    protected double member_point { get; set; }
    protected List<string> shoppingCart = new List<string>(); //lưu id sản phẩm
    protected List<int> quantity = new List<int>(); //lưu số lượng sản phẩm
    clientObject() : base()
    {
        member_point = 0;
        quantity.Add(0);
        shoppingCart.Add(0);
    }
    clientObject(int ID, string name, string birth, string gender, Location address, string phone, string userName, string password, int member_point, List<string> shoppingCart, List<int> quantity)
    {
        this.member_point = member_point;
        this.shoppingCart = shoppingCart;
        this.quantity = quantity;
    }
    ~clientObject() { }
    public void addProduct(string id, int quantity)
    {
        //lấy sản phẩm
        shoppingCart.Add(id);
        this.quantity.Add(quantity);
    }
    public void removeProduct(string id)
    {
        //xóa sản phẩm
        int index = shoppingCart.IndexOf(id);
        shoppingCart.RemoveAt(index);
        quantity.RemoveAt(index);
    }
    //tính giá tiền sản phẩm
};

public class employeeObject : human
{
    protected string position { get; set; } //chức vụ
    protected double salary { get; set; }
    protected int shift { get; set; } //shift: ca làm việc
    protected string workPlace { get; set; }
    protected date workDate { get; set; }
    employeeObject() : base(int ID, string name, date birth, string gender, Location address, string phone, string userName, string password)
    {
        position = "";
        salary = 0;
        shift = 0;
        workPlace = "";
        workDate = "";
        ID = "";
        name = "";
        gender = "";
        birth = "";
        phone = "";
        workAddress = "";
        workUserName = "";
        workPassword = "";
    }
    employeeObject(string position, double salary, string workTime, string workPlace, string workDay, string workMonth, string workYear, string workStatus, string workID, string workName, string workGender, string workBirth, string workPhone, string workAddress, string workUserName, string workPassword)
    {
        this.position = position;
        this.salary = salary;
        this.workTime = workTime;
        this.workPlace = workPlace;
        this.workDay = workDay;
        this.workMonth = workMonth;
        this.workYear = workYear;
        this.workStatus = workStatus;
        this.workID = workID;
        this.workName = workName;
        this.workGender = workGender;
        this.workBirth = workBirth;
        this.workPhone = workPhone;
        this.workAddress = workAddress;
        this.workUserName = workUserName;
        this.workPassword = workPassword;
    }
    ~employeeObject() { }
    public void addProduct()
    {
        //thêm sản phẩm
    }
    public void removeProduct()
    {
        //xóa
    }
};
}