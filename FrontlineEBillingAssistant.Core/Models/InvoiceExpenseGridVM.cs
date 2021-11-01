using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Core.Models
{
    public class InvoiceExpenseGridVM
    {
        #region Properties

        #region Date
        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        /// <value>The Date.</value>
        public string Date
        {
            get;
            set;
        }
        #endregion Date

        #region ExpenseCode
        /// <summary>
        /// Gets or sets the ExpenseCode.
        /// </summary>
        /// <value>The ExpenseCode.</value>
        public string ExpenseCode
        {
            get;
            set;
        }
        #endregion ExpenseCode

        #region Rule
        /// <summary>
        /// Gets or sets the Rule.
        /// </summary>
        /// <value>The Rule.</value>
        public string Rule
        {
            get;
            set;
        }
        #endregion Rule

        #region Description
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        /// <value>The Description.</value>
        public string Description
        {
            get;
            set;
        }
        #endregion Description

        #region Tags
        /// <summary>
        /// Gets or sets the Tags.
        /// </summary>
        /// <value>The Tags.</value>
        public string Tags
        {
            get;
            set;
        }
        #endregion Tags

        #region Units
        /// <summary>
        /// Gets or sets the Units.
        /// </summary>
        /// <value>The Units.</value>
        public string Units
        {
            get;
            set;
        }
        #endregion Units

        #region Rate
        /// <summary>
        /// Gets or sets the Rate.
        /// </summary>
        /// <value>The Rate.</value>
        public string Rate
        {
            get;
            set;
        }
        #endregion Rate

        #region Discounts
        /// <summary>
        /// Gets or sets the Discounts.
        /// </summary>
        /// <value>The Discounts.</value>
        public string Discounts
        {
            get;
            set;
        }
        #endregion Discounts

        #region LineItemTaxTotal

        /// <summary>
        /// Gets or sets the LineItemTaxTotal.
        /// </summary>
        /// <value>The LineItemTaxTotal.</value>
        public string LineItemTaxTotal
        {
            get;
            set;
        }

        #endregion LineItemTaxTotal

        #region Total
        /// <summary>
        /// Gets or sets the Total.
        /// </summary>
        /// <value>The Total.</value>
        public string Total
        {
            get;
            set;
        }
        #endregion Total

        #region Changes
        /// <summary>
        /// Gets or sets the Changes.
        /// </summary>
        /// <value>The Changes.</value>
        public string Changes
        {
            get;
            set;
        }
        #endregion Changes

        #endregion Properties
    }
}
