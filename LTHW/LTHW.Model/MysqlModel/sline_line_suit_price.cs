namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_line_suit_price")]
    public partial class sline_line_suit_price
    {
        public int lineid { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int suitid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int day { get; set; }

        public int? childprofit { get; set; }

        public int? childbasicprice { get; set; }

        public int? childprice { get; set; }

        public int? oldprofit { get; set; }

        public int? oldbasicprice { get; set; }

        public int? oldprice { get; set; }

        public int? adultprofit { get; set; }

        public int? adultbasicprice { get; set; }

        public int? adultprice { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public int? number { get; set; }

        public int? roombalance { get; set; }
    }
}
