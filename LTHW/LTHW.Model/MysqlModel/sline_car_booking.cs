namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_car_booking")]
    public partial class sline_car_booking
    {
        public int id { get; set; }

        public int? webid { get; set; }

        public int? carid { get; set; }

        [StringLength(255)]
        public string carname { get; set; }

        [Column(TypeName = "date")]
        public DateTime? starttime { get; set; }

        public int? days { get; set; }

        public int? num { get; set; }

        public float? carprice { get; set; }

        [StringLength(16777215)]
        public string info { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string sex { get; set; }

        public long? telephone { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        public int? status { get; set; }

        [StringLength(255)]
        public string ordersn { get; set; }

        [StringLength(255)]
        public string bianhao { get; set; }

        public int userid { get; set; }

        public decimal price { get; set; }
    }
}
