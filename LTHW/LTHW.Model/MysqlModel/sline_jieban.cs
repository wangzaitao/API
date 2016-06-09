namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_jieban")]
    public partial class sline_jieban
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        public int? dest_mainid { get; set; }

        public int? dest_childid { get; set; }

        public sbyte? day { get; set; }

        [StringLength(255)]
        public string attrid { get; set; }

        public int? childnum { get; set; }

        public int? adultnum { get; set; }

        [StringLength(255)]
        public string vartime { get; set; }

        [StringLength(255)]
        public string lineid { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string memo { get; set; }

        [StringLength(255)]
        public string startdate { get; set; }

        public int? addtime { get; set; }

        [StringLength(255)]
        public string memberid { get; set; }

        [Column(TypeName = "uint")]
        public long ishidden { get; set; }

        [StringLength(50)]
        public string iconlist { get; set; }

        public bool? status { get; set; }

        [StringLength(255)]
        public string userdest { get; set; }

        [StringLength(500)]
        public string usertheme { get; set; }

        public int? shownum { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public int? finaldestid { get; set; }
    }
}
