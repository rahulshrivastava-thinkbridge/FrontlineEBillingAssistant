using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Core.Models
{
    public class InvoiceSummaryDetailsVM
    {
        #region SummaryItem

        /// <summary>
        /// Gets or sets the SummaryItem.
        /// </summary>
        /// <value>The SummaryItem.</value>
        [Display(Name = "tEST")]
        public string SummaryItem
        {
            get;
            set;
        }

        #endregion SummaryItem

        #region Submitted

        /// <summary>
        /// Gets or sets the Submitted.
        /// </summary>
        /// <value>The Submitted.</value>
        [Display(Name = "Original")]
        public decimal Submitted
        {
            get;
            set;
        }

        #endregion Submitted

        #region Reduction

        /// <summary>
        /// Gets or sets the Reduction.
        /// </summary>
        /// <value>The Reduction.</value>
        [Display(Name = "Changes")]
        public decimal Reduction
        {
            get;
            set;
        }

        #endregion Reduction

        #region Final

        /// <summary>
        /// Gets or sets the Final.
        /// </summary>
        /// <value>The Final.</value>
        [Display(Name = "Final")]
        public decimal Final
        {
            get;
            set;
        }

        #endregion Final
    }
}
