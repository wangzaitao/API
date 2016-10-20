namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_car_suit_price")]
    public partial class sline_car_suit_price
    {
        public int carid { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int suitid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int day { get; set; }

        public int? adultprofit { get; set; }

        public int? adultbasicprice { get; set; }

        public int? adultprice { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? number { get; set; }
    }
}
