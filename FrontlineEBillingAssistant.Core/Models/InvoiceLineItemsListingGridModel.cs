using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Core.Models
{
    public class InvoiceLineItemsListingGridModel
    {
        public string Type { get; set; }
        public int LineItemId
        {
            get;
            set;
        }
        public String Date
        {
            get;
            set;
        }
        public string Task
        {
            get;
            set;
        }
        public string Activity
        {
            get;
            set;
        }
        public string Timekeeper
        {
            get;
            set;
        }
        public int Timekeeper_Id
        {
            get;
            set;
        }
        public string TimekeeperInitial
        {
            get;
            set;
        }
        public string TkLevel
        {
            get;
            set;
        }
        public string Rule
        {
            get;
            set;
        }
        public string RuleCategory
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string Tags
        {
            get;
            set;
        }
        public decimal Units
        {
            get;
            set;
        }
        public string Rate
        {
            get;
            set;
        }
        public string Discounts
        {
            get;
            set;
        }
        public string Total
        {
            get;
            set;
        }
        public string Changes
        {
            get;
            set;
        }
        public decimal OriginalDiff
        {
            get;
            set;
        }
        public int InvoiceMatter_Id { get; set; }
        public int Invoice_Id
        {
            get;
            set;
        }
        public int Matter_Id
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
        public bool HasCommunication
        {
            get;
            set;
        }
        public bool HasNewCommunication
        {
            get;
            set;
        }
        public string HasCommunicationDisplay
        {
            get;
            set;
        }
        public string Comments
        {
            get;
            set;
        }
        public string SendQueriesTo
        {
            get;
            set;
        }
        public string PreperationNotes
        {
            get;
            set;
        }
        public decimal UnitsOld
        {
            get;
            set;
        }
        public string RateOld
        {
            get;
            set;
        }
        public string DiscountOld
        {
            get;
            set;
        }
        public string ActivityOld
        {
            get;
            set;
        }
        public string TaskOld
        {
            get;
            set;
        }
        public string TimekeeperInitialOld
        {
            get;
            set;
        }
        public string TotalOld
        {
            get;
            set;
        }
        public string DescriptionOld
        {
            get;
            set;
        }
        public String DateOld
        {
            get;
            set;
        }
        public bool IsModified
        {
            get;
            set;
        }
        public int LineItemStatus
        {
            get;
            set;
        }
        public bool SaveStatus
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }
        public string ChargeType
        {
            get;
            set;
        }
        public int DiscountCreditCategory
        {
            get;
            set;
        }
        public string AgreedRate
        {
            get;
            set;
        }
        public string BillType
        {
            get;
            set;
        }
        public int? OrgLineNumber
        {
            get;
            set;
        }
        public string LineItemType
        {
            get;
            set;
        }
    }
}
