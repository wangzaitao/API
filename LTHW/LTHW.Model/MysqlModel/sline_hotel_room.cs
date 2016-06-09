namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_hotel_room")]
    public partial class sline_hotel_room
    {
        public int id { get; set; }

        public int webid { get; set; }

        public int? hotelid { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string roomname { get; set; }

        [Column(TypeName = "uint")]
        public long? price { get; set; }

        [Column(TypeName = "uint")]
        public long? sellprice { get; set; }

        [StringLength(255)]
        public string breakfirst { get; set; }

        [StringLength(255)]
        public string computer { get; set; }

        [StringLength(255)]
        public string otherprice { get; set; }

        public int? displayorder { get; set; }

        [StringLength(255)]
        public string otherroom { get; set; }

        [StringLength(255)]
        public string otherroomurl { get; set; }

        [StringLength(255)]
        public string nightdays { get; set; }

        [StringLength(255)]
        public string roomids { get; set; }

        [StringLength(255)]
        public string roomstyle { get; set; }

        [StringLength(255)]
        public string roomarea { get; set; }

        [StringLength(255)]
        public string roomfloor { get; set; }

        [StringLength(255)]
        public string roomwindow { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string piclist { get; set; }

        public int? number { get; set; }

        public int? jifencomment { get; set; }

        public int? jifentprice { get; set; }

        public int? jifenbook { get; set; }

        [Column(TypeName = "uint")]
        public long? paytype { get; set; }

        [StringLength(255)]
        public string dingjin { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string lastoffer { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string description { get; set; }
    }
}
