using humanFeature;
using inforProduct;
using billOrder;
namespace employee
{
    public class employeeObject : human
    {
        public abstract string position; //chức vụ
        protected double salary;
        protected int shift;//shift: ca làm việc
        protected Location workPlace;
        protected date workDate;
        public employeeObject()
        {
            position = "";
            salary = 0;
            shift = 0;
        }

        public employeeObject(string position, double salary, int shift, Location workPlace, date workDate)
        {
            this.position = position;
            this.salary = salary;
            this.shift = shift;
            this.workPlace = workPlace;
            this.workDate = workDate;
        }

        class manageStore : employeeObject
        {
            public override string position = "Quản lí kho"; //chức vụ
            protected double efficiency { get; set; } //hiệu suất làm việc trong tuần
            protected List<string> productList;
            protected List<double> price;
            protected List<int> quantity;

            public manageStore()
            {
                salary = 0;
                shift = 0;
                efficiency = 0;
            }

            public manageStore(double salary, int shift, double efficiency)
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

        class cashier : employeeObject
        {
            //cần gán cú pháp truy cập hệ cơ sở dữ liệu, giúp cho cashier thêm hoá đơn vào kho lưu trữ
            protected LinkedList<bill> billList;
            public override string position = "Thu ngân"; //chức vụ

            public cashier()
            {
                this.billList = new LinkedList<bill>();
            }

            public cashier(LinkedList<bill> billList)
            {
                this.billList = billList;
            }

            public void addBill(bill newBill)
            {
                this.billList.AddLast(newBill);
            }

            public void manageBill()
            {
                for (bill eachBill in LinkedList<bill> billList)
                {
                    Console.WriteLine(eachBill);
                    Console.WriteLine();
                }    
            }

            public void printBill(string idBill)
            {
                for(bill eachBill in LinkedList < bill > billList)
                {
                    if (eachBill.IDBill == idBill)
                    {
                        Console.WriteLine(eachBill);
                        Console.WriteLine();
                    }
                }
            }

            public void removeBill(string idBill)
            {
                for (bill eachBill in LinkedList < bill > billList)
                {
                    if (eachBill.IDBill == idBill)
                    {
                        billList.Remove(eachBill);
                        break;
                    }
                }
            }

            public void searchName(string name)
            {
                for (bill eachBill in LinkedList <bill> listBill)
                {
                    if(eachBill.whoBuy.name == name)
                    {
                        Console.WriteLine(eachBill);   
                        Console.WriteLine();
                    }
                }
            }
        }

        class presidant : employeeObject
        {
            public override string position = "Quản lí nhân sự"; //chức vụ
            protected LinkedList<manageStore> manageStoreList;
            protected LinkedList<cashier> cashierList;
            protected void addNewEmployee(employeeObject newEmployee)
            {
                if (newEmployee.position == "Quản lí kho")
                {
                    manageStoreList.AddLast(newEmployee);
                }
                else if (newEmployee.position == "Thu ngân")
                {
                    cashierList.AddLast(newEmployee);
                }
            }
        };
    };
}
