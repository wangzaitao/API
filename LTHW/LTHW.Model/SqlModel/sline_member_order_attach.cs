namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_member_order_attach")]
    public partial class sline_member_order_attach
    {
        public int id { get; set; }

        public int? orderid { get; set; }

        [StringLength(50)]
        public string manname { get; set; }

        [StringLength(255)]
        public string manphone { get; set; }

        [StringLength(255)]
        public string manweixin { get; set; }

        [StringLength(255)]
        public string manheight { get; set; }

        [StringLength(255)]
        public string manweight { get; set; }

        [StringLength(255)]
        public string womenname { get; set; }

        [StringLength(255)]
        public string womenphone { get; set; }

        [StringLength(255)]
        public string womenweixin { get; set; }

        [StringLength(255)]
        public string womenheight { get; set; }

        [StringLength(255)]
        public string womenweight { get; set; }

        [StringLength(255)]
        public string shotdate { get; set; }

        [StringLength(255)]
        public string shotdays { get; set; }

        [StringLength(255)]
        public string clothesnum { get; set; }

        [StringLength(255)]
        public string clothesdate { get; set; }

        [StringLength(255)]
        public string dressing { get; set; }

        [StringLength(255)]
        public string dressnum { get; set; }

        [StringLength(255)]
        public string video { get; set; }

        [StringLength(255)]
        public string dresssite { get; set; }

        [StringLength(255)]
        public string dresstime { get; set; }

        [StringLength(255)]
        public string shotlaunch { get; set; }

        [StringLength(255)]
        public string shottravel { get; set; }

        [StringLength(255)]
        public string shotspot { get; set; }

        [StringLength(255)]
        public string startdate { get; set; }

        [StringLength(255)]
        public string startairline { get; set; }

        [StringLength(255)]
        public string backdate { get; set; }

        [StringLength(255)]
        public string backairline { get; set; }

        [StringLength(255)]
        public string traveltime { get; set; }

        [StringLength(255)]
        public string hotelname { get; set; }

        [StringLength(255)]
        public string hotelarea { get; set; }

        [StringLength(255)]
        public string airportaccept { get; set; }

        [StringLength(255)]
        public string freetravel { get; set; }

        [StringLength(255)]
        public string shotnum { get; set; }
    }
}
