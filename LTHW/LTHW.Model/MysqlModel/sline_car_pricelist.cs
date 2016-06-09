namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_car_pricelist")]
    public partial class sline_car_pricelist
    {
        public int id { get; set; }

        public int? min { get; set; }

        public int? max { get; set; }

        public int? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }
    }
}
