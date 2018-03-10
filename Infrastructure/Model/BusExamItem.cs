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
    
    public partial class BusExamItem
    {
        public int ExamItemID { get; set; }
        public string ExamItemName { get; set; }
        public string GetResultWay { get; set; }
        public string ExamItemCode { get; set; }
        public Nullable<int> SectionID { get; set; }
        public Nullable<bool> IsLisValueNull { get; set; }
        public Nullable<bool> IsEntrySectSum { get; set; }
        public Nullable<int> EntrySectSumLevel { get; set; }
        public Nullable<bool> IsAutoCalc { get; set; }
        public string CalcExpression { get; set; }
        public Nullable<int> SymCols { get; set; }
        public Nullable<int> TextboxRows { get; set; }
        public Nullable<bool> IsSameRow { get; set; }
        public string ExamItemUnit { get; set; }
        public Nullable<double> MaleHiLimit { get; set; }
        public Nullable<double> MaleLoLimit { get; set; }
        public Nullable<double> FemaleHiLimit { get; set; }
        public Nullable<double> FemaleLoLimit { get; set; }
        public Nullable<bool> IsSymMultiValue { get; set; }
        public string InputCode { get; set; }
        public Nullable<int> DispOrder { get; set; }
        public string Note { get; set; }
        public Nullable<int> ForGender { get; set; }
        public Nullable<bool> IsExamItemNonPrintInReport { get; set; }
        public Nullable<int> ExamItemGroupID { get; set; }
        public string AbbrExamName { get; set; }
    }
}
