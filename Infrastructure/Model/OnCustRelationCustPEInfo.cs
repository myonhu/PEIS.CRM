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
    
    public partial class OnCustRelationCustPEInfo
    {
        public int ID_CustRelation { get; set; }
        public Nullable<int> ID_ArcCustomer { get; set; }
        public string IDCardNo { get; set; }
        public string ExamCardNo { get; set; }
        public Nullable<long> ID_Customer { get; set; }
        public Nullable<bool> Is_CompletePhysical { get; set; }
        public Nullable<int> ExamState { get; set; }
    }
}