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
    
    public partial class Operation_Dtls
    {
        public int Operation_ID { get; set; }
        public int Patient_ID { get; set; }
        public int Gu_No { get; set; }
        public int Gu_Year { get; set; }
        public int SR_No { get; set; }
        public Nullable<System.DateTime> Operation_Dte { get; set; }
        public string Anesthesia { get; set; }
        public Nullable<int> Anaesthesiologist { get; set; }
        public string Opern_Procedure { get; set; }
        public string Details { get; set; }
        public string Remarks { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Dte { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Dte { get; set; }
    
        public virtual Doctors_List Doctors_List { get; set; }
        public virtual Patient_Info Patient_Info { get; set; }
    }
}
