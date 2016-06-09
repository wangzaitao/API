namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_car_extend_field")]
    public partial class sline_car_extend_field
    {
        public int id { get; set; }

        public int? productid { get; set; }

        [StringLength(255)]
        public string e_cartext { get; set; }

        [StringLength(16777215)]
        public string e_xinneng { get; set; }
    }
}
