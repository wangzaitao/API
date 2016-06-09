namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_hotel_extend_field")]
    public partial class sline_hotel_extend_field
    {
        public int id { get; set; }

        public int? productid { get; set; }

        [StringLength(255)]
        public string e_engname { get; set; }

        [StringLength(16777215)]
        public string e_newcontent { get; set; }
    }
}
