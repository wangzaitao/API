namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_photo")]
    public partial class sline_photo
    {
        public int id { get; set; }

        public int webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(255)]
        public string seotitle { get; set; }

        [StringLength(200)]
        public string litpic { get; set; }

        [StringLength(50)]
        public string author { get; set; }

        [StringLength(1073741823)]
        public string content { get; set; }

        [StringLength(200)]
        public string tagword { get; set; }

        public int? shownum { get; set; }

        public int? modtime { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(255)]
        public string themelist { get; set; }

        [StringLength(255)]
        public string attrid { get; set; }

        [Column(TypeName = "uint")]
        public long? headimgid { get; set; }

        public int addtime { get; set; }

        public int? favorite { get; set; }

        public sbyte? ishidden { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        public int? finaldestid { get; set; }
    }
}
