using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class LawFirmClientFileExchangeExportSetting
    {
        public int Id { get; set; }
        public int? LawFirmId { get; set; }
        public int? ClientId { get; set; }
        public DateTime? RunDate { get; set; }
        public DateTime? LastRunDate { get; set; }
        public string Format { get; set; }
        public string Ftppath { get; set; }
        public string FtpuserName { get; set; }
        public string Ftppassword { get; set; }
        public string ExportFolderPath { get; set; }
        public string Type { get; set; }
        public int? ExportType { get; set; }
        public bool? IsActive { get; set; }
    }
}
