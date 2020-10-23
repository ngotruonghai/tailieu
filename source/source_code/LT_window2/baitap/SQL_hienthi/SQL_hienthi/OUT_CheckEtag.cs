//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQL_hienthi
{
    using System;
    using System.Collections.Generic;
    
    public partial class OUT_CheckEtag
    {
        public System.Guid OutCheckEtagID { get; set; }
        public string EtagId { get; set; }
        public System.DateTime CheckDate { get; set; }
        public System.DateTime InCheckDate { get; set; }
        public int CheckTime { get; set; }
        public string ReceiptNo { get; set; }
        public int ChargeAmount { get; set; }
        public int TicketTypeID { get; set; }
        public int VehicleTypeID { get; set; }
        public int RouteID { get; set; }
        public int EmployeeID { get; set; }
        public int LaneID { get; set; }
        public Nullable<int> InLaneID { get; set; }
        public int ShiftID { get; set; }
        public int StationID { get; set; }
        public Nullable<int> InStationID { get; set; }
        public Nullable<short> PlateType { get; set; }
        public string RegisPlate { get; set; }
        public string RecogPlate { get; set; }
        public string InRecogPlate { get; set; }
        public Nullable<short> RecogResultType { get; set; }
        public Nullable<bool> IsIntelligentVerified { get; set; }
        public Nullable<short> IntelVerifyResult { get; set; }
        public string ImageID { get; set; }
        public string InImageID { get; set; }
        public Nullable<short> ImageType { get; set; }
        public short PeriodTicket { get; set; }
        public Nullable<short> SupervisionStatus { get; set; }
        public Nullable<short> PreSupervisionStatus { get; set; }
        public Nullable<short> F0 { get; set; }
        public Nullable<short> F1 { get; set; }
        public Nullable<short> F2 { get; set; }
        public Nullable<int> FP { get; set; }
        public Nullable<int> FC { get; set; }
        public short TransactionStatus { get; set; }
        public string TicketID { get; set; }
        public Nullable<System.DateTime> CheckInDate { get; set; }
        public Nullable<System.DateTime> CommitDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ETCStatus { get; set; }
        public int PriceTicketType { get; set; }
        public Nullable<short> SyncStatus { get; set; }
        public short SyncFeBe { get; set; }
        public string SyncReturnMsg { get; set; }
        public int IsOnlineCheck { get; set; }
        public string TID { get; set; }
        public Nullable<int> ErrorID { get; set; }
        public string Notes { get; set; }
    }
}
