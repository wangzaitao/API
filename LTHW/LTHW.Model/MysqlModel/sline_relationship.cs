namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_relationship")]
    public partial class sline_relationship
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? kindid { get; set; }

        [StringLength(255)]
        public string destinationid { get; set; }

        [Column(TypeName = "uint")]
        public long? typeid { get; set; }
    }
}
