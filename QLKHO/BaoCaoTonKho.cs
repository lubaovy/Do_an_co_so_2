//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKHO
{
    using System;
    using System.Collections.Generic;
    
    public partial class BaoCaoTonKho
    {
        public int Id { get; set; }
        public int IdHangHoa { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<int> SLTonKho { get; set; }
    
        public virtual HangHoa HangHoa { get; set; }
    }
}