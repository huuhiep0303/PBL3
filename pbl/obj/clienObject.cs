using System.Collections.Generic;
using System.Net;
using System.Xml.Linq;
using humanFeature;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace client { 
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


}