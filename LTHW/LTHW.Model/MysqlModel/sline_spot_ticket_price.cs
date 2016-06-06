namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_spot_ticket_price")]
    public partial class sline_spot_ticket_price
    {
        public int? spotid { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ticketid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int day { get; set; }

        public int? childprofit { get; set; }

        public int? childbasicprice { get; set; }

        public int? childprice { get; set; }

        public int? childmarketprice { get; set; }

        public int? childdistributionprice { get; set; }

        public int? oldprofit { get; set; }

        public int? oldbasicprice { get; set; }

        public int? oldprice { get; set; }

        public int? olddistributionprice { get; set; }

        public int? oldmarketprice { get; set; }

        public int? adultprofit { get; set; }

        public int? adultbasicprice { get; set; }

        public int? adultprice { get; set; }

        public int? adultmarketprice { get; set; }

        public int? adultdistributionprice { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public int? number { get; set; }
    }
}
