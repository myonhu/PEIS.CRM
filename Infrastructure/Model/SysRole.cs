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
    
    public partial class SysRole
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int DispOrder { get; set; }
        public int Is_Locked { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public Nullable<int> Is_DefaultRole { get; set; }
    }
}
