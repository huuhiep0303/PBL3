using humanFeature;

namespace employee
{
    public class employeeObject : human
    {
        protected string position { get; set; } //chức vụ
        protected double salary { get; set; }
        protected int shift { get; set; } //shift: ca làm việc
        protected Location workPlace { get; set; }
        protected date workDate { get; set; }
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
        // public void addProduct()
        // {
        //     //thêm sản phẩm
        // }
        // public void removeProduct()
        // {
        //     //xóa
        // }

        class manageStore : employeeObject
        {
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
            public void caculator()
            {

            }
        }

        class presidant : employeeObject
        {

            protected List<manageStore> employeeList;
            protected List<double> salary;
            protected void addNewEmployee(employeeObject newEmployee)
            {

            }
        };
    };
}
