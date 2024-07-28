using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_TuyenDung.Models
{
    [Table("tbl_ViecLam")]
    public class ViecLam
    {
        [Key, Column("iMaViecLam"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaViecLam { get; set; }

        [Column("sTieuDe"), Required, StringLength(255)]
        public string TieuDe {  get; set; }
        
        [Column("sMota", TypeName = "nvarchar(max)"), Required] 
        public string MoTa { get; set;}

        [Column("sTTLienHe", TypeName = "nvarchar(max)"), Required]
        public string TTLienHe { get; set; }

        [Column("fMucLuong", TypeName ="float"), Required]
        public float MucLuong { get; set; }

        [Column("dNgayTao"), Required]
        public DateTime NgayTao { get; set; }

        [Column("dNgayHetHan"), Required]
        public DateTime NgayHetHan { get; set; }

        [Column("bTrangThai", TypeName = "bit"), Required]
        public Boolean TrangThai { get; set; }

        public ICollection<DonUngTuyen>? DSDonUT { get; set; }



    }
}
