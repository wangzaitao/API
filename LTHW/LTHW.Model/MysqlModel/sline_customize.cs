namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_customize")]
    public partial class sline_customize
    {
        public int id { get; set; }

        [StringLength(80)]
        public string dest { get; set; }

        public int? starttime { get; set; }

        [StringLength(80)]
        public string startplace { get; set; }

        public int? days { get; set; }

        public int? adultnum { get; set; }

        public int? childnum { get; set; }

        [StringLength(30)]
        public string planerank { get; set; }

        [StringLength(30)]
        public string hotelrank { get; set; }

        [StringLength(30)]
        public string room { get; set; }

        [StringLength(30)]
        public string food { get; set; }

        [StringLength(6)]
        public string sex { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(30)]
        public string phone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string contacttime { get; set; }

        public int? addtime { get; set; }

        [StringLength(30)]
        public string contactname { get; set; }

        public sbyte? status { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content { get; set; }

        public bool? viewstatus { get; set; }
    }
}
