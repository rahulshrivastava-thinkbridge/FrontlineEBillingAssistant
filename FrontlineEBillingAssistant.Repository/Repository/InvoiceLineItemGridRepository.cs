using FrontlineEBillingAssistant.Core.Data;
using FrontlineEBillingAssistant.Core.Models;
using FrontlineEBillingAssistant.Repository.Interface;
using FrontlineEBillingAssistant.Repository.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Repository.Repository
{
    public class InvoiceLineItemGridRepository : Repository<InvoiceLineItemsListingGridModel>, IInvoiceLineItemGridRepository
    {
        public InvoiceLineItemGridRepository(EBillingContext eBillingContext) : base(eBillingContext) { }

        public async Task<IEnumerable<InvoiceLineItemsListingGridModel>> GetInvoiceLineItemsListing(int Id)
        {
            try
            {
                return await _ebillingContext.InvoiceLineItemsListingGrid.FromSqlRaw<InvoiceLineItemsListingGridModel>("GetInvoiceLineItemsById {0}", Id).ToListAsync();
            }
            catch (Exception)
            {
                return new List<InvoiceLineItemsListingGridModel>();
            }
        }

        public int UpdateInvoiceLineItems(IEnumerable<InvoiceLineItemsListingGridModel> lstmodel)
        {
            int rowsAffected = 0;
            List<SqlParameter> param = null;
            string sql = "EXEC [dbo].[UpdateInvoiceLineItems] @Id, @RuleCode, @Units, @Rate, @AgreedRate, @Discounts, @Total, @Tags, @ChargeDate, @TaskCode, @TaskActivityCode, @TimeKeeperInitial, @ChargeDesciption, @PreparationNotes, @MLPreparationNotes";

            foreach (InvoiceLineItemsListingGridModel model in lstmodel)
            {
                param = new List<SqlParameter>
                {
                    new SqlParameter { ParameterName = "@Id", Value = model.LineItemId, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@RuleCode", Value = string.IsNullOrEmpty(model.Rule) ? DBNull.Value : model.Rule, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@Units", Value = model.Units.Equals(null) ? 0 : model.Units, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@Rate", Value = string.IsNullOrEmpty(model.Rate) ? DBNull.Value : model.Rate, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@AgreedRate", Value = string.IsNullOrEmpty(model.AgreedRate) ? DBNull.Value : model.AgreedRate, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@Discounts", Value = string.IsNullOrEmpty(model.Discounts) ? DBNull.Value : model.Discounts, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@Total", Value = string.IsNullOrEmpty(model.Total) ? DBNull.Value : model.Total, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@Tags", Value = string.IsNullOrEmpty(model.Tags) ? DBNull.Value : model.Tags, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@ChargeDate", Value = string.IsNullOrEmpty(model.Date) ? DBNull.Value : model.Date, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@TaskCode", Value = string.IsNullOrEmpty(model.Task) ? DBNull.Value : model.Task, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@TaskActivityCode", Value = string.IsNullOrEmpty(model.Activity) ? DBNull.Value : model.Activity, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@TimeKeeperInitial", Value = string.IsNullOrEmpty(model.TimekeeperInitial) ? DBNull.Value : model.TimekeeperInitial, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@ChargeDesciption", Value = string.IsNullOrEmpty(model.Description) ? DBNull.Value : model.Description, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@PreparationNotes", Value = string.IsNullOrEmpty(model.PreperationNotes) ? "..." : model.PreperationNotes, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@MLPreparationNotes", Value = string.IsNullOrEmpty(model.MLPreparationNotes) ? "..." : model.MLPreparationNotes, Direction = System.Data.ParameterDirection.Input }
                };

                try
                {
                    rowsAffected += _ebillingContext.Database.ExecuteSqlRaw(sql, param);
                }
                catch (Exception)
                {
                    rowsAffected = 0;
                }
            }            

            return rowsAffected;
        }
    }
}
