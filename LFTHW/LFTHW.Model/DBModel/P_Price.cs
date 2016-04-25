namespace LFTHW.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class P_Price
    {
        public long ID { get; set; }

        public long PdtID { get; set; }

        [Required]
        [StringLength(100)]
        public string PriceType { get; set; }

        public decimal? MenShiPrice { get; set; }

        public decimal? YouHuiPrice { get; set; }

        public decimal? ErTongPrice { get; set; }

        public decimal? HuiYuanPrice { get; set; }

        public decimal? TongHangPrice { get; set; }

        [Column(TypeName = "text")]
        public string PriceIntroduces { get; set; }

        public DateTime? PriceDate { get; set; }

        public byte? OrderBy { get; set; }

        public byte? Flag { get; set; }

        public byte? IsShow { get; set; }

        public byte? IsDelete { get; set; }

        public DateTime? CreatTime { get; set; }

        public long? CreatUser { get; set; }

        public DateTime? ModifyTime { get; set; }

        public long? ModifyUser { get; set; }
    }
}
