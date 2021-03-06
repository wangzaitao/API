namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_member")]
    public partial class sline_member
    {
        [Key]
        [Column(TypeName = "umediumint")]
        public int mid { get; set; }

        [StringLength(255)]
        public string pid { get; set; }

        [StringLength(20)]
        public string mtype { get; set; }

        [StringLength(255)]
        public string nickname { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string pwd { get; set; }

        [StringLength(36)]
        public string truename { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string sex { get; set; }

        [Column(TypeName = "usmallint")]
        public int? rank { get; set; }

        [Column(TypeName = "umediumint")]
        public int? money { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string email { get; set; }

        [StringLength(15)]
        public string mobile { get; set; }

        [Column(TypeName = "mediumint")]
        public int? jifen { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [StringLength(255)]
        public string safequestion { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string safeanswer { get; set; }

        [Column(TypeName = "uint")]
        public long? jointime { get; set; }

        [Column(TypeName = "char")]
        [StringLength(16)]
        public string joinip { get; set; }

        [Column(TypeName = "uint")]
        public long? logintime { get; set; }

        [Column(TypeName = "char")]
        [StringLength(16)]
        public string loginip { get; set; }

        public short? checkmail { get; set; }

        [Column(TypeName = "uint")]
        public long? checkphone { get; set; }

        [StringLength(50)]
        public string province { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(20)]
        public string cardid { get; set; }

        [StringLength(200)]
        public string address { get; set; }

        [StringLength(8)]
        public string postcode { get; set; }

        [StringLength(255)]
        public string connectid { get; set; }

        [StringLength(255)]
        public string from { get; set; }

        [StringLength(255)]
        public string remarks { get; set; }

        public bool? regtype { get; set; }
    }
}
