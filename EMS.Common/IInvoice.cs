﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMS.Common
{
    public interface IInvoice
    {
        long InvoiceID { get; set; }
        int CompanyID { get; set; }
        int LocationID { get; set; }
        int NVOCCID { get; set; }
        int InvoiceTypeID { get; set; }
        long BookingID { get; set; }
        long BLID { get; set; }
        string ExportImport { get; set; }
        decimal XchangeRate { get; set; }
        string InvoiceNo { get; set; }
        DateTime InvoiceDate { get; set; }
        int CHAID { get; set; }
        string Account { get; set; }
        bool AllInFreight { get; set; }
        decimal GrossAmount { get; set; }
        decimal ServiceTax { get; set; }
        decimal ServiceTaxCess { get; set; }
        decimal ServiceTaxACess { get; set; }
        int UserAdded { get; set; }
        int UserLastEdited { get; set; }
        DateTime AddedOn { get; set; }
        DateTime EditedOn { get; set; }
        List<IChargeRate> ChargeRates { get; set; }
    }
}
