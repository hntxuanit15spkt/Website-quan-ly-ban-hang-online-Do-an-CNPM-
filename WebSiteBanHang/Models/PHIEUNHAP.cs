//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSiteBanHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUNHAP
    {
        public PHIEUNHAP()
        {
            this.CHITIETPHIEUNHAPs = new HashSet<CHITIETPHIEUNHAP>();
        }
    
        public int MaPN { get; set; }
        public Nullable<int> MaNCC { get; set; }
        public Nullable<System.DateTime> ThoiDiemNhap { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<decimal> TongChiPhi { get; set; }
    
        public virtual ICollection<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
