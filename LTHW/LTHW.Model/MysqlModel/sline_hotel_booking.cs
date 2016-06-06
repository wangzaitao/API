namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_hotel_booking")]
    public partial class sline_hotel_booking
    {
        public int id { get; set; }

        public int webid { get; set; }

        public int hotelid { get; set; }

        [StringLength(255)]
        public string hotelname { get; set; }

        [StringLength(255)]
        public string hotelrank { get; set; }

        [StringLength(255)]
        public string roomname { get; set; }

        [StringLength(50)]
        public string startdate { get; set; }

        [Column(TypeName = "uint")]
        public long? dingdays { get; set; }

        [StringLength(100)]
        public string dingnum { get; set; }

        [StringLength(255)]
        public string hotelprice { get; set; }

        [StringLength(255)]
        public string info { get; set; }

        [StringLength(255)]
        public string dingname { get; set; }

        [StringLength(255)]
        public string sex { get; set; }

        [StringLength(255)]
        public string dingtel { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [Column(TypeName = "uint")]
        public long? status { get; set; }

        [StringLength(255)]
        public string ordersn { get; set; }

        [StringLength(255)]
        public string bianhao { get; set; }

        public int userid { get; set; }

        public decimal price { get; set; }

        [StringLength(50)]
        public string enddate { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(20)]
        public string qq { get; set; }
    }
}
