namespace BTL_QLNS3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            DANGNHAPs = new HashSet<DANGNHAP>();
        }

        [Key]
        [StringLength(10)]
        /*[Display(Name ="ID Nhân Viên")]*/
        public string id_Nv { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Họ và tên")]
        public string name_Nv { get; set; }

        [Column(TypeName = "date")]

        [Display(Name = "Ngày Sinh")]
        public DateTime ngaysinh_Nv { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Dịa chỉ")]
        public string diachi_Nv { get; set; }

        [Display(Name = "Tiên Lương")]
        public int luong_Nv { get; set; }

        [Required]
        [StringLength(10)]

        [Display(Name = "Phòng Ban")]
        public string id_Pb { get; set; }

        [Required]
        [StringLength(10)]

        [Display(Name = "Dự Án")]
        public string id_Da { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANGNHAP> DANGNHAPs { get; set; }

        public virtual DUAN DUAN { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }
    }
}
