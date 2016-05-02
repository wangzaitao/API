namespace LFTHW.Model
{
    using System;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class S_City
    {
        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public long ProvinceID { get; set; }

        [StringLength(100)]
        public string ZipCode { get; set; }

        public byte? IsSubSite { get; set; }

        [Column(TypeName = "text")]
        public string Remark { get; set; }
    }
}
