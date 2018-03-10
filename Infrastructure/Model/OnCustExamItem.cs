//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OnCustExamItem
    {
        public int ID_CustExamItem { get; set; }
        public Nullable<int> ID_CustFee { get; set; }
        public Nullable<int> ID_Fee { get; set; }
        public int ID_ExamItem { get; set; }
        public string ExamItemName { get; set; }
        public Nullable<int> DiseaseLevel { get; set; }
        public string ResultLabValues { get; set; }
        public Nullable<double> ResultNumber { get; set; }
        public Nullable<double> ResultLabLowLimit { get; set; }
        public Nullable<double> ResultLabHighLimit { get; set; }
        public string ResultLabUnit { get; set; }
        public string ResultLabMark { get; set; }
        public string ResultSummary { get; set; }
        public Nullable<int> ID_SummaryDoctor { get; set; }
        public string SummaryDoctorName { get; set; }
        public string TypistName { get; set; }
        public System.DateTime ExamItemSummaryDate { get; set; }
        public Nullable<int> ID_Typist { get; set; }
        public string ResultLabRange { get; set; }
        public Nullable<long> ID_Customer { get; set; }
        public string AbbrExamName { get; set; }
        public string DetectionMethod { get; set; }
        public string SCO { get; set; }
        public string ID_CustApply { get; set; }
    }
}
