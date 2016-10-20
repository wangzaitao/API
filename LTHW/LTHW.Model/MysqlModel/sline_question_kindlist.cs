namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_question_kindlist")]
    public partial class sline_question_kindlist
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long kindid { get; set; }

        [StringLength(255)]
        public string seotitle { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string jieshao { get; set; }

        [Column(TypeName = "uint")]
        public long isfinishseo { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? isnav { get; set; }

        [Column(TypeName = "uint")]
        public long? ishot { get; set; }
    }
}
