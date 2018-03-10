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
    
    public partial class SYSSection
    {
        public int SectionID { get; set; }
        public string SectionName { get; set; }
        public Nullable<bool> FunctionType { get; set; }
        public string DisplayMenu { get; set; }
        public Nullable<bool> IsDel { get; set; }
        public string InterfaceType { get; set; }
        public Nullable<bool> IsNotSamePage { get; set; }
        public Nullable<bool> IsNonPrintSectSummary { get; set; }
        public Nullable<bool> IsOwnInterface { get; set; }
        public Nullable<bool> IsAutoApprove { get; set; }
        public string ImageType { get; set; }
        public string PicPrintSetup { get; set; }
        public string PacsInterfaceFlag { get; set; }
        public string InputCode { get; set; }
        public Nullable<int> DispOrder { get; set; }
        public string SummaryName { get; set; }
        public string DefaultSummary { get; set; }
        public string SepBetweenExamItems { get; set; }
        public string SepBetweenSymptoms { get; set; }
        public string TerminalSymbol { get; set; }
        public string SepExamAndValue { get; set; }
        public string NoBetweenExamItems { get; set; }
        public string NoBetweenSympotms { get; set; }
        public string Note { get; set; }
        public Nullable<bool> IsNoEntryFinalSummary { get; set; }
        public Nullable<bool> IsNonPrintInReport { get; set; }
        public Nullable<int> IsPrintBarCode { get; set; }
    }
}
