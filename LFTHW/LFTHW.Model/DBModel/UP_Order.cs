namespace LFTHW.Model
{
    using System;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class UP_Order
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderNO { get; set; }

        public long UserID { get; set; }

        public long? ShopID { get; set; }

        [Required]
        [StringLength(20)]
        public string AcceptName { get; set; }

        [StringLength(200)]
        public string AcceptAddress { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        public decimal? Amount { get; set; }

        public byte? IsNoFreight { get; set; }

        public decimal? Freight { get; set; }

        public decimal? PMoney { get; set; }

        public byte? IsVirtual { get; set; }

        public byte? IsExpress { get; set; }

        [StringLength(50)]
        public string ExpressCompanyNo { get; set; }

        [StringLength(50)]
        public string ExpressCompany { get; set; }

        [StringLength(50)]
        public string ExpressNo { get; set; }

        [Column(TypeName = "text")]
        public string ConsumerRemark { get; set; }

        [StringLength(200)]
        public string ExpressTime { get; set; }

        public int State { get; set; }

        [Column(TypeName = "text")]
        public string CancelRemark { get; set; }

        public long? GetScores { get; set; }

        public byte? IsDelete { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
