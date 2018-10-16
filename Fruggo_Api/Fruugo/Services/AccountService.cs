using FruugoSdkLib.Services;

namespace FruugoSdkLib
{
    public class AccountService
    {
        public AccountService()
        {
            OrderService = new OrderService();
        }
        public OrderService OrderService { get; set; }
    }
}
