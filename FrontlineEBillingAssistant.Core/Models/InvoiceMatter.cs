using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceMatter
    {
        public InvoiceMatter()
        {
            CustomFields = new HashSet<CustomField>();
            InvoiceLineItemInvoiceMatterId1Navigations = new HashSet<InvoiceLineItem>();
            InvoiceLineItemInvoiceMatterId2Navigations = new HashSet<InvoiceLineItem>();
            InvoiceLineItemInvoiceMatterId3Navigations = new HashSet<InvoiceLineItem>();
            InvoiceLineItemInvoiceMatters = new HashSet<InvoiceLineItem>();
            InvoiceTaxSummaries = new HashSet<InvoiceTaxSummary>();
            InvoiceTimekeeperSummaries = new HashSet<InvoiceTimekeeperSummary>();
        }

        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int? MatterId { get; set; }
        public string ClientMatterId { get; set; }
        public string LawFirmMatterId { get; set; }
        public string MatterName { get; set; }
        public string MatterDescription { get; set; }
        public string PoNumber { get; set; }
        public string AccountType { get; set; }
        public string ManagingContactLastName { get; set; }
        public string ManagingContactFirstName { get; set; }
        public string ManagingContactContactCode { get; set; }
        public string ManagingContactPhone { get; set; }
        public string ManagingContactFax { get; set; }
        public string ManagingContactEmail { get; set; }
        public string LawFirmContactLastName { get; set; }
        public string LawFirmContactFirstName { get; set; }
        public string LawFirmContactContactCode { get; set; }
        public string LawFirmContactPhone { get; set; }
        public string LawFirmContactFax { get; set; }
        public string LawFirmContactEmail { get; set; }
        public string ClientContactLastName { get; set; }
        public string ClientContactFirstName { get; set; }
        public string ClientContactContactCode { get; set; }
        public string ClientContactPhone { get; set; }
        public string ClientContactFax { get; set; }
        public string ClientContactEmail { get; set; }
        public int BillingType { get; set; }
        public bool IsFinalBill { get; set; }
        public decimal TotalFees { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal TotalFeesDiscount { get; set; }
        public decimal TotalExpenseDiscount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal DiscountFeesSharePercentage { get; set; }
        public decimal DiscountExpenseSharePercentage { get; set; }
        public decimal DiscountFeesBillPercentage { get; set; }
        public decimal DiscountExpenseBillPercentage { get; set; }
        public decimal FeesTax { get; set; }
        public decimal ExpenseTax { get; set; }
        public decimal NetFees { get; set; }
        public decimal NetExpense { get; set; }
        public decimal FundsApplied { get; set; }
        public decimal NetTotal { get; set; }
        public int FileItemNumber { get; set; }
        public decimal TotalFeesModified { get; set; }
        public decimal TotalExpensesModified { get; set; }
        public decimal TotalFeesDiscountModified { get; set; }
        public decimal TotalExpenseDiscountModified { get; set; }
        public decimal TotalDiscountModified { get; set; }
        public decimal DiscountFeesSharePercentageModified { get; set; }
        public decimal DiscountExpenseSharePercentageModified { get; set; }
        public decimal DiscountFeesBillPercentageModified { get; set; }
        public decimal DiscountExpenseBillPercentageModified { get; set; }
        public decimal FeesTaxModified { get; set; }
        public decimal ExpenseTaxModified { get; set; }
        public decimal NetFeesModified { get; set; }
        public decimal NetExpenseModified { get; set; }
        public decimal FundsAppliedModified { get; set; }
        public decimal NetTotalModified { get; set; }
        public string AddlReferenceNo { get; set; }
        public string MatterNameModified { get; set; }
        public string ClientMatterIdModified { get; set; }
        public string LawFirmMatterIdModified { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Matter Matter { get; set; }
        public virtual ICollection<CustomField> CustomFields { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemInvoiceMatterId1Navigations { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemInvoiceMatterId2Navigations { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemInvoiceMatterId3Navigations { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemInvoiceMatters { get; set; }
        public virtual ICollection<InvoiceTaxSummary> InvoiceTaxSummaries { get; set; }
        public virtual ICollection<InvoiceTimekeeperSummary> InvoiceTimekeeperSummaries { get; set; }
    }
}
