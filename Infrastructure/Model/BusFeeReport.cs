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
    
    public partial class BusFeeReport
    {
        public int FeeReportID { get; set; }
        public Nullable<int> FeeID { get; set; }
        public string FeeName { get; set; }
        public string ReportKey { get; set; }
        public string ImageUrl { get; set; }
        public string Note { get; set; }
        public Nullable<bool> IsDel { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> OperateDate { get; set; }
        public Nullable<int> OperateType { get; set; }
        public string DelDescribe { get; set; }
    }
}
