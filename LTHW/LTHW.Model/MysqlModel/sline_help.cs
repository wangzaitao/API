namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_help")]
    public partial class sline_help
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [Column(TypeName = "uint")]
        public long? kindid { get; set; }

        [StringLength(1073741823)]
        public string body { get; set; }

        public int? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [StringLength(255)]
        public string type_id { get; set; }
    }
}
