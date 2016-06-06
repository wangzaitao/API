namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_search_keyword")]
    public partial class sline_search_keyword
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [Column(TypeName = "uint")]
        public long? keynumber { get; set; }

        public int? displayorder { get; set; }

        public int? isopen { get; set; }

        public int? addtime { get; set; }
    }
}
