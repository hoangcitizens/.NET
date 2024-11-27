namespace Lab11
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbSinhVien")]
    public partial class tbSinhVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSV { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        public int? MaCS { get; set; }

        public int? MaLop { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
