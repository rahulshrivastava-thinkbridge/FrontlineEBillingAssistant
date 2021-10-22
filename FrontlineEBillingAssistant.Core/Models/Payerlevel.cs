using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class Payerlevel
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public int CountOfSubTask { get; set; }
        public int CountOfSuccess { get; set; }
        public int CountOfFailure { get; set; }
        public int Status { get; set; }
        public string LogicalFileName { get; set; }
        public string ActualFileName { get; set; }
        public int? InvoiceId { get; set; }
        public int? InvoiceFileId { get; set; }
        public string Input { get; set; }
        public string ShortMessage { get; set; }
        public string Message { get; set; }
        public int? ObjectId { get; set; }
        public int? ObjectType { get; set; }
        public int? ParentTaskId { get; set; }
        public int? TaskRequestingUserId { get; set; }
        public DateTime TaskRequestedTime { get; set; }
        public DateTime? TaskCompletionTime { get; set; }
        public DateTime? TaskUpdateTime { get; set; }
        public string Tags { get; set; }
        public int? ActionStatus { get; set; }
        public string LogicalInputFileName { get; set; }
        public string ActualInputFileName { get; set; }
        public int? OwnerId { get; set; }
    }
}
