﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMS.Utilities
{
    #region Enumerations

    /// <summary>
    /// Specifies the report format in which the report will be generated.
    /// </summary>
    /// <createdby>Amit Kumar Chandra</createdby>
    /// <createddate>30/06/2012</createddate>
    public enum ReportFormat
    {
        /// <summary>
        /// Report will be generated in PDF format.
        /// </summary>
        PDF = 1,
        /// <summary>
        /// Report will be generated in Ms-Excel format.
        /// </summary>
        Excel = 2,
        /// <summary>
        /// Report will be generated in XML format.
        /// </summary>
        XML = 3
    }

    public enum PageName
    {
        Voyage = 4,
        ImportBLChklst = 6,
        IGMFormII = 8,
        IGMFormC = 9,
        FileLandingGuranteeLetter = 12,
        ImportRegister = 14,
        CargoArrivalNotice = 15,
        UserMaster = 28,
        LocationMaster = 29,
        CustomerMaster = 30,
        LineMSOMaster = 31,
        AddressMaster = 32,
        ServiceTaxMaster = 33,
        ChargeMaster = 34,
        ContainerTypeMaster = 35,
        ExchangeRateMaster = 36,
        TerminalMaster = 37,
        CountryMaster = 38,
        PortMaster = 39,
        ImportHaulageChargeMaster = 40,
        VesselMaster = 41,
        RoleMaster = 113,
        ImportBL = 3,
        Invoice = 53,
    };

    public enum UserRole
    {
        Admin = 2,
        Management = 3,
        ImportUsers = 4,
        CFS = 5,
        Manager = 6,
        Surveyors = 7,
        EmptyYard = 8,
        ExportUsers = 10,
        Logistics = 12
    }

    #endregion

    public static class Constants
    {
        #region Constants

        //public const string EMAIL_REGX_EXP = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" + @"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" + @"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
        public const string EMAIL_REGX_EXP = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public const string PHONE_REGX_EXP = @"^((\(?\+?[0-9]*\)?)?[0-9_\- \(\)]*\/*)*$"; // @"^(\(?\+?[0-9]*\)?)?[0-9_\- \(\)]*$"; 
        public const string MOBILE_REGX_EXP = "";
        public const string DEFAULT_CULTURE = "en-US";
        public const string DATA_VALUE_FIELD = "ListItemValue";
        public const string DATA_TEXT_FIELD = "ListItemText";
        public const string DROPDOWNLIST_DEFAULT_VALUE = "0";
        public const string DROPDOWNLIST_DEFAULT_TEXT = "--Select--";
        public const string DROPDOWNLIST_ALL_TEXT = "All";
        public const string NOT_AVAILABLE_TEXT = "Not Available";
        public const string SORT_EXPRESSION = "SortExpression";
        public const string SORT_DIRECTION = "SortDirection";
        public const string DEFAULT_PASSWORD = "nvocc";
        public const int DEFAULT_COMPANY_ID = 1;

        #endregion

        #region Session Variables

        public const string SESSION_SEARCH_CRITERIA = "SearchCriteria";
        public const string SESSION_USER_INFO = "UserInfo";
        public const string SESSION_ERROR = "ErrorInfo";
        public const string SESSION_USER_PERMISSION = "UserPermission";
        public const string SESSION_ROLE_LOCATIONSPECIFIC = "UserLocationInfo";

        #endregion

        #region Query String

        public const string QUERT_STRING_PAGE_INDEX = "pindex";

        #endregion
    }
}
