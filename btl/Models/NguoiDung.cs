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

    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            this.HoaDons = new HashSet<HoaDon>();
        }
    
        public int MaND { get; set; }
        [Display(Name = "Họ")]
        [StringLength(10, ErrorMessage = "{0} không quá 10 kí tự !")]
        [Required(ErrorMessage = "{0} Không được để trống !")]
        public string Ho { get; set; }
        [Display(Name = "Tên")]
        [StringLength(10, ErrorMessage = "{0} không quá 10 kí tự !")]
        [Required(ErrorMessage = "{0} Không được để trống !")]
        public string Ten { get; set; }
        [Display(Name = "Giới Tính")]
        public bool GioiTinh { get; set; }
        [Display(Name = "Số Điện Thoại")]
        [StringLength(10, ErrorMessage = "{0} không quá 10 kí tự !")]
        [Required(ErrorMessage = "{0} Không được để trống !")]
        public string SDT { get; set; }
        [Display(Name = "Email")]
        [StringLength(30, ErrorMessage = "{0} không quá 30 kí tự !")]
        [Required(ErrorMessage = "{0} Không được để trống !")]
        public string Email { get; set; }
        [Display(Name = "Địa Chỉ")]
        [StringLength(200, ErrorMessage = "{0} không quá 200 kí tự !")]
        [Required(ErrorMessage = "{0} Không được để trống !")]
        public string DiaChi { get; set; }
        [Display(Name = "Tài Khoản")]
        [StringLength(50, ErrorMessage = "{0} không quá 50 kí tự !")]
        [Required(ErrorMessage = "{0} Không được để trống !")]
        public string TaiKhoan { get; set; }
        [Display(Name = "Mật Khẩu")]
        [StringLength(50, ErrorMessage = "{0} không quá 50 kí tự !")]
        [Required(ErrorMessage = "{0} Không được để trống !")]
        public string MatKhau { get; set; }
        public int MaQuyen { get; set; }
        public bool TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual PhanQuyen PhanQuyen { get; set; }
    }
}
