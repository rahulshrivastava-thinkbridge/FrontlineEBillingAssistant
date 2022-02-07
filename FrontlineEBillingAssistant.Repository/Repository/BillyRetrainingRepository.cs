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
    public class BillyRetrainingRepository : Repository<BillyFeedbackRetrainingTable>, IBillyRetrainingRepository
    {
        public BillyRetrainingRepository(EBillingContext eBillingContext) : base(eBillingContext) { }

        //public Task<IEnumerable<BillyFeedbackRetrainingTable>> GetAllRetrainingData() { }
        //public Task<IEnumerable<BillyFeedbackRetrainingTable>> GetRetrainingDataByLawFirmId(string lawFirmId);
        public int InsertRetrainingData(IEnumerable<BillyFeedbackRetrainingTable> lstmodel)
        {
            int rowsAffected = 0;
            List<SqlParameter> param = null;
            string sql = "EXEC [dbo].[InsertUpdateRetrainingData] @InvoiceID, @InvoiceLineItemID, @InvoiceDate, @UploadedDate, @LawFirmID, @ClientID, @TimekeeperID, @Units, @Rate, @BaseAmount, @TotalAmount, @ChargeDescription, @TaskCode, @TaskExpenseCode, @PreparationNotes, @MLPreparationNotes, @AgreedRate, @IsModified, @IsRetrained";

            foreach (BillyFeedbackRetrainingTable model in lstmodel)
            {
                param = new List<SqlParameter>
                {
                    new SqlParameter { ParameterName = "@InvoiceID", Value = model.InvoiceID, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@InvoiceLineItemID", Value = model.InvoiceLineItemID, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@InvoiceDate", Value = string.IsNullOrEmpty(model.InvoiceDate) ? DBNull.Value : model.InvoiceDate, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@UploadedDate", Value = string.IsNullOrEmpty(model.UploadedDate) ? DBNull.Value : model.UploadedDate, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@LawFirmID", Value = string.IsNullOrEmpty(model.LawFirmID) ? DBNull.Value : model.LawFirmID, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@ClientID", Value = string.IsNullOrEmpty(model.ClientID) ? DBNull.Value : model.ClientID, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@TimekeeperID", Value = string.IsNullOrEmpty(model.TimekeeperID) ? DBNull.Value : model.TimekeeperID, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@Units", Value = model.Units.Equals(null) ? 0 : model.Units, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@Rate", Value = model.Rate.Equals(null) ? 0 : model.Rate, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@BaseAmount", Value = model.BaseAmount.Equals(null) ? 0 : model.BaseAmount, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@TotalAmount", Value = model.TotalAmount.Equals(null) ? 0 : model.TotalAmount, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@ChargeDesciption", Value = string.IsNullOrEmpty(model.ChargeDescription) ? DBNull.Value : model.ChargeDescription, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@TaskCode", Value = string.IsNullOrEmpty(model.TaskCode) ? DBNull.Value : model.TaskCode, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@TaskExpenseCode", Value = string.IsNullOrEmpty(model.TaskExpenseCode) ? DBNull.Value : model.TaskExpenseCode, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@PreparationNotes", Value = string.IsNullOrEmpty(model.PreparationNotes) ? "..." : model.PreparationNotes, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@MLPreparationNotes", Value = string.IsNullOrEmpty(model.MLPreparationNotes) ? "..." : model.MLPreparationNotes, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@AgreedRate", Value = model.AgreedRate.Equals(null) ? 0 : model.AgreedRate, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@IsModified", Value = model.IsModified ? 1 : 0, Direction = System.Data.ParameterDirection.Input },
                    new SqlParameter { ParameterName = "@IsRetrained", Value = model.IsRetrained ? 1 : 0, Direction = System.Data.ParameterDirection.Input }
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

        public string GetRetrainingResponse(string strResponseMessage)
        {
            int rowsAffected = 0;
            string retVal = string.Empty;
            string sql = "EXEC [dbo].[UpdateRetrainingTable] @Status";
            List<SqlParameter> param = null;

            if (!string.IsNullOrEmpty(strResponseMessage))
            {
                if (strResponseMessage == "Success")
                {
                    param = new List<SqlParameter>
                    {
                        new SqlParameter { ParameterName = "@Status", Value = "S", Direction = System.Data.ParameterDirection.Input }
                    };

                    retVal = "Success";
                }
                else
                {
                    param = new List<SqlParameter>
                    {
                        new SqlParameter { ParameterName = "@Status", Value = "F", Direction = System.Data.ParameterDirection.Input }
                    };

                    retVal = "Error";
                }

                try
                {
                    rowsAffected += _ebillingContext.Database.ExecuteSqlRaw(sql, param);
                }
                catch (Exception)
                {
                    rowsAffected = 0;
                }
            }
            else
            {
                retVal = "Error";
            }

            return retVal;
        }
    }
}
