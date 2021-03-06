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
    
    public partial class UD
    {
        public int UDS_ID { get; set; }
        public int Patient_ID { get; set; }
        public int Gu_No { get; set; }
        public int Gu_Year { get; set; }
        public string Complaints { get; set; }
        public string Assoc_Illness { get; set; }
        public string Anal_Tone { get; set; }
        public string BCR { get; set; }
        public string Exam_Other { get; set; }
        public string Peak_Flow_Rate { get; set; }
        public string Voided_Volume { get; set; }
        public string Residual_Volume { get; set; }
        public string Uroflow_Rmks { get; set; }
        public string Filling_Rate { get; set; }
        public string Capacity { get; set; }
        public string Compliance { get; set; }
        public string Stability { get; set; }
        public string Sensation { get; set; }
        public string DLPP { get; set; }
        public string VLPP { get; set; }
        public string Stress_Inc { get; set; }
        public string Fill_Other { get; set; }
        public string Fill_Rmks { get; set; }
        public string Detrusor_Press { get; set; }
        public string VoidPhase_Flow_Rate { get; set; }
        public string Sph_Activity { get; set; }
        public string Residual_Urine { get; set; }
        public string Void_Other { get; set; }
        public string Void_Rmks { get; set; }
        public string Conclusion { get; set; }
        public string Advise { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Create_Dte { get; set; }
        public string Modify_By { get; set; }
        public Nullable<System.DateTime> Modify_Dte { get; set; }
    
        public virtual Patient_Info Patient_Info { get; set; }
    }
}
