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
    
    public partial class BusConclusionType
    {
        public int ID_ConclusionType { get; set; }
        public string ConclusionTypeName { get; set; }
        public string InputCode { get; set; }
        public Nullable<bool> IS_Banned { get; set; }
        public Nullable<int> ID_BanOpr { get; set; }
        public string BanOperator { get; set; }
        public Nullable<System.DateTime> BanDate { get; set; }
        public string BanDescribe { get; set; }
    }
}
