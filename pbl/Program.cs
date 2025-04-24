using inforProduct;
using pbl.entity_class;
using pbl.Manager.BLL;
using pbl.Manager.Interface;

namespace pbl
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            ICategoryManagement categoryService = new categoryManagement();
            // Thêm một danh mục mẫu
            var catFood = new category(1, "Thực phẩm", new List<product>(), "Các sản phẩm thực phẩm hàng ngày");
            await categoryService.AddCategory(catFood);

            // Khởi tạo InventoryHistoryManagement
            IInventoryHistory historyService = new InventoryHistoryManagement();

            // Khởi tạo InventoryManagement (với history được inject)
            IInventoryManagement inventoryService = new InventoryManagement(historyService);

            // Khởi tạo ProductManagement với category và inventory được inject
            IProductManagement productService = new productManagement(categoryService, inventoryService);

            // Khởi tạo PaymentManagement
            IPaymentManagement paymentManagement = new PaymentMangement();

            // Khởi tạo RequestManagement
            IRequestManagement requestService = new RequestManagement(inventoryService);


            // Thêm sản phẩm mẫu
            // Tạo 2 sản phẩm thuộc danh mục 1 và nhập thêm hàng cho 2 sản phẩm này:
            var prodBanhMi = new product(101, "Bánh mì", "Bánh mì tươi", 1, 15000, true, 10, true);
            var prodSua = new product(102, "Sữa", "Sữa tươi", 1, 22000, true, 5, true);
            await productService.AddProduct(prodBanhMi);
            await productService.AddProduct(prodSua);
            await inventoryService.ImportOrReturnStock(prodBanhMi.id_product, 500, "Import");
            await inventoryService.ImportOrReturnStock(prodSua.id_product, 500, "Import");

            //  Khởi tạo OrderManagement
            IOrderManagement orderService = new OrderManagement(productService, inventoryService);

            // Tạo một giỏ hàng (ShoppingCart) và thêm một số sản phẩm
            ShoppingCart cart = new ShoppingCart();
            cart.AddItem(new ShoppingCartItem(prodBanhMi.id_product, prodBanhMi.name_product, prodBanhMi.price, 2));
            cart.AddItem(new ShoppingCartItem(prodSua.id_product, prodSua.name_product, prodSua.price, 1));
            cart.DisplayCart();

            // Khách muốn thay đổi số lượng: tăng bánh mì thêm 1, giảm số lượng sữa xuống 0 (sẽ xóa khỏi giỏ)
            cart.IncrementItemQuantity(prodBanhMi.id_product, 1);
            cart.DecrementItemQuantity(prodSua.id_product, 1);
            cart.DisplayCart();

            // Cập nhật số lượng bánh mì thành 3
            cart.UpdateItemQuantity(prodBanhMi.id_product, 3);
            cart.DisplayCart();

            //  Khi khách hàng nhấn "Xác nhận đơn hàng", gọi ConfirmOrder
            var orderCreated = await cart.ConfirmOrder("Nguyễn Văn A", orderService);
            if (orderCreated != null)
            {
                Console.WriteLine("\n✅ Đơn hàng đã được tạo thành công!");
            }
            else
                Console.WriteLine("\n❌ Tạo đơn hàng thất bại.");

            // Hiển thị tất cả các đơn hàng đã tạo
            await orderService.DisplayAllOrder();
            TimeSpan s = TimeSpan.FromSeconds(1);
            TimeSpan a = TimeSpan.FromSeconds(5);

            //Task.Delay(a);
            // Hủy đơn hàng
            //await orderService.CancelOrder(orderCreated.OrderId);

            //Thanh toán đơn hàng
            //await paymentManagement.Process(orderCreated, PaymentMethod.BankTransfer);

            //Hiển thị lại
            await orderService.DisplayAllOrder();

            // Hiển thị lịch sử nhap xuat kho
            await historyService.Display();
            
            //Yêu cầu trả hàng
            var aa=await requestService.CreateReturnRequestAsync(orderCreated.OrderId,prodBanhMi.id_product,3,"hang deu vcl",null);
            requestService.DisplayRequest();
            await requestService.ApproveRequestAsync(aa.ReturnId);
            requestService.DisplayRequest();



            Console.WriteLine("\n--- Demo hoàn tất ---");
            Console.ReadLine();
        }
    }
}

