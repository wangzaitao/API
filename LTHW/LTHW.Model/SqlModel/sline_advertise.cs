namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_advertise")]
    public partial class sline_advertise
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        public int? typeid { get; set; }

        [StringLength(255)]
        public string tagname { get; set; }

        [StringLength(255)]
        public string adposition { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string normalbody { get; set; }

        [StringLength(255)]
        public string expirebody { get; set; }

        [Column(TypeName = "uint")]
        public long? starttime { get; set; }

        [Column(TypeName = "uint")]
        public long? endtime { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [StringLength(255)]
        public string picurl { get; set; }

        [StringLength(255)]
        public string linkurl { get; set; }

        public int? adtype { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [StringLength(255)]
        public string linktext { get; set; }

        public int? displayorder { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        public bool? ishidden { get; set; }
    }
}
