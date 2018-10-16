using FruugoSdkLib.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FruugoSdkLib.Services
{
   public class OrderService
    {
        string _url;
        public OrderService()
        {
            _url = string.Format("");
        }
        public async Task<DownloadOrdersResponse> GetDownloadOrders(DownloadOrdersRequest downloadorderRequest)
        {
            DateTime fromdate = downloadorderRequest.ToDtaetime;
            DateTime TodateTime = downloadorderRequest.ToDtaetime;
           // string url = "download";
            RestHelper helper = new RestHelper("download?id={" + fromdate + "," + TodateTime + "}");
            var response = await helper.Get();
            //var downloadorderRespose = JsonConvert.DeserializeObject<DownloadOrdersResponse>(response);
            return null;
        }
        public async Task<ConfirmOrdersResponse> PostConfirmOrders(ConfirmOrdersRequest confirmOrdersRequest)
        {
            var body = JsonConvert.SerializeObject(confirmOrdersRequest);
            _url = "confirm";
            RestHelper helper = new RestHelper(_url);
            var response = await helper.Post(body);
           // var  accountRespose = JsonConvert.DeserializeObject<AccountRespose>(response);
            return null;
        }

        public async Task<ConfirmOrdersResponse> PostCancelOrders(CancelOrderRequest cancelOrderRequest)
        {
            var body = JsonConvert.SerializeObject(cancelOrderRequest);
            _url = "confirm";
            RestHelper helper = new RestHelper(_url);
            var response = await helper.Post(body);
           // var  accountRespose = JsonConvert.DeserializeObject<AccountRespose>(response);
            return null;
        }

        public async Task<ConfirmOrdersResponse> PostShipOrder(ShipOrderRequest shipOrderRequest)
        {
            var body = JsonConvert.SerializeObject(shipOrderRequest);
            _url = "ship";
            RestHelper helper = new RestHelper(_url);
            var response = await helper.Post(body);
            // var  accountRespose = JsonConvert.DeserializeObject<AccountRespose>(response);
            return null;
        }

        public async Task<ConfirmOrdersResponse> PostReturnOrder(ReturnOrderRequest returnOrderRequest)
        {
            var body = JsonConvert.SerializeObject(returnOrderRequest);
            _url = "return";
            RestHelper helper = new RestHelper(_url);
            var response = await helper.Post(body);
            // var  accountRespose = JsonConvert.DeserializeObject<AccountRespose>(response);
            return null;
        }

        public async Task<DownloadPackingListResponse> GetDownloadPackingList(DownloadPackingListRequest downloadPackingListRequest)
        {
            int orderId = downloadPackingListRequest.OrderId;
            int shipmentid  = downloadPackingListRequest.ShipmentId;
            
            RestHelper helper = new RestHelper("packinglist?id={" + orderId + "," + shipmentid + "}");
            var response = await helper.Get();
            //var downloadPackingListResponse = JsonConvert.DeserializeObject<DownloadPackingListResponse>(response);
            return null;
        }
    }
}
