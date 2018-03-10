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
    
    public partial class BusFee
    {
        public int ID_Fee { get; set; }
        public Nullable<int> ID_Section { get; set; }
        public Nullable<int> ID_Specimen { get; set; }
        public string FeeName { get; set; }
        public Nullable<int> ForGender { get; set; }
        public string ReportFeeName { get; set; }
        public string FeeCode { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string InputCode { get; set; }
        public string SectionName { get; set; }
        public string SpecimenName { get; set; }
        public string WorkGroupCode { get; set; }
        public string WorkStationCode { get; set; }
        public string WorkBenchCode { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<bool> Is_Banned { get; set; }
        public Nullable<int> ID_BanOpr { get; set; }
        public string BanDescribe { get; set; }
        public Nullable<int> DispOrder { get; set; }
        public string Note { get; set; }
        public Nullable<int> BreakfastOrder { get; set; }
        public Nullable<bool> Is_FeeNonPrintInReport { get; set; }
        public string InterfaceName { get; set; }
        public Nullable<bool> IS_FeeReportMerger { get; set; }
        public Nullable<int> ID_FeeReportMerger { get; set; }
        public string OperationalDate { get; set; }
    }
}