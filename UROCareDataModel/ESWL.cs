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
    
    public partial class ESWL
    {
        public int ESWL_ID { get; set; }
        public int Patient_ID { get; set; }
        public int Gu_No { get; set; }
        public int Gu_Year { get; set; }
        public int SR_No { get; set; }
        public Nullable<System.DateTime> ESWL_Dte { get; set; }
        public string ESWL_Size { get; set; }
        public string Side { get; set; }
        public string Site { get; set; }
        public string Shock_Waves { get; set; }
        public string ESWL_Level { get; set; }
        public string Fluroscopy { get; set; }
        public string Analgesic { get; set; }
        public string IV_Fluids { get; set; }
        public string Complications { get; set; }
        public string Comments { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Create_Dte { get; set; }
        public string Modify_By { get; set; }
        public Nullable<System.DateTime> Modify_Dte { get; set; }
    
        public virtual Patient_Info Patient_Info { get; set; }
    }
}
