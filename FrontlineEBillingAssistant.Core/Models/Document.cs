using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class Document
    {
        public Document()
        {
            ClientDocuments = new HashSet<ClientDocument>();
            InvoiceDocuments = new HashSet<InvoiceDocument>();
            MatterDocuments = new HashSet<MatterDocument>();
            PayerDocuments = new HashSet<PayerDocument>();
        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public int DocumentCategoryId { get; set; }
        public string UploadedFileName { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual MasterDocumentCategory DocumentCategory { get; set; }
        public virtual ICollection<ClientDocument> ClientDocuments { get; set; }
        public virtual ICollection<InvoiceDocument> InvoiceDocuments { get; set; }
        public virtual ICollection<MatterDocument> MatterDocuments { get; set; }
        public virtual ICollection<PayerDocument> PayerDocuments { get; set; }
    }
}
