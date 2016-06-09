namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_m_nav")]
    public partial class sline_m_nav
    {
        public int id { get; set; }

        public int? navid { get; set; }

        [StringLength(200)]
        public string m_url { get; set; }

        [StringLength(50)]
        public string m_title { get; set; }

        [StringLength(255)]
        public string m_ico { get; set; }

        public int? m_displayorder { get; set; }

        public int? m_isopen { get; set; }
    }
}
