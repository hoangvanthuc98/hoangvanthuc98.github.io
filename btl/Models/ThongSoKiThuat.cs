﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace btl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ThongSoKiThuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongSoKiThuat()
        {
            this.ThongSoSanPhams = new HashSet<ThongSoSanPham>();
        }

        [Display(Name = "Mã Thông Số Kĩ Thuật")]
        public int MaTSKT { get; set; }
        [Display(Name = "Tên Thông Số Kĩ Thuật")]
        [Required(ErrorMessage = "{0} không được để trống !")]

        public string TenTSKT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongSoSanPham> ThongSoSanPhams { get; set; }
    }
}
