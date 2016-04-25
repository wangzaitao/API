namespace LFTHW.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    

    public partial class UP_OrderDetail
    {
        public long ID { get; set; }

        public long OrderID { get; set; }

        public long PdtID { get; set; }

        [StringLength(200)]
        public string PdtName { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? ItemsCount { get; set; }

        public decimal? Amount { get; set; }

        public byte? IsDiscount { get; set; }

        public decimal? Discount { get; set; }

        public decimal? SaveMoney { get; set; }

        public long? GetScores { get; set; }

        public byte? IsComment { get; set; }

        public int? IsDelete { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
