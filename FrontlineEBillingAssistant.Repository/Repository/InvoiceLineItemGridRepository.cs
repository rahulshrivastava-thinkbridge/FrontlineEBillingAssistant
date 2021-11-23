using FrontlineEBillingAssistant.Core.Data;
using FrontlineEBillingAssistant.Core.Models;
using FrontlineEBillingAssistant.Repository.Interface;
using FrontlineEBillingAssistant.Repository.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            catch (Exception ex)
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
                    new SqlParameter { ParameterName = "@Id", Value = model.LineItemId },
                    new SqlParameter { ParameterName = "@RuleCode", Value = model.Rule },
                    new SqlParameter { ParameterName = "@Units", Value = model.Units },
                    new SqlParameter { ParameterName = "@Rate", Value = model.Rate },
                    new SqlParameter { ParameterName = "@AgreedRate", Value = model.AgreedRate },
                    new SqlParameter { ParameterName = "@Discounts", Value = model.Discounts },
                    new SqlParameter { ParameterName = "@Total", Value = model.Total },
                    new SqlParameter { ParameterName = "@Tags", Value = model.Tags },
                    new SqlParameter { ParameterName = "@ChargeDate", Value = model.Date },
                    new SqlParameter { ParameterName = "@TaskCode", Value = model.Task },
                    new SqlParameter { ParameterName = "@TaskActivityCode", Value = model.Activity },
                    new SqlParameter { ParameterName = "@TimeKeeperInitial", Value = model.TimekeeperInitial },
                    new SqlParameter { ParameterName = "@ChargeDesciption", Value = model.Description },
                    new SqlParameter { ParameterName = "@PreparationNotes", Value = model.PreperationNotes },
                    new SqlParameter { ParameterName = "@MLPreparationNotes", Value = model.MLPreparationNotes }
                };

                try
                {
                    rowsAffected += _ebillingContext.Database.ExecuteSqlRaw(sql, param.ToArray());
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
