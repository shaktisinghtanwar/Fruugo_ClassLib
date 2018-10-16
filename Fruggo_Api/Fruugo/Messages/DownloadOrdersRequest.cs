using System;
using System.Collections.Generic;
using System.Text;

namespace FruugoSdkLib.Messages
{
   public  class DownloadOrdersRequest
    {
        public DateTime FromDateTime { get; set; }
        public DateTime ToDtaetime { get; set; }
    }
}
