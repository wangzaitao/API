namespace LFTHW.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class UP_UserConsume
    {
        public long ID { get; set; }

        public long UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string ConsumeNo { get; set; }

        public DateTime Time { get; set; }

        public decimal Money { get; set; }

        public byte? InOrOut { get; set; }

        public int? Type { get; set; }

        [StringLength(100)]
        public string Account { get; set; }

        public long? PdtID { get; set; }

        public long? OrderID { get; set; }

        public long? GetScores { get; set; }

        [Column(TypeName = "text")]
        public string Remark { get; set; }

        public byte? Status { get; set; }
    }
}
