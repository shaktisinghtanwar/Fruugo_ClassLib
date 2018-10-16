using FruugoSdkLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FruugoSdkLib.Messages
{
   public  class ReturnOrderRequest
    {
        public int OrderId { get; set; }
        public Item Item { get; set; }
        public string returnReason { get; set; }
        public string MessageToCustomer { get; set; }
        public string MessageToFruugo { get; set; }
    }
}
