namespace LFTHW.Model
{
    using System;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class S_District
    {
        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public long CityID { get; set; }

        [Column(TypeName = "text")]
        public string Remark { get; set; }
    }
}
