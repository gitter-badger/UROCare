//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SHC.UROCare.UROCareDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class IPD
    {
        public int IPD_ID { get; set; }
        public int Patient_ID { get; set; }
        public int Gu_No { get; set; }
        public int Gu_Year { get; set; }
        public int SR_No { get; set; }
        public string IPD_No { get; set; }
        public Nullable<System.DateTime> Admission_Dte { get; set; }
        public Nullable<System.DateTime> Discharge_Dte { get; set; }
        public string Complaints { get; set; }
        public string Advice { get; set; }
        public Nullable<System.DateTime> Followup_Dte { get; set; }
        public string IPD_Diagnosis { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Create_Dte { get; set; }
        public string Modify_By { get; set; }
        public Nullable<System.DateTime> Modify_Dte { get; set; }
    
        public virtual Patient_Info Patient_Info { get; set; }
    }
}
