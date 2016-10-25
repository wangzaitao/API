namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_search")]
    public partial class sline_search
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string channelname { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        public long? typeid { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string title { get; set; }

        [StringLength(1073741823)]
        public string description { get; set; }

        [StringLength(1073741823)]
        public string litpic { get; set; }

        public int? shownum { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(255)]
        public string attrid { get; set; }

        public long? headimgid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tid { get; set; }

        public int? ishidden { get; set; }
    }
}
