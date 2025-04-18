using humanFeature;
using Order;
using OrderItem
namespace Employee
{
    public class EmployeeObject : human
    {
        protected double salary;
        protected int shift;//shift: ca làm việc
        protected Location workPlace;
        protected DateTime workDate;
        public EmployeeObject()
        {
            position = "";
            salary = 0;
            shift = 0;
            workDate = new DateTime(0, 0, 0);
        }

        public EmployeeObject(string position, double salary, int shift, Location workPlace, DateTime workDate)
        {
            this.position = position;
            this.salary = salary;
            this.shift = shift;
            this.workPlace = workPlace;
            this.workDate = workDate;
        }

        class ManageStore : EmployeeObject
        {
            public override string position = "Quản lí kho"; //chức vụ
            protected List<string> productList;
            protected List<double> price;
            protected List<int> quantity;

            public ManageStore()
            {
                this.salary = 0;
                this.shift = 0;
                this.productList = new List<string>();
                this.price = new List<double>();
                this.quantity = new List<int>();
            }

            public ManageStore(double salary, int shift, double efficiency)
            {
                this.salary = salary;
                this.shift = shift;
                this.efficiency = efficiency;
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

            //lấy hàng của kho hay là gửi thông báo tới quản lí kho
            public void takeProduct(string product, int quantity)
            {
                for (int i = 0; i < this.productList.Count; i++)
                {
                    if (this.productList[i] == product)
                    {
                        this.quantity[i] -= quantity;
                        break;
                    }
                }
            }
        }

       
