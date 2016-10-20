namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_sms_provider")]
    public partial class sline_sms_provider
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Required]
        [StringLength(1000)]
        public string config_url { get; set; }

        [Required]
        [StringLength(1000)]
        public string execute_file { get; set; }

        [Required]
        [StringLength(1000)]
        public string execute_classname { get; set; }

        [Column(TypeName = "uint")]
        public long isopen { get; set; }

        [StringLength(1073741823)]
        public string exdata { get; set; }
    }
}
