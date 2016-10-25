namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_stats")]
    public partial class sline_stats
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long access_time { get; set; }

        [Required]
        [StringLength(15)]
        public string ip_address { get; set; }

        [Column(TypeName = "usmallint")]
        public int visit_times { get; set; }

        [Required]
        [StringLength(60)]
        public string browser { get; set; }

        [Required]
        [StringLength(20)]
        public string system { get; set; }

        [Required]
        [StringLength(20)]
        public string language { get; set; }

        [Required]
        [StringLength(100)]
        public string referer_domain { get; set; }

        [Required]
        [StringLength(200)]
        public string referer_path { get; set; }

        [Required]
        [StringLength(255)]
        public string access_url { get; set; }

        [Required]
        [StringLength(255)]
        public string searchengine { get; set; }

        [Required]
        [StringLength(255)]
        public string keywords { get; set; }

        public int keynum { get; set; }

        public int webid { get; set; }

        [Column(TypeName = "uint")]
        public long? timemark { get; set; }

        [StringLength(255)]
        public string title { get; set; }
    }
}
