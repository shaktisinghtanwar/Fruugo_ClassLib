using System;
using FruugoSdkLib.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FruugoSdkLib.Tests
{
    [TestClass]
    public class OrderDetailsTest
    {
        [TestMethod]
        public void DownloadOrderTest()
        {
            AccountService accountService = new AccountService();
            DateTime fromDateTime = DateTime.Now;
            DateTime toDateTime = fromDateTime.AddDays(2);
            FruugoSdkLib.Messages.DownloadOrdersRequest downloadorderRequest = new FruugoSdkLib.Messages.DownloadOrdersRequest();
            downloadorderRequest.FromDateTime = fromDateTime;
            downloadorderRequest.ToDtaetime = toDateTime;
            var response = accountService.OrderService.GetDownloadOrders(downloadorderRequest).Result;
           // Assert.IsNotNull(response);
        }
        [TestMethod]
        public void ConfirmOrderTest()
        {
            AccountService accountService = new AccountService();
            FruugoSdkLib.Messages.ConfirmOrdersRequest confirmOrdersRequest = new FruugoSdkLib.Messages.ConfirmOrdersRequest();
            confirmOrdersRequest.OrderId = 123;
            confirmOrdersRequest.Item = new FruugoSdkLib.Models.Item()
            {
                fruugoProductId = 1111,
                fruugoSkuId = 1234,
                quantity=10,
            };
            var response = accountService.OrderService.PostConfirmOrders(confirmOrdersRequest).Result;
           // Assert.IsNotNull(response);
        }
        [TestMethod]
        public void CancelOrderTest()
        {
            AccountService accountService = new AccountService();
            FruugoSdkLib.Messages.CancelOrderRequest cancelOrderRequest = new FruugoSdkLib.Messages.CancelOrderRequest();
            cancelOrderRequest.OrderId = 123;
            cancelOrderRequest.cancellationReason = "product is out of stock";
            var response = accountService.OrderService.PostCancelOrders(cancelOrderRequest).Result;
           // Assert.IsNotNull(response);
        }
        [TestMethod]
        public void ShipOrderTest()
        {
            AccountService accountService = new AccountService();
            FruugoSdkLib.Messages.ShipOrderRequest shipOrderRequest = new FruugoSdkLib.Messages.ShipOrderRequest();
            shipOrderRequest.OrderId = 123;
            var response = accountService.OrderService.PostShipOrder(shipOrderRequest).Result;
           // Assert.IsNotNull(response);
        }
        [TestMethod]
        public void ReturnOrderTest()
        {
            AccountService accountService = new AccountService();
            FruugoSdkLib.Messages.ReturnOrderRequest returnOrderRequest = new FruugoSdkLib.Messages.ReturnOrderRequest();
            returnOrderRequest.OrderId = 123;
            var response = accountService.OrderService.PostReturnOrder(returnOrderRequest).Result;
           // Assert.IsNotNull(response);
        }
        [TestMethod]
        public void DownloadPackingListTest()
        {
            AccountService accountService = new AccountService();
            FruugoSdkLib.Messages.DownloadPackingListRequest downloadPackingListRequest = new FruugoSdkLib.Messages.DownloadPackingListRequest();
            downloadPackingListRequest.OrderId = 123;
            downloadPackingListRequest.ShipmentId = 222;
            var response = accountService.OrderService.GetDownloadPackingList(downloadPackingListRequest).Result;
            //Assert.IsNotNull(response);
        }
    }
}
