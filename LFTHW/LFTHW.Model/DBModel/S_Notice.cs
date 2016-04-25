namespace LFTHW.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class S_Notice
    {
        public long ID { get; set; }

        public long? ShopID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public byte? Type { get; set; }

        public byte? IsTop { get; set; }

        public byte? IsShow { get; set; }

        public int? OrderBy { get; set; }

        public DateTime? CreatTime { get; set; }

        public long? CreatUser { get; set; }

        public DateTime? ModifyTime { get; set; }

        public long? ModifyUser { get; set; }
    }
}
