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
    
    public partial class OnCustExamSection
    {
        public int ID_CustExamSection { get; set; }
        public Nullable<long> ID_Customer { get; set; }
        public Nullable<int> ID_Section { get; set; }
        public string CustomerName { get; set; }
        public string SectionName { get; set; }
        public Nullable<int> DiseaseLevel { get; set; }
        public Nullable<System.DateTime> SectionSummaryDate { get; set; }
        public string SectionSummary { get; set; }
        public string PositiveSummary { get; set; }
        public Nullable<int> ID_SummaryDoctor { get; set; }
        public string SummaryDoctorName { get; set; }
        public Nullable<int> ID_Typist { get; set; }
        public string TypistName { get; set; }
        public Nullable<System.DateTime> TypistDate { get; set; }
        public Nullable<bool> Is_Check { get; set; }
        public string CheckerName { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public Nullable<int> ID_Checker { get; set; }
        public Nullable<bool> IS_giveup { get; set; }
        public Nullable<bool> IS_Refund { get; set; }
        public string ImageUrl { get; set; }
        public string ExamProjectName { get; set; }
    }
}