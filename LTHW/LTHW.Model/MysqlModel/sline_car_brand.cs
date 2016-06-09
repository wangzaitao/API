namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_car_brand")]
    public partial class sline_car_brand
    {
        public int id { get; set; }

        public int? webid { get; set; }

        [StringLength(255)]
        public string kindname { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(16777215)]
        public string description { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        public int? displayorder { get; set; }
    }
}
