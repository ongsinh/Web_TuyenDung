﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_TuyenDung.Models
{
    [Table("tbl_ViecLam")]
    public class ViecLam
    {
        [Key, Column("iMaViecLam"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaViecLam { get; set; }

        [Column("sTieuDe"), StringLength(255)]
        [Required(ErrorMessage = "Không được bỏ trống")]
        //[RegularExpression(@"^\d.*", ErrorMessage = "Tiêu đề phải bắt đầu bằng chữ số")]
        //[MinLength(10, ErrorMessage = "Tiêu đề phải có ít nhất 10 kí tự")]
        public string TieuDe { get; set; }

        [Column("sMota", TypeName = "nvarchar(max)")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string MoTa { get; set; }

        [Column("sTTLienHe", TypeName = "nvarchar(max)")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string TTLienHe { get; set; }

        [Column("fMucLuong", TypeName = "float")]
        [Required(ErrorMessage = "Không được bỏ trống"), Range(1, float.MaxValue, ErrorMessage = "Mức lương không hợp lệ")]
        public float MucLuong { get; set; }

        [Column("dNgayTao")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public DateTime NgayTao { get; set; }

        [Column("dNgayHetHan")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public DateTime NgayHetHan { get; set; }

        [Column("bTrangThai", TypeName = "bit"), Required]
        public Boolean TrangThai { get; set; }

        public ICollection<DonUngTuyen>? DSDonUT { get; set; }


        [Required(ErrorMessage = "Không được bỏ trống")]
        [RegularExpression(@"^\d.*", ErrorMessage = "Tiêu đề phải bắt đầu bằng chữ số")]
        [MinLength(10, ErrorMessage = "Tiêu đề phải có ít nhất 10 kí tự")]
        public string VerifyKey { get; set; }


    }
}
