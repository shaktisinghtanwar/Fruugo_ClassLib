using System;
using System.Collections.Generic;
using System.Text;

namespace FruugoSdkLib.Messages
{
    public class DownloadPackingListRequest
    {
        public int OrderId { get; set; }
        public int ShipmentId { get; set; }
    }
}
