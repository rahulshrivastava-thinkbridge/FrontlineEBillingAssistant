using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcTokioMattersToMove06march2020
    {
        public int Id { get; set; }
        public int _ { get; set; }
        public string ClientMatterId { get; set; }
        public string LawFirmMatterId { get; set; }
        public string Mattername { get; set; }
        public string CurrentPname { get; set; }
        public string MovetoPname { get; set; }
        public int CurrentPayer { get; set; }
        public int Moveto { get; set; }
    }
}
