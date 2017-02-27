using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reservationApp.Models
{
    public class reservationModel
    {
        public string loc { get; set; }
        public string chkInDate { get; set; }
        public string chkOutDate { get; set; }
        public string room_Qty { get; set; }
    }
}