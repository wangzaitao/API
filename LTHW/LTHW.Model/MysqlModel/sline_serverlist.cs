namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_serverlist")]
    public partial class sline_serverlist
    {
        public int id { get; set; }

        public int? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(20)]
        public string servername { get; set; }

        [StringLength(50)]
        public string keywords { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(1073741823)]
        public string content { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [Column(TypeName = "uint")]
        public long? isdisplay { get; set; }

        public int? isauto { get; set; }

        public int? displayorder { get; set; }

        public int? sline_yqlj { get; set; }

        public int? mobileshow { get; set; }
    }
}
