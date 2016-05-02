namespace LFTHW.Model
{
    using System;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class UP_Cart
    {
        public long ID { get; set; }

        public long UserID { get; set; }

        public long PdtID { get; set; }

        [StringLength(200)]
        public string PdtName { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? ItemsCount { get; set; }

        public decimal? Amount { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
